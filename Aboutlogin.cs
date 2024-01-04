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
    public partial class Aboutlogin : Form
    {
        public Aboutlogin()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Home1 home1 = new Home1();
            this.Hide();
            home1.Show();
        }
    }

   
    }

