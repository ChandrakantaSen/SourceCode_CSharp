using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace WindowsFormsApplication9
{
    public partial class Change_password : Form
    {
        public Change_password()
        {
            InitializeComponent();
        }

        private void Change_password_Load(object sender, EventArgs e)
        {
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
              if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please select all the values");
            }

            else if (string.IsNullOrEmpty(textBox2.Text))
            {

                MessageBox.Show("Please select all the values");
            }
            else if (string.IsNullOrEmpty(textBox4.Text))
            {

                MessageBox.Show("Please select all the values");
            }

              else
              {

                    SqlConnection con = new SqlConnection(@"Data Source=HEXCODE-5-PC\RANCELAB2008;Persist Security Info=True;User ID=sa;Password=Password@123;");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE LOGIN SET PASSWORD ='" + textBox2.Text + "', [RE TYPE PASSWORD] ='" + textBox4.Text + "'  WHERE (USERNAME ='" + textBox1.Text + "' )",con);
                    cmd.ExecuteNonQuery();
                    con.Close();



                    MessageBox.Show("Your password has been changed successfully" + Environment.NewLine + Environment.NewLine + "*Make sure you have used your authenticated username*" + Environment.NewLine + "*Otherwise your password won't change*");

                    this.Close();
            }

           }

      
    }
}
