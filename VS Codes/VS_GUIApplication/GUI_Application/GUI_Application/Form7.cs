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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (r1.Checked == true)
            {
                MessageBox.Show("hello sir..!");
            }
            else if (r2.Checked == true)
            {
                MessageBox.Show("hello madam...!");
            }
            else
            {
                MessageBox.Show("hello how are u ?");
            }
        }
    }
}
