using System;
using System.Data;
using System.Data.OleDb;

public class globalcon
{
    public OleDbConnection con = new OleDbConnection();
    public OleDbCommand com;
    public OleDbDataReader dr;
    public OleDbDataAdapter da;
    public DataSet ds = new DataSet();

    public void DAO()
    {
        con.ConnectionString = "Provider = MSDAORA; User Id = scott; Password = tiger; Data Source = orcl";
        con.Open();
    }
}

