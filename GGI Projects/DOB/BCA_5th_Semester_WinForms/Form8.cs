using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DOB_WinForms
{
    public partial class Form8 : Form
    {
        public static string chstr = "";
        public static int ch = 0;

        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s, i, n, r, p, q, j=0, d=0;
            n = int.Parse(textBox1.Text);

            for(i=0;i<=9;i++)
            {
                s = n - i;
                p = s%10;

                if(p==5)
                {
                   j = i;
                   d = s;
                }
            }
            r = (int)(d / 10);
            q = r - 2;

            textBox2.Text = q.ToString();
            textBox3.Text = j.ToString();

            chstr = Form9.str;

            if (chstr == "Date of Birth")
            { 
                ch = 1;    
            }
            else if (chstr == "Month of Birth")
            {
                ch = 2;
            }
            else
            {
                ch = 3;
            }

            if (ch == 1)
            {
                if (q == 1)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else if (q == 2)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else if (q == 3)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else if (q == 4)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else if (q == 5)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else if (q == 6)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else if (q == 7)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else if (q == 8)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else if (q == 9)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else if (q == 10)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else if (q == 11)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else if (q == 12)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else if (q == 13)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else if (q == 14)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else if (q == 15)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else if (q == 16)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else if (q == 17)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else if (q == 18)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else if (q == 19)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else if (q == 20)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else if (q == 21)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else if (q == 22)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else if (q == 23)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else if (q == 24)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else if (q == 25)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else if (q == 26)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else if (q == 27)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else if (q == 28)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else if (q == 29)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else if (q == 30)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else if (q == 31)
                {
                    textBox4.Text = "Your date of birth is: " + q;
                }
                else
                {
                    textBox4.Text = "ERROR: Date can't be greater than 31...!";
                }
            }
            else
            { 
                if (q == 1)
                {
                    textBox4.Text = "Your month of birth is: January";
                }
                else if (q == 2)
                {
                    textBox4.Text = "Your month of birth is: February";
                }
                else if (q == 3)
                {
                    textBox4.Text = "Your month of birth is: March";
                }
                else if (q == 4)
                {
                    textBox4.Text = "Your month of birth is: April";
                }
                else if (q == 5)
                {
                    textBox4.Text = "Your month of birth is: May";
                }
                else if (q == 6)
                {
                    textBox4.Text = "Your month of birth is: June";
                }
                else if (q == 7)
                {
                    textBox4.Text = "Your month of birth is: July";
                }
                else if (q == 8)
                {
                    textBox4.Text = "Your month of birth is: August";
                }
                else if (q == 9)
                {
                    textBox4.Text = "Your month of birth is: September";
                }
                else if (q == 10)
                {
                    textBox4.Text = "Your month of birth is: October";
                }
                else if (q == 11)
                {
                    textBox4.Text = "Your month of birth is: November";
                }
                else if (q == 12)
                {
                    textBox4.Text = "Your month of birth is: December";
                }
                else
                {
                    textBox4.Text = "ERROR: Month can't be greater than December...!";
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            //label4.Text = Form9.str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show(this);
        }
    }
}
