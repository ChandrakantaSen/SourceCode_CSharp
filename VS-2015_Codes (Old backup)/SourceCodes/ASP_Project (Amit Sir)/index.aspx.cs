using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string name;
        name = TextBox1.Text;
        Literal1.Text = "Hello <font color='blue' size='5'>" + name + "</font>,Welcome to Google ";

    }
}