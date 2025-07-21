using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyCodes_Code_2 : System.Web.UI.Page
{
    int m, n, result;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void submit_Click(object sender, EventArgs e)
    {
        m = int.Parse(txt1.Text);
        n = int.Parse(txt2.Text);

        if(txt1.Text != " " && txt2.Text != " ")
        {
            if(m > 0 && n > 0)
            {
                result = (m + n);
            }
            else if (m > 0 && n < 0)
            {
                result = (m - n);
            }
            else if(m < 0 && n > 0)
            {
                result = (n - m);
            }
            else
            {
                result = (m + n);
            }
            if (result > 0)
            {
                lit1.Text = "Sum is: " + result;
            }
            else
            {
                lit1.Text = " Sum is less than zero...!" + result;
            }
        }
    }
}