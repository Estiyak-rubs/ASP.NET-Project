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
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            signup sg = new signup();
            sg.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Assalamu Allikum \nIf you have query \nMail: Rubaiat.estiyak@gmail.com", "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
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
            Info info = new Info();
            this.Hide();
            info.Show();
           
        }
    }
}
