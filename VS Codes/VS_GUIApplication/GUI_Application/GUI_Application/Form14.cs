﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_Application
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ct, nm;
            nm = t1.Text;
            ct = c1.Text;

            MessageBox.Show("Hi..." + nm + " your city name is " + ct);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t1.Text = "";
            c1.Text = "";
        }
    }
}
