using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Aplicatie;
using System.Data.OleDb;


namespace Aplicatie
{
    public partial class Autentificare : Form
    {
        private OleDbConnection connection;
        private OleDbCommand cmd;
        private OleDbDataAdapter da;
        private DataSet ds;
        
        public Autentificare()
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
            string userText = textBox1.Text;
            string passText = textBox2.Text;

            OleDbCommand cmd = new OleDbCommand("SELECT Username,Parola FROM Logare WHERE Username='" + textBox1.Text + "' and Parola='" + textBox2.Text + "'",connection);
             da = new OleDbDataAdapter(cmd);
             ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Login Sucess!!");
               
                cmd = new OleDbCommand("SELECT Rol from Logare where Username=@Username",connection);
                cmd.Parameters.AddWithValue("Username", userText);
                string role = cmd.ExecuteScalar().ToString();
                MessageBox.Show("Bine ai venit!!"+" "+userText+" ("+role+")");
                if (role == "Admin")
                {
                    MainForm mn = new MainForm();
                    mn.WindowState = FormWindowState.Maximized;
                    mn.Show();
                    this.Close();
                }
                else {
                    MainUser mn = new MainUser();
                    mn.WindowState = FormWindowState.Maximized;
                    mn.Show();
                    this.Close();
                }
                
                connection.Close();
            }
            else
            {
                MessageBox.Show("Acces nepermis!!");
                
                connection.Close();
            }
           // textBox1.Text = " ";
           // textBox2.Text = " ";
        }

   
                
            }
        }




