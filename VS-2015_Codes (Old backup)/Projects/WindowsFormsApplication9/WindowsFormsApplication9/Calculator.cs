using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        double first = 0;
        double second = 0;
        string oper;
        
        private void btn0_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text != "")
                txtDisplay.Text += btn0.Text;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            first = 0;
            second = 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn9.Text;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (oper)
            {
                case "+":
                    second = first + double.Parse(txtDisplay.Text); break;
                case "-":
                    second = first - double.Parse(txtDisplay.Text); break;
                case "*":
                    second = first * double.Parse(txtDisplay.Text); break;
                case "/":
                    second = first / double.Parse(txtDisplay.Text); break;
            }
            txtDisplay.Text = second.ToString();
            first = 0;
                
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            oper = btnDivide.Text;
            first = first + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            oper = btnMultiply.Text;
            first = first + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            oper = btnSubtract.Text;
            first = first + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            oper = btnAdd.Text;
            first = first + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }
    }
}
