using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Web;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("www.gmail.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=HEXCODE-5-PC\RANCELAB2008;Persist Security Info=True;User ID=sa;Password=password@123;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Username='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Welcome " + textBox1.Text + Environment.NewLine + "");
                this.Hide();

                Form2 obj1 = new Form2();
                obj1.Show();
                
            }



            else
            {
                
                MessageBox.Show("Please check your USERNAME and PASSWORD");
                ErrorProvider erp = new ErrorProvider();
                erp.SetError(textBox1,"Check Username");
                erp.SetError(textBox2,"Check Password");
            }

            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString().Substring(DateTime.Today.ToString().Length - 11);
            label6.Text = DateTime.Now.ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            MessageBox.Show("Have a good day");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

          
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipText = "SMS has been minimised";
                notifyIcon1.ShowBalloonTip(1000);

            }

            else if (this.WindowState == FormWindowState.Normal)
            {
                notifyIcon1.BalloonTipText = "SMS has come back to normal mode";
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            
        }

       

       



      
        }
    }

