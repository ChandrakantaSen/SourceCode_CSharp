using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox2.ReadOnly = true;
    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if(CheckBox1.Checked)
        {
            TextBox2.ReadOnly = false;
        }
        else
        {
            TextBox2.ReadOnly = true;
            TextBox2.Text = "";
        }
        
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string n,q;
        if (TextBox1.Text == "")
        {
            Literal1.Text = "Plese Enter your name first...";
        }
        else
        {
            n = TextBox1.Text;
            if (CheckBox1.Checked)
            {
                q = TextBox2.Text;
            }
            else
            {
                q = "under graduate";
            }
            Literal1.Text = "Hi " + n + " your qualification is " + q;
        }
    }
}