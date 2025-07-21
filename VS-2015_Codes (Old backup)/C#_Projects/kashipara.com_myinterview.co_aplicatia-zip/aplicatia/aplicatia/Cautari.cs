using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Aplicatie
{
	
	public class Cautari : System.Windows.Forms.Form
	{
		private OleDbConnection connection;
		private OleDbCommand cmd;
		private OleDbDataAdapter da;
		private DataSet ds;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton9;
		private System.Windows.Forms.RadioButton radioButton10;
		private System.Windows.Forms.RadioButton radioButton11;
		private System.Windows.Forms.RadioButton radioButton12;
		private System.Windows.Forms.RadioButton radioButton13;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGrid dataGrid2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button4;
		
		private System.ComponentModel.Container components = null;

		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGrid2 = new System.Windows.Forms.DataGrid();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cautari";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton11
            // 
            this.radioButton11.Location = new System.Drawing.Point(24, 152);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(120, 24);
            this.radioButton11.TabIndex = 3;
            this.radioButton11.Text = "Cautare Distribuitor";
            this.radioButton11.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            // 
            // radioButton10
            // 
            this.radioButton10.Location = new System.Drawing.Point(24, 112);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(152, 24);
            this.radioButton10.TabIndex = 2;
            this.radioButton10.Text = "Cautare Agent de vanzari";
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.Location = new System.Drawing.Point(24, 72);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(120, 24);
            this.radioButton9.TabIndex = 1;
            this.radioButton9.Text = "Cautare Furnizor";
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(24, 32);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(104, 24);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.Text = "Cautare Client";
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(184, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(104, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cauta";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton13
            // 
            this.radioButton13.Location = new System.Drawing.Point(16, 104);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(144, 24);
            this.radioButton13.TabIndex = 1;
            this.radioButton13.Text = "Cauta dupa nume";
            this.radioButton13.CheckedChanged += new System.EventHandler(this.radioButton13_CheckedChanged);
            // 
            // radioButton12
            // 
            this.radioButton12.Location = new System.Drawing.Point(16, 48);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(104, 24);
            this.radioButton12.TabIndex = 0;
            this.radioButton12.Text = "Cauta dupa id";
            this.radioButton12.CheckedChanged += new System.EventHandler(this.radioButton12_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 552);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "Salveaza modificarile";
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGrid2
            // 
            this.dataGrid2.DataMember = "";
            this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid2.Location = new System.Drawing.Point(32, 432);
            this.dataGrid2.Name = "dataGrid2";
            this.dataGrid2.Size = new System.Drawing.Size(616, 96);
            this.dataGrid2.TabIndex = 3;
            this.dataGrid2.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 32);
            this.button3.TabIndex = 4;
            this.button3.Text = "Refresh";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton12);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.radioButton13);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(336, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 256);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton9);
            this.groupBox2.Controls.Add(this.radioButton10);
            this.groupBox2.Controls.Add(this.radioButton11);
            this.groupBox2.Location = new System.Drawing.Point(32, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 256);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(384, 552);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 48);
            this.button4.TabIndex = 7;
            this.button4.Text = "Sterge";
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Cautari
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackgroundImage = global::Aplicatie.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 630);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGrid2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "Cautari";
            this.Load += new System.EventHandler(this.Cautari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		public Cautari()
		{
			
			InitializeComponent();

		}

		private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
		{
			dataGrid2.Visible=false;
		
            groupBox1.Visible=true;  
			radioButton12.Visible=true;
			radioButton12.Checked=false;
			radioButton13.Visible=true;
			radioButton13.Checked=false;
			textBox1.Visible=true;
			textBox3.Visible=true;

			radioButton12.Refresh();
			radioButton13.Refresh();
			button1.Visible=false;
			button2.Visible=false;
			textBox1.Clear();
			textBox3.Clear();

			dataGrid2.DataSource=null;
		}

		private void radioButton9_CheckedChanged(object sender, System.EventArgs e)
		{
			dataGrid2.Visible=false;
			groupBox1.Visible=true;
			radioButton12.Visible=true;
			radioButton12.Checked=false;
			radioButton13.Visible=true;
			radioButton13.Checked=false;
			textBox1.Visible=true;
			textBox3.Visible=true;
			radioButton12.Refresh();
			radioButton13.Refresh();
			button1.Visible=false;
			button2.Visible=false;
			textBox1.Clear();
			textBox3.Clear();
			dataGrid2.DataSource=null;
		}

		private void radioButton10_CheckedChanged(object sender, System.EventArgs e)
		{
			dataGrid2.Visible=false;
			groupBox1.Visible=true;
			radioButton12.Visible=true;
			radioButton12.Checked=false;
			radioButton13.Visible=true;
			radioButton13.Checked=false;
			textBox1.Visible=true;
			textBox3.Visible=true;
			radioButton12.Refresh();
			radioButton13.Refresh();
			button1.Visible=false;
			button2.Visible=false;
			textBox1.Clear();
			textBox3.Clear();
			dataGrid2.DataSource=null;
		}

		private void radioButton11_CheckedChanged(object sender, System.EventArgs e)
		{
			dataGrid2.Visible=false;
			groupBox1.Visible=true;
			radioButton12.Visible=true;
			radioButton12.Checked=false;
			radioButton13.Visible=true;
			radioButton13.Checked=false;
			textBox1.Visible=true;
			textBox3.Visible=true;
			radioButton12.Refresh();
			radioButton13.Refresh();
			button1.Visible=false;
			button2.Visible=false;
			textBox1.Clear();
			textBox3.Clear();
			dataGrid2.DataSource=null;
		}

		private void panel2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void radioButton12_CheckedChanged(object sender, System.EventArgs e)
		{
			button1.Visible=true;
			textBox1.Clear();
			dataGrid2.DataSource=null;
		}

		private void radioButton13_CheckedChanged(object sender, System.EventArgs e)
		{
			button1.Visible=true;
			textBox3.Clear();
			dataGrid2.DataSource=null;

		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			

			if (radioButton12.Checked==true)
			{
				textBox3.Clear();
				if (textBox1.Text=="")
				{
					MessageBox.Show("Completati id-ul");
				}
				else
				{
					button2.Visible=true;
					button4.Visible=true;
					dataGrid2.Visible=true;
					dataGrid2.DataSource=null;

					if (connection==null || connection.State == ConnectionState.Closed)
					{
						connection = new OleDbConnection();
						string connstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath+"\\firma.mdb;User Id=admin;Password=;";			
						connection.ConnectionString = connstr;
						connection.Open();
					}
					if (connection!=null && connection.State == ConnectionState.Open)
					{
						ds = new DataSet();
						cmd = new OleDbCommand();
						cmd.Connection = connection;
						if (radioButton3.Checked==true)
						{
							cmd.CommandText = "select * from clienti where id_client="+textBox1.Text.ToString();
						}
						else if (radioButton9.Checked==true)
						{
							cmd.CommandText = "select * from furnizori where id_furnizor="+textBox1.Text.ToString();
						}
						else if (radioButton10.Checked==true)
						{
							cmd.CommandText = "select * from agenti_vanzari where id="+textBox1.Text.ToString();
						}
						else if (radioButton11.Checked==true)
						{
							cmd.CommandText = "select * from distribuitori where id="+textBox1.Text.ToString();
						}
						da = new OleDbDataAdapter(cmd);
				
						da.Fill(ds);
						dataGrid2.DataSource = ds.Tables[0];

						if (ds.Tables[0].Rows.Count==0)
							MessageBox.Show("Persoana nu a fost gasita in baza de date");
					}
					if (connection!=null && (connection.State == ConnectionState.Open || connection.State == ConnectionState.Connecting))
					{
						connection.Close();
								
					}
				}
			}
			else if ( radioButton13.Checked==true)
			{
				if (textBox3.Text=="")
				{
					MessageBox.Show("Completati numele");
				}
				else
				{
					button2.Visible=true;
					button4.Visible=true;
					dataGrid2.Visible=true;
					dataGrid2.DataSource=null;
					textBox1.Clear();

					if (connection==null || connection.State == ConnectionState.Closed)
					{
						connection = new OleDbConnection();
						string connstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath+"\\firma.mdb;User Id=admin;Password=;";			
						connection.ConnectionString = connstr;
						connection.Open();
					}
					if (connection!=null && connection.State == ConnectionState.Open)
					{
						ds = new DataSet();
						cmd = new OleDbCommand();
						cmd.Connection = connection;

						if (radioButton3.Checked==true)
						{
						    cmd.CommandText = "select * from clienti where nume='"+textBox3.Text+"'";
						}
						else if (radioButton9.Checked==true)
						{
							cmd.CommandText = "select * from furnizori where nume='"+textBox3.Text+"'";
						}
						else if (radioButton10.Checked==true)
						{
							cmd.CommandText = "select * from agenti_vanzari where nume='"+textBox3.Text+"'";
						}
						else if (radioButton11.Checked==true)
						{
							cmd.CommandText = "select * from distribuitori where nume='"+textBox3.Text+"'";
						}
						da = new OleDbDataAdapter(cmd);
				
						da.Fill(ds);
						dataGrid2.DataSource = ds.Tables[0];

						if (ds.Tables[0].Rows.Count==0)
							MessageBox.Show("Persoana nu a fost gasita in baza de date");
					}
					if (connection!=null && (connection.State == ConnectionState.Open || connection.State == ConnectionState.Connecting))
					{
						connection.Close();
								
					}
				}
			}
		
		}

		private void button3_Click(object sender, System.EventArgs e)
		{			
			dataGrid2.DataSource=null;
			
			dataGrid2.Visible=false;
			
			radioButton3.Checked=false;
			radioButton9.Checked=false;
			radioButton10.Checked=false;
			radioButton11.Checked=false;

			groupBox1.Visible=false;
			textBox1.Clear();
			textBox3.Clear();

			button2.Visible=false;
			button4.Visible=false;

		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			bool stop; 
			stop = MessageBox.Show("Sunteti sigur de modificarile pe care vreti sa le faceti?"," ",System.Windows.Forms.MessageBoxButtons.YesNo)== DialogResult.Yes;
            
			if (connection==null || connection.State == ConnectionState.Closed)
			{
				connection = new OleDbConnection();
				string connstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath+"\\firma.mdb;User Id=admin;Password=;";			
				connection.ConnectionString = connstr;
				connection.Open();
			}
			if (stop == true)
			{
				cmd = new OleDbCommand();
				cmd.Connection=connection;

				foreach (DataRow row in ds.Tables[0].Rows)
				{
					if (row.RowState == DataRowState.Modified)
					{
						if (radioButton3.Checked==true)
						{
							cmd.CommandText = "Update clienti set nume='"+row["nume"]+"',adresa='"+row["adresa"]+"',localitate='"+row["localitate"]+"',telefon='"+row["telefon"]+"',banca='"+row["banca"]+"',cont_bancar="+row["cont_bancar"].ToString()+" where id_client ="+row["id_client"].ToString();
						}
						else if (radioButton9.Checked==true)
							cmd.CommandText = "Update furnizori set nume='"+row["nume"]+"',cont_bancar="+row["cont_bancar"].ToString()+",localitate= '"+row["localitate"]+"',telefon = '"+row["telefon"]+"'adresa= '"+row["adresa"]+"',banca= '"+row["banca"]+"'  where id_furnizor = "+row["id_furnizor"].ToString();
						else if (radioButton10.Checked==true)
							cmd.CommandText = "Update agenti_vanzari set nume='"+row["nume"]+"',cont_bancar="+row["cont_bancar"].ToString()+",localitate= '"+row["localitate"]+"',telefon = '"+row["telefon"]+"'adresa= '"+row["adresa"]+"',banca= '"+row["banca"]+"'  where id = "+row["id"].ToString();
						else if (radioButton10.Checked==true)
							cmd.CommandText = "Update distribuitori set nume='"+row["nume"]+"',cont_bancar="+row["cont_bancar"].ToString()+",localitate= '"+row["localitate"]+"',telefon = '"+row["telefon"]+"'adresa= '"+row["adresa"]+"',banca= '"+row["banca"]+"'  where id = "+row["id"].ToString();
				
					}
					cmd.ExecuteNonQuery();
				}
				MessageBox.Show("modificarile dumneavoastra au fost salvate");
			}
		      
		}

		private void Cautari_Load(object sender, System.EventArgs e)
		{
		
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			bool stop; 
			stop = MessageBox.Show("Sunteti sigur ca vreti sa stergeti inregistrarea?"," ",System.Windows.Forms.MessageBoxButtons.YesNo)== DialogResult.Yes;
          
			if (connection==null || connection.State == ConnectionState.Closed)
			{
				connection = new OleDbConnection();
				string connstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath+"\\firma.mdb;User Id=admin;Password=;";			
				connection.ConnectionString = connstr;
				connection.Open();
			}
			if (stop == true)
			{
				if (ds!=null && connection!=null && connection.State == ConnectionState.Open)
				{
					cmd = new OleDbCommand();
					cmd.Connection = connection;
				
					foreach (DataRow row in ds.Tables[0].Rows)
					{
						if (radioButton3.Checked==true)
							cmd.CommandText = " delete from clienti where (id_client="+row["id_client"].ToString()+")";
						else if (radioButton9.Checked==true)
							cmd.CommandText = " delete from furnizori where (id_furnizor="+row["id_furnizor"].ToString()+")";
						else if (radioButton10.Checked==true)
							cmd.CommandText = " delete from agenti_vanzari where (id="+row["id"].ToString()+")";
						else if (radioButton10.Checked==true)
							cmd.CommandText = " delete from distribuitori where (id="+row["id"].ToString()+")";
					}					
				
					cmd.ExecuteNonQuery(); 
					MessageBox.Show("Inregistrarea a fost stearsa din baza de date","",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
					dataGrid2.DataSource=null;
				}
			}
			if (connection!=null && (connection.State == ConnectionState.Open || connection.State == ConnectionState.Connecting))
			{
				connection.Close();
			}
		}

		}
}

