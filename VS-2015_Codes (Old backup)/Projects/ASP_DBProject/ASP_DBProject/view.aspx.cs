using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace ASP_DBProject
{
    public partial class view : System.Web.UI.Page
    {
        globalcon obj = new globalcon();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                obj.DAO();
                
               // Literal1.Text = "conection established";
            }
            catch (Exception ex)
            {
             //   Literal1.Text = "not connected";
            }

            string s = "select * from myemp";
            obj.com = new OleDbCommand(s, obj.con);
            obj.dr=obj.com.ExecuteReader();
            GridView1.DataSource = obj.dr;
            GridView1.DataBind();

        }
    }
}
