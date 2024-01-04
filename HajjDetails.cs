using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Way_to_Deen
{
    public partial class HajjDetails : Form
    {
        public HajjDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://zamzamtravelsbd.com/hajj-packages-from-bangladesh/regular-hajj-package-c/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://zamzamtravelsbd.com/hajj-packages-from-bangladesh/hajj-travel-agency-bangladesh/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://zamzamtravelsbd.com/hajj-packages-from-bangladesh/regular-hajj-packages-from-bangladesh-2023/");
        }
    }
}
