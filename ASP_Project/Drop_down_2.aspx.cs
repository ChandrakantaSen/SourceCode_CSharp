using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Drop_down_2 : System.Web.UI.Page
{
    string str, str_1;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddl_1.Items.Add("C");
            ddl_1.Items.Add("C++");
            ddl_1.Items.Add("C#");
            ddl_1.Items.Add("Java");
            ddl_1.Items.Add("php");
            ddl_1.Items.Add("Oracle");
        }
    }

    protected void btn_1_Click(object sender, EventArgs e)
    {

    }

    protected void ddl_1_SelectedIndexChanged(object sender, EventArgs e)
    {
        str = ddl_1.SelectedItem.Value.ToString();

        if (str == "C")
        {
            txt_1.Text = "1000";
            Lit_1.Text = "Selected Language is : " + str + " & Fees is : " + txt_1.Text;
        }
        else if (str == "C++")
        {
            txt_1.Text = "1700";
            Lit_1.Text = "Selected Language is : " + str + " & Fees is : " + txt_1.Text;
        }
        else if (str == "C#")
        {
            txt_1.Text = "2800";
            Lit_1.Text = "Selected Language is : " + str + " & Fees is : " + txt_1.Text;
        }
        else if (str == "Java")
        {
            txt_1.Text = "3450";
            Lit_1.Text = "Selected Language is : " + str + " & Fees is : " + txt_1.Text;
        }
        else if (str == "php")
        {
            txt_1.Text = "1250";
            Lit_1.Text = "Selected Language is : " + str + " & Fees is : " + txt_1.Text;
        }
        else if (str == "Oracle")
        {
            txt_1.Text = "4450";
            Lit_1.Text = "Selected Language is : " + str + " & Fees is : " + txt_1.Text;
        }
        else
        {
            Lit_1.Text = "Data not loaded";
        }
    }
}