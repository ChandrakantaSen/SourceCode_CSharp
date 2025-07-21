using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBCon_Winforms
{
    class global
    {
        private int pid;
        private string fnm, lnm, add, cty;
        public int numrows;

        string str = "";
        string query = "";
        public SqlConnection con = null;
        public SqlCommand cmd = null;
        public SqlDataReader cdr = null;
        public DataTable dt = null;

        /* Custom Propertise -- as per fields */
        public int ID
        {
            get 
            {
                return pid;
            }
            set 
            {
                pid = value;
            }
        }

        public string FNM
        {
            get 
            {
                return fnm;
            }
            set 
            {
                fnm = value;
            }
        }

        public string LNM
        {
            get
            {
                return lnm;
            }
            set
            {
                lnm = value;
            }
        }

        public string ADDRESS
        {
            get
            {
                return add;
            }
            set
            {
                add = value;
            }
        }

        public string CITY
        {
            get
            {
                return cty;
            }
            set
            {
                cty = value;
            }
        }

        /* Methods as per functionalities */
        public int getCon()
        {
            try
            {
                str = "data source=CHANDRA-PC\\SQLEXPRESS; database=Project001; integrated security=SSPI";
                con = new SqlConnection(str);

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            return 0;
        }

        public int crtTbl()
        {
            int numrows = 0;
            try
            {
                getCon();

                query = "CREATE TABLE A3(" +
                        "PersonID int," +
                        "LastName varchar(255)," +
                        "FirstName varchar(255)," +
                        "Address varchar(255)," +
                        "City varchar(255)" +
                        ")";
                cmd = new SqlCommand(query, con);
                numrows = cmd.ExecuteNonQuery();

                if (numrows != 0)
                {
                    Console.WriteLine("Table created successfully...!");
                }
                else
                {
                    Console.WriteLine("Table creation error...!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("OOPs, something went wrong." + ex);
            }
            return 0;
        }

        public void insrtDataTable()
        {
            getCon();
            try
            {
                query = "INSERT INTO Persons" +
                        "(PersonId, LastName, FirstName, Address, City)" +
                        "VALUES(" +
                        ID + ",'" + LNM + "','" + FNM + "','" + ADDRESS + "','" + CITY + "'" +
                        ")";
                cmd = new SqlCommand(query, con);
                numrows = cmd.ExecuteNonQuery();
                if (numrows != 0)
                {
                    MessageBox.Show("Table data inserted successfully...!");
                }
                else
                {
                    MessageBox.Show("Table data insertion error...!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
        }

        public void viewAllDataTable()
        {
            getCon();
            try
            {
                query = "select * from Persons order by PersonId;";

                cmd = new SqlCommand(query, con);
                cdr = cmd.ExecuteReader();

                if (cdr.HasRows)
                {
                    dt = new DataTable();
                    dt.Load(cdr);
                }
                else
                {
                    MessageBox.Show("Table does not contain any data...!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
        }

        public void deltDataTable()
        {
            getCon();
            try
            {
                query = "DELETE FROM Persons WHERE PERSONID = " + ID;
                        
                cmd = new SqlCommand(query, con);
                numrows = cmd.ExecuteNonQuery();
                if (numrows != 0)
                {
                    MessageBox.Show("Table data deleted successfully...!");
                }
                else
                {
                    MessageBox.Show("Table data deletion error...!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
        }

        public void scrhDatatable()
        {
            getCon();
            try
            {
                query = "UPDATE FROM Persons WHERE PERSONID = " + ID;

                cmd = new SqlCommand(query, con);
                numrows = cmd.ExecuteNonQuery();
                if (numrows != 0)
                {
                    MessageBox.Show("Table data deleted successfully...!");
                }
                else
                {
                    MessageBox.Show("Table data deletion error...!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            } 
        }
    }
}
