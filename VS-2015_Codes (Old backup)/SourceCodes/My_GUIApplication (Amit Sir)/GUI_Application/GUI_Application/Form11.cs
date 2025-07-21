using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_Application
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (r1.Checked)
            {
                this.BackgroundImage = Image.FromFile("C:\\Users\\Chandra\\Documents\\Visual Studio 2008\\Projects\\My_GUIApplication\\GUI_Application\\GUI_Application\\images\\1.jpg");
            }
            else if (r2.Checked)
            {
                this.BackgroundImage = Image.FromFile("C:\\Users\\Chandra\\Documents\\Visual Studio 2008\\Projects\\My_GUIApplication\\GUI_Application\\GUI_Application\\images\\2.jpg");
            }
            else
            {
                this.BackgroundImage = Image.FromFile("C:\\Users\\Chandra\\Documents\\Visual Studio 2008\\Projects\\My_GUIApplication\\GUI_Application\\GUI_Application\\images\\3.jpg");
            }
        }
    }
}
