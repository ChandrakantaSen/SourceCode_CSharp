using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Drop_down_3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int i, j, k;
        string []arr = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec"};
        // day
        for(i = 1; i <= 31; i++)
        {
            ddl_1.Items.Add(i.ToString());
        }
        // month
        for (j = 0; j < arr.Length; j++)
        {
            ddl_2.Items.Add(arr[j]);
        }
        //year
        for (k = 1950; k <= 2016; k++)
        {
            ddl_3.Items.Add(k.ToString());
        }
    }

    protected void ddl_1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btn_1_Click(object sender, EventArgs e)
    {
        Lit_1.Text = "DOB is : " + ddl_1.SelectedItem.Value + "/" + ddl_2.SelectedItem.Value + "/" + ddl_3.SelectedItem.Value;
    }
}