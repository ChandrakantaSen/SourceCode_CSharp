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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int min, max;
            min = int.Parse(t1.Text);
            max = int.Parse(t2.Text);

            for (int i = min; i <= max; i++)
            {
                if (i % 2 == 0)
                {
                    l1.Items.Add(i);
                }
                else
                {
                    l2.Items.Add(i);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t1.Text = "";
            t2.Text = "";
            l1.Items.Clear();
            l2.Items.Clear();
            t1.Focus();
        }
    }
}
