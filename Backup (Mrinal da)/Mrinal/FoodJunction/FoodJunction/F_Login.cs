using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace FoodJunction
{
    public partial class F_Login : Form
    {

        Global sqlConn = new Global();
        //SqlConnection Conn = new SqlConnection(@"Data Source =localhost;Initial Catalog=FoodJunction;User Id=sa;Password=dasmondal");
        public static string GroupId;



        public F_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtUser.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("All fields are Mandatory");
                }

                string SQLStr;
                sqlConn.MyConnection();
                SQLStr = "SELECT FirstName + ' ' + LastName AS UserName, Email, GroupName, Password FROM T_User where Email ='" + txtUser.Text + "' and Password ='" + txtPassword.Text + "'";
                SqlDataAdapter DA = new SqlDataAdapter(SQLStr, sqlConn.sqlCon);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                if (DT.Rows.Count > 0)
                {

                        GroupId=DT.Rows[0]["GroupName"].ToString();
                        this.Hide();
                        OpScreen OPScr = new OpScreen(DT.Rows[0]["UserName"].ToString()); // Pass the User Name to display at next screen
                        OPScr.Show();

                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("User Name & Password not Match",ex.Message);
            }

            finally
            {
                if (sqlConn.sqlCon.State == ConnectionState.Open)
                {
                    sqlConn.sqlCon.Close();

                }

            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 

    }
}
