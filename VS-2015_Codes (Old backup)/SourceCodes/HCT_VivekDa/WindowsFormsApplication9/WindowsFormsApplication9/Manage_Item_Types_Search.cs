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
    public partial class Manage_Item_Types_Search : Form
    {
        public Manage_Item_Types_Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                 
                 SqlConnection con = new SqlConnection(@"Data Source=HEXCODE-5-PC\RANCELAB2008;Persist Security Info=True;User ID=sa;Password=password@123;");
            if (textBox1.Text != "")
            try
            {
                
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter("select * from ITEMS where ID ='" + textBox1.Text + "'", con);
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                
            }

            catch (Exception)
            {
                MessageBox.Show("Please enter correct ID");
                
            }
            finally
            {
                con.Close();
                con = null;
               
            }

            else
            {
                MessageBox.Show("Please enter correct ID");
            }

            }

        private void button2_Click(object sender, EventArgs e)
        {
 
                 SqlConnection con = new SqlConnection(@"Data Source=HEXCODE-5-PC\RANCELAB2008;Persist Security Info=True;User ID=sa;Password=password@123;");
            if (textBox2.Text != "")
            try
            {
                
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter("select * from ITEMS where Name  ='" + textBox2.Text + "'", con);
                    sda.Fill(dt);
                    dataGridView2.DataSource = dt;
                }
                
            }

            catch (Exception)
            {
                MessageBox.Show("Please enter correct Name");
                
            }
            finally
            {
                con.Close();
                con = null;
               
            }

            else
            {
                MessageBox.Show("Please enter correct Name");
            }

            }

        private void button3_Click(object sender, EventArgs e)
        {
            
               SqlConnection con = new SqlConnection(@"Data Source=HEXCODE-5-PC\RANCELAB2008;Persist Security Info=True;User ID=sa;Password=password@123;");
            if (textBox3.Text != "")
            try
            {
                
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter("select * from ITEMS where Vendor  ='" + textBox3.Text + "'", con);
                    sda.Fill(dt);
                    dataGridView3.DataSource = dt;
                }
                
            }

            catch (Exception)
            {
                MessageBox.Show("Please enter correct Vendor");
                
            }
            finally
            {
                con.Close();
                con = null;
               
            }

            else
            {
                MessageBox.Show("Please enter correct Vendor");
            }

            }

        }

       

        }
    

