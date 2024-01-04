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
    public partial class Home1 : Form
    {
        public Home1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileINFO ff = new ProfileINFO();
            ff.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Packagelogin package = new Packagelogin();
            package.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Assalamu Allikum \nIf you have query \nMail: Rubaiat.estiyak@gmail.com", "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
       
                }

        private void button3_Click(object sender, EventArgs e)
        {
            DEENogin dEEN = new DEENogin();
            this.Hide();
            dEEN.Show();
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            Donationlogin donation = new Donationlogin();
            this.Hide();
            donation.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Aboutlogin aboutlogin = new Aboutlogin();

            this.Hide();
            aboutlogin.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipText = "Enjoy Your Day";
            notifyIcon1.BalloonTipTitle = "Log Out";
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.ShowBalloonTip(500);
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        int ig;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[ig];
            if (ig==imageList1.Images.Count - 1)
            {
                ig = 0;
            }
            ig++;
        }

        private void Home1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Feedback feedback = new Feedback(); 
            feedback.Show();
            this.Hide();
        }
    }

}
