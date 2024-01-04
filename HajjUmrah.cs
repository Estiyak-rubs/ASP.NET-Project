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
    public partial class HajjUmrah : Form
    {
        public HajjUmrah()
        {
            InitializeComponent();
        }

        private void Hajj_Package_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login p = new login();
            this.Hide();
            p.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        

        

        private void button2_Click(object sender, EventArgs e)
        {
            Umrah umrah = new Umrah();
            umrah.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HajjDetails details = new HajjDetails();
            details.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Package p = new Package();
            this.Hide();
            p.Show();
        }
    }
}
