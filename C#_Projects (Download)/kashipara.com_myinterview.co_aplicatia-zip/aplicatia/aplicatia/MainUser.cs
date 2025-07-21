using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicatie
{   
    public partial class MainUser : Form
    {
        public MainUser()
        {
            InitializeComponent();
        }

        private void adaugareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colaboratori cs = new Colaboratori();
            cs.Show();
        }

        private void adaugareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Intrari i = new Intrari();
            i.Show();
        }

        private void adaugareToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Comenzi C = new Comenzi();
            C.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToLongTimeString();
        }
    }
}
