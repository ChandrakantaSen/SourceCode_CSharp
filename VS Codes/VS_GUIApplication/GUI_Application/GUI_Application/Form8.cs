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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (r1.Checked)
            {
                MessageBox.Show("General Caste");
            }
            else if(r2.Checked)
            {
                MessageBox.Show("SC Caste");
            }
            else if (r3.Checked)
            {
                MessageBox.Show("ST Caste");
            }
            else
            {
                MessageBox.Show("OBC Caste");
            }
        }
    }
}
