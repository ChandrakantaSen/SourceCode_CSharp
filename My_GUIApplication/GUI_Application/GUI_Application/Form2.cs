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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, sum = 0;

            n1 = int.Parse(t1.Text);
            n2 = int.Parse(t2.Text);

            sum = (n1 + n2);

            t3.Text = sum.ToString();
        }
    }
}
