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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void r1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (r1.Checked)
            {
                this.BackColor = Color.Red;
            }
            else if (r2.Checked)
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = Color.Blue;
            }
        }
    }
}
