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

namespace Way_to_Deen
{
    public partial class Pay1 : Form
    {
        public Pay1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UJGC92B\SQLEXPRESS;Initial Catalog=WaytoDeen;Integrated Security=True");
        string g;
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                panel3.Visible = true;
            }
            else { panel3.Visible = false; }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        /*
        private void button2_Click(object sender, EventArgs e)
        {
            nogod nogod = new nogod();
            nogod.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bkash bkash = new bkash();
            bkash.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DBBL dBBL = new DBBL();
            dBBL.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            card card = new card();
            card.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            card ca
                = new card();
            ca.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rocket rocket = new Rocket();
            rocket.Show();
            this.Hide();
        } */

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                panel1.Visible = true;
            }
            else { panel1.Visible = false; }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                panel2.Visible = true;
            }
            else { panel2.Visible = false; }
        }

        private void button7_Click(object sender, EventArgs e)
        {
             if (radioButton1.Checked == true)
             {
                 g = "MOBILEBANKING";
                
             }
            else if (radioButton2.Checked == true)
             {
                 g = "CARDORDEBID";
             }
            else if (radioButton4.Checked == true)
             {
                 g = "Bank";
             }
            
            if (textBox14.Text != "" && textBox10.Text != "" && textBox11.Text != "" &&/* comboBox1.SelectedIndex != "" && comboBox2.SelectedIndex != "" && dateTimePicker1.Value != "" && dateTimePicker2.Value != ""*/ textBox9.Text != "" && textBox3.Text != "")
            {

                string query = "insert into Payment(ID,NAME,EMAIL,TYPE,PACKAGE,FLIGHTDATE,RETURNDATE,NOM,AMOUNT,METHOD) values ('" + textBox14.Text + "', '" + textBox10.Text + "','" + textBox11.Text + "','" + comboBox1.SelectedItem + "', '" + comboBox2.SelectedItem + "','" + dateTimePicker1.Value.ToString() + "','" + dateTimePicker2.Value.ToString() + "' ,'" + textBox9.Text + "', '" + textBox3.Text + "','"+g+"')";
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
               /* cmd.ExecuteNonQuery();
                MessageBox.Show("RECORD INSERTED");
                con.Close();*/

                int a = cmd.ExecuteNonQuery();
                 if (a > 0)
                 {
                     MessageBox.Show("Data Inserted Successfully ! ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);


                 }
                 else
                 {
                     MessageBox.Show("Data not Inserted ! ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }



             }
             else
             {
                 MessageBox.Show("Please fill the form", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }

            }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           Home1 home1 = new Home1();
           home1.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    if (textBox9.Text != "")
                    {
                        int num1 = int.Parse(textBox9.Text);
                        int num2 = int.Parse(t3.Text);
                        t1.Visible = true;
                        int result = num1 * num2;
                        textBox3.Text = "" + result;
                        //t1.Visible = false;
                        t2.Visible = false;
                        t3.Visible = false;
                        t4.Visible = false;
                        t5.Visible = false;
                        t6.Visible = false;
                        t7.Visible = false;


                    }

                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    if (textBox9.Text != "")
                    {
                        int num1 = int.Parse(textBox9.Text);
                        int num2 = int.Parse(t2.Text);
                        t2.Visible = true;
                        int result = num1 * num2;
                        textBox3.Text = "" + result;
                        t1.Visible = false;
                       // t2.Visible = false;
                        t3.Visible = false;
                        t4.Visible = false;
                        t5.Visible = false;
                        t6.Visible = false;
                        t7.Visible = false;


                    }

                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    if (textBox9.Text != "")
                    {
                        int num1 = int.Parse(textBox9.Text);
                        int num2 = int.Parse(t6.Text);
                        t3.Visible = true;
                        int result = num1 * num2;
                        textBox3.Text = "" + result;
                        t1.Visible = false;
                        t2.Visible = false;
                       // t3.Visible = false;
                        t4.Visible = false;
                        t5.Visible = false;
                        t6.Visible = false;
                        t7.Visible = false;


                    }

                }

                //....................

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                if (comboBox2.SelectedIndex == 3)
                {
                    if (textBox9.Text != "")
                    {
                        int num1 = int.Parse(textBox9.Text);
                        int num2 = int.Parse(t7.Text);
                        t7.Visible = true;
                        int result = num1 * num2;
                        textBox3.Text = "" + result;
                        t1.Visible = false;
                        t2.Visible = false;
                        t3.Visible = false;
                        t4.Visible = false;
                        t5.Visible = false;
                        t6.Visible = false;
                        //t7.Visible = false;


                    }

                }
            }
            else
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    if (textBox9.Text != "")
                    {
                        int num1 = int.Parse(textBox9.Text);
                        int num2 = int.Parse(t4.Text);
                        t4.Visible = true;
                        int result = num1 * num2;
                        textBox3.Text = "" + result;
                        t1.Visible = false;
                        t2.Visible = false;
                        t3.Visible = false;
                        //t4.Visible = false;
                        t5.Visible = false;
                        t6.Visible = false;
                        t7.Visible = false;

                    }

                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    if (textBox9.Text != "")
                    {
                        int num1 = int.Parse(textBox9.Text);
                        int num2 = int.Parse(t5.Text);
                        t5.Visible = true;
                        int result = num1 * num2;
                        textBox3.Text = "" + result;
                        t1.Visible = false;
                        t2.Visible = false;
                        t3.Visible = false;
                        t4.Visible = false;
                        //t5.Visible = false;
                        t6.Visible = false;
                        t7.Visible = false;


                    }

                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    if (textBox9.Text != "")
                    {
                        int num1 = int.Parse(textBox9.Text);
                        int num2 = int.Parse(t6.Text);
                        t6.Visible = true;
                        int result = num1 * num2;
                        textBox3.Text = "" + result;
                        t1.Visible = false;
                        t2.Visible = false;
                        t3.Visible = false;
                        t4.Visible = false;
                        t5.Visible = false;
                        //t6.Visible = false;
                        t7.Visible = false;

                    }

                }

            }
            }
        }
    }

      
    











                /*  DialogResult dr = MessageBox.Show("Confirm Your Payment","Payment",MessageBoxButtons.OKCancel);
                  if (dr == DialogResult.OK)

                  { 
                      con.Open();
                      string Method = "";
                      if (radioButton1.Checked == true)
                      {
                          Method = radioButton1.Text;
                      }
                      else
                      {
                          Method = radioButton2.Text;
                      }


                      //  SqlCommand command = new SqlCommand("INSERT INTO Payment VALUES ('" +int.Parse(textBox14.Text) + "','" + textBox10.Text + "','" + textBox11.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "',GETDATE(),GETDATE(),'" + int.Parse(textBox3.Text) + "','" + int.Parse(textBox3.Text) + "','" + Method + "')", con);
                      SqlCommand command = new SqlCommand("INSERT INTO Payment VALUES ('" + int.Parse(textBox14.Text) + "','" + textBox10.Text + "','" + textBox11.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + DateTime.Parse(dateTimePicker1.Text) + "','" + DateTime.Parse(dateTimePicker1.Text) + "','" + double.Parse(textBox3.Text) + "','" + Method + "')", con);

                      command.ExecuteNonQuery();

                      /*
                      string query = "INSERT INTO Payment VALUES (@TextBox10, @TextBox11, @ComboBox1, @ComboBox2, GETDATE(), GETDATE(), @TextBox3In, @TextBox3Double, @Method)";

                      using (SqlCommand command = new SqlCommand(query, con))
                      {
                          command.Parameters.AddWithValue("@TextBox10", textBox10.Text);
                          command.Parameters.AddWithValue("@TextBox11", textBox11.Text);
                          command.Parameters.AddWithValue("@ComboBox1", comboBox1.Text);
                          command.Parameters.AddWithValue("@ComboBox2", comboBox2.Text);
                          command.Parameters.AddWithValue("@TextBox3", int.Parse(textBox3.Text));
                          command.Parameters.AddWithValue("@TextBox3Double", double.Parse(textBox3.Text));
                          // Assuming 'Method' is defined elsewhere in your code
                          command.Parameters.AddWithValue("@Method", Method);

                          int rowsAffected = command.ExecuteNonQuery();
                          // Check rowsAffected if necessary
                      }
                      */
                /* con.Close();
                 MessageBox.Show("Payment Succesful"); */
            

        
    


     /*   private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
    */

   /* private void textBox14_TextChanged(object sender, EventArgs e)
    {

    }*/

