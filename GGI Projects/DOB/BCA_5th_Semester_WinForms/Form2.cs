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
    public partial class Form2 : Form
    {
        int d, m, y, day, month, year, i, calc = 0, calc1 = 0, ch = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            d = int.Parse(textBox1.Text);
            m = int.Parse(textBox2.Text);
            y = int.Parse(textBox3.Text);

            if ((d > 31) || (m > 12) || (y < 1900 || y >= 2100))
            {
                MessageBox.Show("INVALID INPUT...Please enter a valid date between 1900 and 2100");
            }
            else
            {
                year = y - 1900;
                year = year / 4;
                year = year + y - 1900;
            }

            switch (m)
            {
                case 1:
                case 10:
                    month = 1;
                    break;

                case 2:
                case 3:
                case 11:
                    month = 4;
                    break;

                case 7:
                case 4:
                    month = 0;
                    break;

                case 5:
                    month = 2;
                    break;

                case 6:
                    month = 5;
                    break;

                case 8:
                    month = 3;
                    break;

                case 9:
                case 12:
                    month = 6;
                    break;
            }

            year = year + month;
            year = year + d;

            /* Need to make sure extra day is not needed in leap year for dates before March */
            if ((y > 1900) && (y % 4 == 0) && (m < 2))
                year--;
            day = year % 7;

            switch (day)
            {
                case 0:
                    textBox4.Text = "Your birthday is SATURDAY...!"; break;
                case 1:
                    textBox4.Text = "Your birthday is SUNDAY...!"; break;
                case 2:
                    textBox4.Text = "Your birthday is MONDAY...!"; break;
                case 3:
                    textBox4.Text = "Your birthday is TUESDAY...!"; break;
                case 4:
                    textBox4.Text = "Your birthday is WEDNESDAY...!"; break;
                case 5:
                    textBox4.Text = "Your birthday is THURSDAY...!"; break;
                case 6:
                    textBox4.Text = "Your birthday is FRIDAY...!"; break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
