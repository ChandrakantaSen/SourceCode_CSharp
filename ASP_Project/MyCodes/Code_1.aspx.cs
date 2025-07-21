using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyCodes_Code_1 : System.Web.UI.Page
{
    string str;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void submit_Click(object sender, EventArgs e)
    {
        str = txt1.Text;

        if(str != " ")
        {
            lit1.Text = "hello " + str;
        }
        else
        {
            lit1.Text = "value not loaded...!";
        }

    }
}