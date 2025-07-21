using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Drop_down : System.Web.UI.Page
{
    string str;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_1_Click(object sender, EventArgs e)
    {
        str = ddl_1.SelectedValue.ToString();

        if(str == "C")
        {
            Lit_1.Text = "Hello, you are selected " + str;
        }
        else if (str == "C++")
        {
            Lit_1.Text = "Hello, you are selected " + str;
        }
        else if (str == "Java")
        {
            Lit_1.Text = "Hello, you are selected " + str;
        }
        else if (str == "php")
        {
            Lit_1.Text = "Hello, you are selected " + str;
        }
        else if (str == "C#")
        {
            Lit_1.Text = "Hello, you are selected " + str;
        }
        else
        {
            Lit_1.Text = "Not Working...!" + str;
        }
    }
}