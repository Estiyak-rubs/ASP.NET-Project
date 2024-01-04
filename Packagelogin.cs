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
    public partial class Packagelogin : Form
    {
        public Packagelogin()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            HajjUmrahLogin hp = new HajjUmrahLogin();
            hp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tabliglogin tablig_Dispatcher = new Tabliglogin();
            tablig_Dispatcher.Show();
            this.Hide();
        }

     

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Home f2 = new Home();
            this.Close();
            f2.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Home1 f2 = new Home1();
            this.Close();
            f2.Show();
        }
    }
}
