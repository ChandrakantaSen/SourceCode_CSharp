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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //label1.Text = LogIn.usrNm;
            LeftHead.Text = "Welcome " + LogIn.roleNm;
            RightHead.Text = "Hello " + LogIn.usrNm;
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Settings settingsObj = new Settings();
            settingsObj.Show();           
        }

    }
}
