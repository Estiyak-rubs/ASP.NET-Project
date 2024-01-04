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

namespace Way_to_Deen
{
    public partial class ProfileINFO : Form
    {
      
        public ProfileINFO()
        {
            InitializeComponent();
            
        }

      

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UJGC92B\SQLEXPRESS;Initial Catalog=WaytoDeen;Integrated Security=True");
        string s;
        

        private void button4_Click(object sender, EventArgs e)
        {
            Home1 h1 = new Home1();
            this.Close();
            h1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Home1 h1 = new Home1();
            this.Close();
            h1.Show();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Select Image";
            ofd.Filter = "Image File (All files) *.* | *.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }

        byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Select Image";
            ofd.Filter = "Image File (All files) *.* | *.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Home1 home1 = new Home1();  
            this.Hide();    
            home1 .Show();
        }

        private void ProfileINFO_Load(object sender, EventArgs e)
        {
            textBox1.Text = login.username;
        }

        private void button2_Click(object sender, EventArgs e)
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


            if (textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1 && dateTimePicker1.Value != DateTime.MinValue && textBox6.Text != "" && textBox1.Text != "" && pictureBox1.Image != null)

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
    }
}
