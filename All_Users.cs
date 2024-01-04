using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Way_to_Deen
{
    public partial class All_Users : Form
    {
        public All_Users()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UJGC92B\SQLEXPRESS;Initial Catalog=WaytoDeen;Integrated Security=True");
        string s;
        private void All_Users_Load(object sender, EventArgs e)
        {

        }


        private void panel_register_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Hide();
           admin.Show();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Hide();
        }
        
        private void button13_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.no_image_avaiable;
            BindGridView();
        }
        public void BindGridView()
        {
            string query = "select * from Profileuser";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;


            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView1.Columns[9];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dataGridView1.RowTemplate.Height = 80;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.no_image_avaiable;
            if (radioButton1.Checked == true)
            {
                s = "Male";
            }
            else
            {
                s = "Female";
            }


            if (textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1 && dateTimePicker1.Value != DateTime.MinValue &&  textBox6.Text != "" && textBox1.Text != "" && pictureBox1.Image != null)

            {
                string query = "insert into Profileuser values(@name,@mobile,@bg,@email,@nid,@gender,@maritalstat,@dob,@username,@image)";
                SqlCommand cmd = new SqlCommand(query, con);
               // cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@name", textBox3.Text);
                cmd.Parameters.AddWithValue("@mobile", textBox4.Text);
                cmd.Parameters.AddWithValue("@bg", comboBox1.SelectedItem);
                cmd.Parameters.AddWithValue("@email", textBox5.Text);
                cmd.Parameters.AddWithValue("@nid", textBox6.Text);
                cmd.Parameters.AddWithValue("@gender", s);
                cmd.Parameters.AddWithValue("@maritalstat", comboBox2.SelectedItem);
                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.ToString());
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@image", SavePhoto());

                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Inserted Successfully ! ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindGridView();
                     Reset();
                }
                else
                {
                    MessageBox.Show("Data not Inserted ! ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            else
            {
                MessageBox.Show("Please fill the form", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            textBox1.Focus();
            textBox5.Focus();
            textBox3.Focus();
            textBox4.Focus();
          
            textBox6.Focus();
            con.Close();

        }


        public void Reset()
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dateTimePicker1.Text = string.Empty;
            pictureBox1.Image = null;
        }

        byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (radioButton1.Checked == true)
            {
                s = "Male";
            }
            else
            {
                s = "Female";
            }

            string query = "update  Profileuser set username=@username,NAME=@name,MOBILE=@mobile,BLOODGRP=@bg,EMAIL=@email,NID=@nid,GENDER=@gender,MARITALSTAT=@maritalstat,DOB=@dob,IMAGE=@image where username=@username"; 
            SqlCommand cmd = new SqlCommand(query, con);
           // cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox3.Text);
            cmd.Parameters.AddWithValue("@mobile", textBox4.Text);
            cmd.Parameters.AddWithValue("@bg", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@email", textBox5.Text);
            cmd.Parameters.AddWithValue("@nid", textBox6.Text);
            cmd.Parameters.AddWithValue("@gender", s);
            cmd.Parameters.AddWithValue("@maritalstat", comboBox2.SelectedItem);
            cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.ToString());
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@image", SavePhoto());
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data updated Successfully ......... ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGridView();
                Reset();
            }
            else
            {
                MessageBox.Show("Data not updated !!! ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            pictureBox1.Image = Properties.Resources.no_image_avaiable;
            con.Close();
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            //ofd.Filter = "PNG FILE (*.PNG) | *.PNG";
            ofd.Filter = "ALL IMAGE FILE (*.*) | *.*";
            //ofd.ShowDialog();
            pictureBox1.Image = Properties.Resources.no_image_avaiable;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }

      /*  private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox1.SelectedItem = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            s = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            comboBox2.SelectedItem = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            dateTimePicker1.Value = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[8].Value.ToString());
            pictureBox1.Image = GetPhoto((byte[])dataGridView1.SelectedRows[0].Cells[9].Value);
        } */

        Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "delete from Profileuser where username=@username";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", textBox1.Text);


            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data deleted Successfully.. ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGridView();
                Reset();
            }
            else
            {
                MessageBox.Show("Data not dnserted !!!! ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
            pictureBox1.Image = Properties.Resources.no_image_avaiable;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Reset();
            pictureBox1.Image = Properties.Resources.no_image_avaiable;
        }

   

        

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Hide();
            admin.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            if (dataGridView1.SelectedRows[0].Cells[2].Value.Equals("A+"))
            { comboBox1.SelectedIndex = 0; }
            else if (dataGridView1.SelectedRows[0].Cells[2].Value.Equals("A-"))
            { comboBox1.SelectedIndex = 1; }
            else if (dataGridView1.SelectedRows[0].Cells[2].Value.Equals("B+"))
            { comboBox1.SelectedIndex = 2; }
            else if (dataGridView1.SelectedRows[0].Cells[2].Value.Equals("B-"))
            { comboBox1.SelectedIndex = 3; }
            else if (dataGridView1.SelectedRows[0].Cells[2].Value.Equals("AB+"))
            { comboBox1.SelectedIndex = 4; }
            else if (dataGridView1.SelectedRows[0].Cells[2].Value.Equals("AB-"))
            { comboBox1.SelectedIndex = 5; }
            else if (dataGridView1.SelectedRows[0].Cells[2].Value.Equals("O+"))
            { comboBox1.SelectedIndex = 6; }
            else if (dataGridView1.SelectedRows[0].Cells[2].Value.Equals("O-"))
            { comboBox1.SelectedIndex = 7; }

            
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();


            if (dataGridView1.SelectedRows[0].Cells[5].Value.Equals("Female"))
            { radioButton2.Checked = true; }
            else
            { radioButton2.Checked = false; }

            if (dataGridView1.SelectedRows[0].Cells[5].Value.Equals("Male"))
            { radioButton1.Checked = true; }
            else
            { radioButton1.Checked = false; }

            if (dataGridView1.SelectedRows[0].Cells[6].Value.Equals("Single"))
            { comboBox2.SelectedIndex = 0; }
            if (dataGridView1.SelectedRows[0].Cells[6].Value.Equals("Married"))
            { comboBox2.SelectedIndex = 1; }
            if (dataGridView1.SelectedRows[0].Cells[6].Value.Equals("Widowed"))
            { comboBox2.SelectedIndex = 2; }
                if (dataGridView1.SelectedRows[0].Cells[6].Value.Equals("Divorced"))
                { comboBox2.SelectedIndex = 3; }
            dateTimePicker1.Value = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[7].Value.ToString());
            pictureBox1.Image = GetPhoto((byte[])dataGridView1.SelectedRows[0].Cells[9].Value);
        }

       
    }
}
