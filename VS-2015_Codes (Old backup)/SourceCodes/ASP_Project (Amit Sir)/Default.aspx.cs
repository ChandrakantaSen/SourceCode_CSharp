using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string str1, str2;

    protected void Page_Load(object sender, EventArgs e)
    {
        txt2.ReadOnly = true;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Response.Write("ok");
    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        txt2.ReadOnly = false;
        Response.Write("its working");
    }

    protected void submit_Click(object sender, EventArgs e)
    {
        Response.Write("ok");
        str1 = txt1.Text;
        str2 = txt2.Text;

        //Label3.Text = str1;

        if (txt1.Text != "")
        {
            if (CheckBox1.Checked == true)
            {

                Lit.Text = "Hello " + str1 + " u are a graduate in " + str2;
            }
            else
            {
                Lit.Text = "Hello " + str1 + " u are under graduate";
            }
        }
        else
        {
            Lit.Text = "<font color='red' size='5'>Please enter ur name first...!</font>";
        }
    }
}