using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MultiView : System.Web.UI.Page
{
    String nm,add,usr_nm,pwd,eml, ph_no;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        nm = T1.Text;
        add = T2.Text;
        usr_nm = T3.Text;
        pwd = T4.Text;
        eml = T5.Text;
        ph_no = T6.Text;

        L1.Text = "Hello, " + nm +"<br/>"+"username is "+ usr_nm + "<br/>email is "+eml;
    }
}