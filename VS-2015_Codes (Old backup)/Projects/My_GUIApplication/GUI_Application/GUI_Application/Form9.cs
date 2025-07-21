using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_Application
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            int result;

            num1 = int.Parse(t1.Text);
            num2 = int.Parse(t2.Text);

            if (r1.Checked)
            {
                result = (num1 + num2);
                t3.Text = result.ToString();
            }
            else if (r2.Checked)
            {
                result = (num1 - num2);
                t3.Text = result.ToString();
            }
            else if (r3.Checked)
            {
                result = (num1 * num2);
                t3.Text = result.ToString();
            }
            else if (r4.Checked)
            {
                result = (num1 / num2);
                t3.Text = result.ToString();
            }
            else
            {
                t1.Text = "";
                t2.Text = "";
                t3.Text = "";
            }

            //t3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t1.Text = "";
            t2.Text = "";
            t3.Text = "";
        }
    }
}
