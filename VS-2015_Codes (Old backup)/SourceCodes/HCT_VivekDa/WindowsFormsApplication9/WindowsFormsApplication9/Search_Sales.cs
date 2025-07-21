using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication9
{
    public partial class Search_Sales : Form
    {
        public Search_Sales()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HEXCODE-5-PC\RANCELAB2008;Persist Security Info=True;User ID=sa;Password=password@123;");
            
            try
            {
                
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter("select * from Salesitem where [Date and Time] ='" + dateTimePicker1.Value.Date + "'", con);
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;

                  
                }
                
            }

            catch (Exception)
            {
                MessageBox.Show("No Transaction found for this criteria");
                
            }
            finally
            {
                con.Close();
                con = null;
               
            }

           

            }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=HEXCODE-5-PC\RANCELAB2008;Persist Security Info=True;User ID=sa;Password=password@123;");
            con.Open();
            DataTable dta = new DataTable();
            SqlDataAdapter s = new SqlDataAdapter("select Name,[Purchase Price] from Items ", con);
            s.Fill(dta);
            dataGridView2.DataSource = dta;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Calculator obj1 = new Calculator();
            obj1.Show();
        }
        }

        
            }

            
        

       
    
