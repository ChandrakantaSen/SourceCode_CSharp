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
    public partial class search : System.Web.UI.Page
    {
        globalcon obj = new globalcon();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                obj.DAO();
                Literal1.Text = "conection established";
            }
            catch (Exception ex)
            {
                Literal1.Text = "not connected";
            }   
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string s = "select * from myemp where eid =" + id.Text;
                // using OleDBDataAdapter
                /*obj.da = new OleDbDataAdapter(s, obj.con);

                obj.da.Fill(obj.ds, "myemp");
                int m = obj.ds.Tables["myemp"].Rows.Count;

                if (m == 1)
                {
                    Literal1.Text = "sal :" + obj.ds.Tables["myemp"].Rows[0][2].ToString();
                }
                else
                {
                    Literal1.Text = "Record not found...";
                }*/

                //using Datareader
                obj.com = new OleDbCommand(s, obj.con);
                obj.dr = obj.com.ExecuteReader();

                if (obj.dr.HasRows())
                {
                    while (obj.dr.Read())
                    {
                        Literal1.Text = obj.dr.GetValue(2).ToString();
                    }
                }
                else
                {
                    Literal1.Text = "Records not found ... ";
                }
            }
            catch (Exception ex)
            {
                Literal1.Text = ex.Message;
            }
        }

        
    }
}
