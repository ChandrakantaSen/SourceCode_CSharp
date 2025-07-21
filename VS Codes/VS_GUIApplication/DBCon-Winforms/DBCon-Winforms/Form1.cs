using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBCon_Winforms
{
    public partial class Form1 : Form
    {
        global obj = new global();
       
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            UpdateButton.Enabled = false;
            //DeleteButton.Enabled = false;
        }

        // Database Connection
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                obj.getCon();
                if (obj.getCon() == 0)
                {
                    MessageBox.Show("Database is successfully connected...!");
                }
                else
                {
                    MessageBox.Show("Database connection error...!");
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("OOPs, something went wrong." + ex);
            }
            
        }

        // Table Creation
        private void button2_Click(object sender, EventArgs e)
        {
            obj.crtTbl();
            if (obj.crtTbl() == 0)
            {
                MessageBox.Show("Table is successfully created...!");
            }
            else
            {
                MessageBox.Show("Table connection error...!");
            }
        }

        // Insert Data
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                obj.getCon();

                obj.ID = int.Parse(textBox1.Text);
                obj.FNM = textBox2.Text;
                obj.LNM = textBox3.Text;
                obj.ADDRESS = textBox4.Text;
                obj.CITY = textBox5.Text;

                obj.insrtDataTable();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine("OOPs, something went wrong." + ex);    
            }
        }

        // Delete Data
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                obj.getCon();

                obj.ID = int.Parse(textBox1.Text);
                obj.FNM = textBox2.Text;
                obj.LNM = textBox3.Text;
                obj.ADDRESS = textBox4.Text;
                obj.CITY = textBox5.Text;

                obj.deltDataTable();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine("OOPs, something went wrong." + ex);
            }
        }

        // View Data
        private void button5_Click(object sender, EventArgs e)
        {
            obj.viewAllDataTable();
            dataGridView1.DataSource = obj.dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                obj.getCon();

                obj.ID = int.Parse(textBox1.Text);
                obj.FNM = textBox2.Text;
                obj.LNM = textBox3.Text;
                obj.ADDRESS = textBox4.Text;
                obj.CITY = textBox5.Text;

                //obj.updtDatatable();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine("OOPs, something went wrong." + ex);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        // Application Exit
        private void button3_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
