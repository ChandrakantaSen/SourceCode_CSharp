using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DB_Codes_View : System.Web.UI.Page
{
    glob g = new glob();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            g.chandra_connect();
            Literal1.Text = "Connected successfully.....";
        }
        catch(Exception ex)
        {
            Literal1.Text = "error : " + ex.Message;
        }
    }
}