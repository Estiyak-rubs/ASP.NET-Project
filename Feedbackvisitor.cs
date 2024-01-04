using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Way_to_Deen
{
    public partial class Feedbackvisitor : Form
    {
        public Feedbackvisitor()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UJGC92B\SQLEXPRESS;Initial Catalog=WaytoDeen;Integrated Security=True");

        private void textBox1_Click(object sender, EventArgs e)
        {
            ResetText();
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            ResetText();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        string g;
        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from Feedback", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
           DialogResult dt = MessageBox.Show("To give us your Feedback, you need to Login", "Feedback", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if( dt== DialogResult.OK)
            {
                login login = new login();
                login.Show();
                this.Hide();
            }
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            login login1 = new login();
            login1.Show();
            this.Hide();
        }
    }
    
}
