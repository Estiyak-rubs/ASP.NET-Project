using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Way_to_Deen
{
    public partial class DEEN : Form
    {
        public DEEN()
        {
            InitializeComponent();
        }

        

      

        
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Home f2 = new Home();
            this.Close();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button16.Visible = true;
            webBrowser1.Navigate("https://www.hadithbd.com/bukhari-tawhid.php");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button16.Visible = true;
            webBrowser1.Visible = true;
                webBrowser1.Navigate("https://sunnah.com/muslim");
            
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button16.Visible = true;
            webBrowser1.Visible = true;
            webBrowser1.Navigate("https://www.tauhiderdak.com/2020/11/mishkat-pdf-download.html;");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button16.Visible = true;
            webBrowser1.Visible = true;
            webBrowser1.Navigate("https://www.islamicboisomahar.in/tirmizi-sharif-bangla;");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button16.Visible = true;
            webBrowser1.Visible = true;
            webBrowser1.Navigate("https://www.alislam.org/quran/Holy-Quran-Bangla.pdf;");
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            button7.Visible = true;
            button9.Visible = false;

            panel1.Visible = true;
            panel2.Visible = false;
            button15.Visible = false;
            panel3.Visible = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Visible=false;
           
            button7.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            button9.Visible = true;
            button7.Visible = false;
            button15.Visible = false;
            panel3.Visible = false;

        }

        

        private void button9_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            button9.Visible = false;
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button16.Visible = true;
            webBrowser1.Visible = true;
            webBrowser1.Navigate("https://www.alislam.org/library/books/Tabligh-Guide.pdf;");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button16.Visible = true;
            webBrowser1.Visible = true;
            webBrowser1.Navigate("https://help.unicef.org/zakat-calculator");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button16.Visible = true;
            webBrowser1.Visible = true;
            webBrowser1.Navigate("https://www.quraanshareef.org;");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            button15.Visible = true;
            panel1.Visible = false;
            button7.Visible = false;
            panel2.Visible = false;
            button9.Visible = false;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Visible = false;
            panel3.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button16.Visible = true;
            webBrowser1.Visible = true;
            webBrowser1.Navigate("https://www.metmuseum.org/learn/educators/curriculum-resources/art-of-the-islamic-world/unit-one/the-five-pillars-of-islam;");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Visible = false;
            webBrowser1.Visible = false;
        }
    }
}
