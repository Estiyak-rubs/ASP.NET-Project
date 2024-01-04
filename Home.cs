using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Way_to_Deen
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           login f1 = new login();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register sg = new Register();
            sg.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Assalamu Allikum \nIf you have an query \nMail: Rubaiat.estiyak@gmail.com", "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Donation donation = new Donation();
            this.Hide();
            donation.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            About about = new About();
               
            this.Hide();
            about.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DEEN dEEN = new DEEN();
            this.Hide();
            dEEN.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Package info = new Package();
            this.Hide();
            info.Show();
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("T");
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AdminLogin AdminLogin = new AdminLogin();
            AdminLogin
                .Show();
            this.Hide();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Feedbackvisitor feedback = new Feedbackvisitor();
               feedback.Show();
            this.Hide();
        }
    }
}
