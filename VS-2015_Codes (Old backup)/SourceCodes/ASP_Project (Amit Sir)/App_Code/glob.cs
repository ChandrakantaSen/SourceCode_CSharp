using System;
using System.Data;
using System.Data.OleDb;


public class glob
{
    public OleDbConnection con = new OleDbConnection();
    public void chandra_connect()
    {
        con.ConnectionString = "Provider=MSDAORA;User ID=scott;Password=tiger;Data Source=orcl";
        con.Open();
    }
}