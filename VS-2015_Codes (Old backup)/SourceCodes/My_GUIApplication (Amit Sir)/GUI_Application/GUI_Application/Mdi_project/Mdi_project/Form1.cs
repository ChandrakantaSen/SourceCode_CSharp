using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mdi_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void depositFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deposit d = new deposit();
            d.MdiParent = this;
            d.Show();
        }

        private void withdrawlFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            withdrawl w = new withdrawl();
            w.MdiParent = this;
            w.Show();
        }

        private void confirmExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult dr= MessageBox.Show("Do u want exit software...", "Exit Window", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void openDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deposit d = new deposit();
            d.MdiParent = this;
            d.Show();
        }
    }
}
