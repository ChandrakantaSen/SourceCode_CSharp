using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.OleDb;

namespace ASP_DBProject
{
    public partial class insert : System.Web.UI.Page
    {
        globalcon obj = new globalcon();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                obj.DAO();
                Literal1.Text = "conection established";
            }
            catch(Exception ex) 
            {
                Literal1.Text = "not connected";
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            int i;
            try
            {
                string s = "insert into myemp values('" + id.Text + "','" + nm.Text + "'," + sal.Text + ")";
                obj.com = new OleDbCommand(s, obj.con);
                i = obj.com.ExecuteNonQuery();
                Literal1.Text = "Row " + i.ToString();
            }
            catch (Exception ex)
            {
                Literal1.Text = ex.Message;
            }
        }

       
    }
}
