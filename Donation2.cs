using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Way_to_Deen
{
    public partial class Donation2 : Form
    {
        public Donation2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UJGC92B\SQLEXPRESS;Initial Catalog=WaytoDeen;Integrated Security=True");



        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.ResetText();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text= button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) { textBox2.Text = "Anonymous"; }
            con.Open();
            SqlCommand command = new SqlCommand("INSERT INTO DONATION VALUES ('" + textBox2.Text + "','" + textBox3.Text + "','" + int.Parse(textBox1.Text) + "', '" + comboBox1.Text + "')", con);

            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted.");
            con.Close();
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
