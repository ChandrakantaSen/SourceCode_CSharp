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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ct, nm;
            nm = t1.Text;
            ct = l1.SelectedItem.ToString();

            MessageBox.Show("Hi..."+nm+" your city name is "+ct);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
