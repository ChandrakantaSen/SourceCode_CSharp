using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBcon_WinForms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string connetionString = null;
			SqlConnection cnn;
			connetionString = "Data Source=CHANDRA-PC\\SQLEXPRESS;Initial Catalog=Project001;Integrated Security=True";
			cnn = new SqlConnection(connetionString);

			try
			{
				cnn.Open();
				MessageBox.Show("Connection Open ! ");
				cnn.Close();
			}
			catch (Exception ex)
			{
				//MessageBox.Show("Can not open connection ! ");
				MessageBox.Show(ex.Message);
			}
			/*try
			{
				String str = "server=ABC-PC;database=Test;UID=abc-PC/abc;password=";
				//String query = "select * from data";
				SqlConnection con = new SqlConnection(str);
				//SqlCommand cmd = new SqlCommand(query, con);
				con.Open();
				//DataSet ds = new DataSet();
				MessageBox.Show("connect with sql server");
				con.Close();
			}
			catch (Exception es)
			{
				MessageBox.Show(es.Message);
			}*/
		}
	}
}
