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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            this.Hide(); // this will hide current form
            frm7.Show(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
