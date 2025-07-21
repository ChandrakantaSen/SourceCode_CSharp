using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BCA_5th_Semester_WinForms
{
    public partial class Form8 : Form
    {
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
