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
    public partial class Tabligh : Form
    {
        public Tabligh()
        {
            InitializeComponent();
        }

        private void Tablig_Dispatcher_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Package Selected");
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            Package p=new Package();
            this.Close();
            p.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Package package = new Package();
            package.Show(); 
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }
    }
}
