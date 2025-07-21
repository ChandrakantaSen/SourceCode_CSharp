using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DOB_WinForms.Properties;
 
namespace DOB_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            this.Hide(); // this will hide current form
            frm9.Show(this);
        }
    }
}
