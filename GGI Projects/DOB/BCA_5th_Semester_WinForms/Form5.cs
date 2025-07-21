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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            this.Hide(); // this will hide current form
            frm6.Show(this);
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
