using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGUI_Project
{
    public partial class LogIn : Form
    {
        public static string usrNm = "" , pwdNm = "" , roleNm = "";

        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Take values to variable
            usrNm = usrnmTxtBox.Text.ToString();
            pwdNm = pwdTxtBox.Text.ToString();
            roleNm = roleDrpDwn.Text.ToString();

            // Create object for Home Page           
            Home home_obj = new Home();
            
            // Check LogIn credentials
            if (roleNm == "Administrator")
            {
                if (usrNm == "admin" && pwdNm == "Cisco001")
                {
                    this.Hide();
                    home_obj.Show();
                }
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            // it sets the focus on -- Login Button
            this.ActiveControl = button1;

            if (usrnmTxtBox.Text == "")
            {
                usrnmTxtBox.Text = "-- Enter UserName --";
                usrnmTxtBox.ForeColor = Color.Silver;
                usrnmTxtBox.Select(0,0);
            }
            
            if (pwdTxtBox.Text == "")
            {
                pwdTxtBox.Text = "-- Enter Password --";
                pwdTxtBox.ForeColor = Color.Silver;
                pwdTxtBox.Select(0, 0);
            }
            if (roleDrpDwn.Text == "")
            {
                roleDrpDwn.Text = "-- Select Role --";
            }
        }

        private void usrnmTxtBox_TextChanged(object sender, EventArgs e)
        {
            usrnmTxtBox.ForeColor = Color.Black;
        }

        private void pwdTxtBox_TextChanged(object sender, EventArgs e)
        {
            pwdTxtBox.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear Button
            usrnmTxtBox.Text = "";
            pwdTxtBox.Text = "";
            roleDrpDwn.Text = "-- Select Role --";
        }

        private void usrnmTxtBox_MouseClick(object sender, MouseEventArgs e)
        {
            // Click on TextBox -- it clears 
            usrnmTxtBox.Text = "";
        }

        private void pwdTxtBox_MouseClick(object sender, MouseEventArgs e)
        {
            // Click on TextBox -- it clears
            pwdTxtBox.Text = "";
        }
    }
}
