using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace RecapsulationCodes.DBCon
{
    class DBConnect
    {
        string str = "";
        string query = "";
        public SqlConnection con = null;
        public SqlCommand cmd = null;
        public SqlDataReader cdr = null;

        public void getCon()
        {
            try
            {
                //str = "data source=CHANDRA-PC\\SQLEXPRESS; database=Project001; integrated security=SSPI";
                str = "Server= localhost; Database= GGI; Integrated Security=SSPI;"; 
                
                con = new SqlConnection(str);

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    Console.WriteLine("Connection Successfull...!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
        }

        public void crtTable()
        {
            int numrows;
            getCon();
            try
            {
                query = "CREATE TABLE A2(" +
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
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
        }

        public void insrtDataTable()
        {
            int numrows;
            int pid;
            string fnm, lnm, add, cty;

            getCon();
            try
            {
                Console.Write("Enter the PersonId: ");
                pid = int.Parse(Console.ReadLine());

                Console.Write("Enter the Firstname: ");
                fnm = Console.ReadLine();

                Console.Write("Enter the Lastname: ");
                lnm = Console.ReadLine();

                Console.Write("Enter the Address: ");
                add = Console.ReadLine();

                Console.Write("Enter the City: ");
                cty = Console.ReadLine();

                query = "INSERT INTO A2"                                            +
                        "(PersonId, LastName, FirstName, Address, City)"                 + 
                        "VALUES("                                                        +
                        pid + ",'" + lnm + "','" + fnm + "','" + add + "','" + cty + "'" +
                        ")";

                cmd = new SqlCommand(query, con);
                numrows = cmd.ExecuteNonQuery();

                if (numrows != 0)
                {
                    Console.WriteLine("Table data inserted successfully...!");
                }
                else
                {
                    Console.WriteLine("Table data insertion error...!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }    
        }

        public void deleteDataTable()
        {
            int numrows;
            int pid;

            getCon();
            try
            {
                Console.Write("Enter the PersonId: ");
                pid = int.Parse(Console.ReadLine());

                query = "Delete From A2 where PersonId = " + pid;

                cmd = new SqlCommand(query, con);
                numrows = cmd.ExecuteNonQuery();

                if (numrows != 0)
                {
                    Console.WriteLine("Table data deleted successfully...!");
                }
                else
                {
                    Console.WriteLine("Table data deletion error...!");
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
                query = "Select * from A2";

                cmd = new SqlCommand(query, con);
                cdr = cmd.ExecuteReader();

                if (cdr.HasRows)
                {
                    while (cdr.Read())
                    {
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine(cdr["PersonId"] + " | " + cdr["FirstName"] + " " + cdr["LastName"] + "  |  " + cdr["Address"] + "  |  " + cdr["City"]);
                    }
                }
                else
                {
                    Console.WriteLine("Table does not contain any data...!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }     
        }

        public void viewDataTable()
        {
            int pid;
            getCon();
            try
            {
                Console.Write("Enter the PersonId: ");
                pid = int.Parse(Console.ReadLine());

                query = "Select * from A2 where PersonId = " + pid;

                cmd = new SqlCommand(query, con);
                cdr = cmd.ExecuteReader();

                if (cdr.HasRows)
                {
                    while (cdr.Read())
                    {
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine(cdr["PersonId"] + " | " + cdr["FirstName"] + " " + cdr["LastName"] + "  |  " + cdr["Address"] + "  |  " + cdr["City"]);
                    }
                }
                else
                {
                    Console.WriteLine("Table does not contain any data...!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }     
        }

        public void searchDataTable()
        {
            int pid;
            getCon();

            try
            {
                Console.Write("Enter the PersonId: ");
                pid = int.Parse(Console.ReadLine());

                query = "Select * From A2 where PersonId = " + pid;

                cmd = new SqlCommand(query, con);
                cdr = cmd.ExecuteReader();

                if (cdr.HasRows)
                {
                    while (cdr.Read())
                    {
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine(cdr["PersonId"] + " | " + cdr["FirstName"] + " " + cdr["LastName"] + "  |  " + cdr["Address"] + "  |  " + cdr["City"]);
                    }
                }
                else
                {
                    Console.WriteLine("Table does not contain any data...!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }     
        }

        public void updateDataTable()
        {
            int pid, numrows;
            string fnm, lnm;
            getCon();

            try
            {
                Console.Write("Enter the PersonId: ");
                pid = int.Parse(Console.ReadLine());

                Console.Write("Enter the First Name for updation: ");
                fnm = Console.ReadLine();

                Console.Write("Enter the Last Name for updation: ");
                lnm = Console.ReadLine();

                query = "Update A2 set FirstName = '" + fnm + "', LastName = '" + lnm + "' where PersonId = "+ pid;

                //Console.WriteLine(query);
                cmd = new SqlCommand(query, con);
                numrows = cmd.ExecuteNonQuery();

                if (numrows != 0)
                {
                    Console.WriteLine("Table data updated successfully...!");
                }
                else
                {
                    Console.WriteLine("Table data updation error...!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }    
        }
    }
}