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
    public partial class Form21 : Form
    {
        int cur, pre, plusClick = 0;
        string ch;
        
        public Form21()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {

            t1.Text = t1.Text+ b1.Text;
            cur = int.Parse(t1.Text);
            
        }

        private void b2_Click(object sender, EventArgs e)
        {
            t1.Text = t1.Text+ b2.Text;
            cur = int.Parse(t1.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bP_Click(object sender, EventArgs e)
        {
            if (plusClick == 0)
            {
                pre = cur;
                plusClick += 1;
            }
            else
            {
                pre = pre + cur;
            }
            t1.Clear();
            ch = "+";
        }

        private void bEq_Click(object sender, EventArgs e)
        {
            switch (ch)
            {
                case "+":
                    cur = cur + pre;
                    plusClick = 0;
                    t1.Text = cur.ToString();
                    break;

                case "-":
                    cur = pre - cur;
                    t1.Text = cur.ToString();
                    break;

                case "*":
                    cur = cur * pre;
                    t1.Text = cur.ToString();
                    break;

                case "/":
                    cur = pre / cur;
                    t1.Text = cur.ToString();
                    break;
            }
                

        }

        private void b3_Click(object sender, EventArgs e)
        {
            t1.Text = t1.Text + b3.Text;
            cur = int.Parse(t1.Text);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            t1.Text = t1.Text + b4.Text;
            cur = int.Parse(t1.Text);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            t1.Text = t1.Text + b5.Text;
            cur = int.Parse(t1.Text);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            t1.Text = t1.Text + b6.Text;
            cur = int.Parse(t1.Text);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            t1.Text = t1.Text + b7.Text;
            cur = int.Parse(t1.Text);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            t1.Text = t1.Text + b8.Text;
            cur = int.Parse(t1.Text);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            t1.Text = t1.Text + b9.Text;
            cur = int.Parse(t1.Text);
        }

        private void b0_Click(object sender, EventArgs e)
        {
            t1.Text = t1.Text + b0.Text;
            cur = int.Parse(t1.Text);
        }

        private void bM_Click(object sender, EventArgs e)
        {
            pre = cur;
            t1.Clear();
            ch = "-";
        }

        private void bMUL_Click(object sender, EventArgs e)
        {
            pre = cur;
            t1.Clear();
            ch = "*";
        }

        private void bD_Click(object sender, EventArgs e)
        {
            pre = cur;
            t1.Clear();
            ch = "/";
        }
    }
}
