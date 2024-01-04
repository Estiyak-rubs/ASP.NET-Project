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
    public partial class DEENogin : Form
    {
        public DEENogin()
        {
            InitializeComponent();
        }

        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.hadithbd.com/bukhari-tawhid.php");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://sunnah.com/muslim");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.sifatusafwa.com/en/thematic-and-misc-collections/mishkat-al-masabih-by-imam-at-tibrizi-741h.html");
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.sifatusafwa.com/en/thematic-and-misc-collections/mishkat-al-masabih-by-imam-at-tibrizi-741h.html");
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.alislam.org/quran/Holy-Quran-Bangla.pdf");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
         Process.Start(" https://www.islamicfinder.org/world/bangladesh/1185241/dhaka-prayer-times/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.mymasjid.ca/beginners-guide-learn-pray-salah/chapter-4/");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Home1 f2 = new Home1();
            this.Close();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.hadithbd.com/bukhari-tawhid.php");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://sunnah.com/muslim");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.tauhiderdak.com/2020/11/mishkat-pdf-download.html");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.islamicboisomahar.in/tirmizi-sharif-bangla/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.alislam.org/quran/Holy-Quran-Bangla.pdf");
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
            Process.Start("https://www.alislam.org/library/books/Tabligh-Guide.pdf");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.islamic-relief.ie/about-us/what-we-do/zakat/zakat-calculator");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.quraanshareef.org/");
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
            Process.Start("https://www.metmuseum.org/learn/educators/curriculum-resources/art-of-the-islamic-world/unit-one/the-five-pillars-of-islam");
        }
    }
}
