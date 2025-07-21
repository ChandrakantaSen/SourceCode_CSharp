using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace FoodJunction
{
    class Global
    {
        public static string Caption = "Restaurent Management Systems";
        public SqlConnection sqlCon;

        public void MyConnection()
        {
            sqlCon=new SqlConnection("Data Source =localhost;Initial Catalog=FoodJunction;User Id=sa;Password=dasmondal");

        }

    }
}
