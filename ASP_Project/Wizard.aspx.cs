using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Wizard : System.Web.UI.Page
{
    int scr = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
    {
        if(R2.Checked == true && R8.Checked == true)
        {
            scr = 10;
        }
        else if(R2.Checked == false && R8.Checked == false)
        {
            scr = 0;
        }
        else
        {
            if (R8.Checked == true)
            {
                scr += 5;
            }
            else if (R2.Checked == true)
            {
                scr += 5;
            }
            else
            {
                scr -= 3;
            }
        }
        L1.Text = "Total Score is: " + scr;
    }
}