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
    public partial class Package : Form
    {
        public Package()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            HajjUmrah hp = new HajjUmrah();
            hp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tabligh tablig_Dispatcher = new Tabligh();
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
            Home f2 = new Home();
            this.Close();
            f2.Show();
        }
    }
}
