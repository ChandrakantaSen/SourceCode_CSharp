using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Aplicatie
{
    public partial class Useri : Form
    {
        private OleDbConnection connection;
        private OleDbCommand cmd;
        private OleDbDataAdapter da;
        private DataSet ds;
        public Useri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (connection == null || connection.State == ConnectionState.Closed)
            {
                connection = new OleDbConnection();
                string connstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\firma.mdb;User Id=admin;Password=;";
                connection.ConnectionString = connstr;
                connection.Open();
            }

            OleDbCommand cmd = new OleDbCommand("insert into Logare(Username,Parola,Rol) values('" + textBox1.Text + "' ,'" + textBox2.Text + "','" + comboBox1.Text.ToString() + "')", connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Persoana a fost inregistrata in baza de date");
            textBox1.Text = " ";
            textBox2.Text = " ";
            comboBox1.Text = " ";
            connection.Close();
        }

       
    }
}
