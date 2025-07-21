using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyCodes_Code_3 : System.Web.UI.Page
{
    string str;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void submit_Click(object sender, EventArgs e)
    {
        str = txt1.Text;
        if(rb_list.SelectedItem.Value == "Excellent")
        {
            lit_1.Text = "Hello " + str + " , you are " + rb_list.SelectedItem.Value + "...!";
        }
        else if(rb_list.SelectedItem.Value == "Very Good")
        {
            lit_1.Text = "Hello " + str + " , you are " + rb_list.SelectedItem.Value + "...!";
        }
        else if (rb_list.SelectedItem.Value == "Good")
        {
            lit_1.Text = "Hello " + str + " , you are " + rb_list.SelectedItem.Value + "...!";
        }
        else if (rb_list.SelectedItem.Value == "Fair")
        {
            lit_1.Text = "Hello " + str + " , you are " + rb_list.SelectedItem.Value + "...!";
        }
        else if (rb_list.SelectedItem.Value == "Bad")
        {
            lit_1.Text = "Hello " + str + " , you are " + rb_list.SelectedItem.Value + "...!";
        }
        else
        {
            lit_1.Text = "Not Working";
        }
    }
}