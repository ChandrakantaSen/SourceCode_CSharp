using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicatie
{
    public partial class Flash : Form
    {
        //Flash f = new Flash();
        public Flash()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }








        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value >= 100)
            {
                timer1.Enabled = false;
                Autentificare a = new Autentificare();
                a.Show();
                a.Activate();
                this.Hide();

            }
            else
            {
                progressBar1.Value = progressBar1.Value + 10;
                // progressBar1.Value++;
                label1.Visible = true;
                label1.Text = "Loading..." + progressBar1.Value + "%";

            }
        }
            

        private void Flash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (progressBar1.Value >= 100)
            {
                timer1.Enabled = false;
                Autentificare a = new Autentificare();
                a.Show();
               // a.Activate();
                this.Hide();
                this.Close();
                Close();

            }
            

           
            
        }
        }

       
        }
    

