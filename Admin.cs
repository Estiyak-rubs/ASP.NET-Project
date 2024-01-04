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

namespace Way_to_Deen
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            All_Users au = new All_Users();
            this.Hide();
            au.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home f2 = new Home();
            this.Hide();
            f2.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Admindonation f3 = new Admindonation();
            this.Hide();
            f3.Show();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            AdminPayment payment_CRUD = new AdminPayment();
            this.Hide();
            payment_CRUD.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AdminFeedback adminFeedback = new AdminFeedback();
            adminFeedback.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Adminusers adminusers = new Adminusers();   
            adminusers.Show();
            this.Hide();
        }
    }
}
