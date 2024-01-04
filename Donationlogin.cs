using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Way_to_Deen
{
    public partial class Donationlogin : Form
    {
        public Donationlogin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UJGC92B\SQLEXPRESS;Initial Catalog=WaytoDeen;Integrated Security=True");
        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from Donation", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
       
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Home f2 = new Home();
            this.Close();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Donation2 d2 = new Donation2();
            d2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BindData();
           // label2.Text =$"Total Donation: { dataGridView1.RowCount}";
            label4.Text = "0";
           /* for (int i = 0; i<dataGridView1.Rows.Count; i++)
            {
                label4.Text = Convert.ToString(double.Parse(label4.Text) + double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
            }
            
            //label4.Text =$"Total Ammount: {dataGridView1.add}; */
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Home f2 = new Home();
            this.Hide();
            f2.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Home1 f2 = new Home1();
            this.Hide();
            f2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://www.lovevolunteers.org/destinations/volunteer-west-bank/community-development-nablus");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.lovevolunteers.org/destinations/volunteer-west-bank/education-support-nablus");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.lovevolunteers.org/destinations/volunteer-west-bank/medical-internship-nablus");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            AutoScroll = true;
        }
    }
}
