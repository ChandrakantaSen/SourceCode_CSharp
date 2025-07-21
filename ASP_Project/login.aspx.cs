using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void submit_click(object sender, EventArgs e)
    {
        //Response.Write("hello write");
        if(txt1.Text == "tcs" && txt2.Text == "kolkata")
        {
            //Response.Redirect("~/index.aspx");
            Server.Transfer("~/index.aspx");
        }
        else
        {
            Literal1.Text = "Please enter <font color='red' size='5'>UserId & Password</font>Correctly";
        }
    }
}