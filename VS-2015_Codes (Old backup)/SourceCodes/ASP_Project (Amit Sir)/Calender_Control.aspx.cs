using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Calender_Control : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            C1.Visible = false;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        C1.Visible = true;
    }

    protected void C1_SelectionChanged(object sender, EventArgs e)
    {
        String d, m, y;
        d = C1.SelectedDate.Day.ToString();
        m = C1.SelectedDate.Month.ToString();
        y = C1.SelectedDate.Year.ToString();

        /* Type -I */
        //T1.Text = C1.SelectedDate.ToShortDateString();

        /* Type - II */
        switch(m)
        {
            case "1":
                m = "jan"; break;
            case "2":
                m = "feb"; break;
            case "3":
                m = "mar"; break;
            case "4":
                m = "apr"; break;
            case "5":
                m = "may"; break;
            case "6":
                m = "jun"; break;    
        }
        T1.Text = d + "-" + m + "-" + y;

        C1.Visible = false;
    }
}