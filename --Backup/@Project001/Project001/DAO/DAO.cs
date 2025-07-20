using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;

namespace Project001.DAO
{
    public class DAO
    {
        public static string str = "";
        public static string query = "";
        public static int numrows = 0;
        public static SqlConnection cnn = null;
        public static SqlCommand cm = null;
        public static DataTable dt = null;
        //public static SqlDataReader sdr = null;
        public static SqlDataAdapter sda = null;

        //App_Customer.ViewCustomer VCobj = new App_Customer.ViewCustomer();

        //Database Connectivity
        public static int connect()
        { 
            string connetionString = null;
            
            int flag = 0;
            connetionString = "Server= localhost; Database= MEDIS; Integrated Security=SSPI;";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                flag = 1;
                Console.WriteLine("Connection Successfull...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex);
            }
            return flag;
        }

        //Save button - AddCustomer.cs - Data Insertion
        public static int rcdInsrt(String x,String y, String z, String w, String u, String v, String p, String q, String r)
        {
            int flag = 0;
            try
            {
                // writing sql query
                query = "INSERT INTO [medis].[dbo].[AddCustomer]" +
                        "(custName" +
                        ", custAdd" +
                        ", custLndMrk" +
                        ", custContactNo" +
                        ", custEmailId" +
                        ", custVAT" +
                        ", custCST" +
                        ", custGST" +
                        ", custPAN)" + 
                        "VALUES('" + x + "','" + y + "','" + z + "','" + w + "','" + u +"','" + v + "','" + p + "','" + q + "','" + r +"')";

                cm = new SqlCommand(query, cnn);

                // Executing the SQL query  
                numrows = cm.ExecuteNonQuery();

                if (numrows != 0)
                {
                    flag = 1;
                }
                else
                {
                    flag = 0;
                }
            }
            catch(SqlException e1)
            {
                Console.WriteLine("Exception: " + e1);
            }
            catch (Exception e2)
            {
                Console.WriteLine("OOPs, something went wrong." + e2);
            }
            return flag;
        }

        //Dispaly Data - ViewCustomer.cs - Data Show under criteria
        public static void showData(string s)
        { 
            int i = connect();
            if(i == 1)
            {
                query = "Select * from addcustomer where custName='" + s + "'";
                cm = new SqlCommand(query,cnn);
                sda = new SqlDataAdapter(cm);
                dt = new DataTable();
                sda.Fill(dt);
            }
            else
			{
                Console.WriteLine("Data show is not possible...");
			}
        }

        //Dispaly All Data - ViewCustomer.cs
        public static void AllshowData()
		{
            int i = connect();
            if (i == 1)
            {
                query = "Select * from addcustomer";
                cm = new SqlCommand(query, cnn);
                sda = new SqlDataAdapter(cm);
                dt = new DataTable();
                sda.Fill(dt);
            }
            else
            {
                Console.WriteLine("Data show is not possible...");
            }
        }
	}
}
