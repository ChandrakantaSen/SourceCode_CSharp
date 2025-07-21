using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace Aplicatie
{
	/// <summary>
	/// Summary description for Intrari.
	/// </summary>
	public class Intrari : System.Windows.Forms.Form
	{
		private OleDbConnection connection;
		private OleDbCommand cmd;
		private OleDbDataAdapter da;
		private DataSet ds;
		private double valoare=0; 
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.ComboBox comboBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Intrari()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//

			label4.Visible=false;
			label5.Visible=false;
			label7.Visible=false;
			textBox2.Visible=false;
			textBox3.Visible=false;
			textBox5.Visible=false;
			label6.Visible=false;
			label8.Visible=false;
			textBox4.Visible=false;
			comboBox1.Visible=false;
			button2.Visible=false;


			label9.Visible=false;
			label10.Visible=false;
			label11.Visible=false;
			label12.Visible=false;
			label13.Visible=false;
			label14.Visible=false;
			label15.Visible=false;
			label16.Visible=false;

			button3.Visible=false;
			button4.Visible=false;
			button6.Visible=false;
			button5.Visible=false;

			textBox7.Visible=false;
			textBox8.Visible=false;
			textBox9.Visible=false;
			textBox10.Visible=false;
			textBox11.Visible=false;
			textBox12.Visible=false;
			textBox13.Visible=false;

			listBox2.Visible=false;

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(312, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(296, 56);
			this.label1.TabIndex = 0;
			this.label1.Text = "Inregistrare comanda aprovizionare";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(48, 72);
			this.label2.Name = "label2";
			this.label2.TabIndex = 1;
			this.label2.Text = "Date furnizor:";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(656, 192);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(88, 40);
			this.button2.TabIndex = 29;
			this.button2.Text = "Inregistrare furnizor";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(320, 232);
			this.label8.Name = "label8";
			this.label8.TabIndex = 28;
			this.label8.Text = "Banca:";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(176, 232);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(104, 20);
			this.textBox5.TabIndex = 26;
			this.textBox5.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(48, 232);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(104, 24);
			this.label7.TabIndex = 25;
			this.label7.Text = "Cont bancar:";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(456, 184);
			this.textBox4.Name = "textBox4";
			this.textBox4.TabIndex = 24;
			this.textBox4.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(320, 192);
			this.label6.Name = "label6";
			this.label6.TabIndex = 23;
			this.label6.Text = "Telefon:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(48, 192);
			this.label5.Name = "label5";
			this.label5.TabIndex = 22;
			this.label5.Text = "Localitate";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(176, 192);
			this.textBox3.Name = "textBox3";
			this.textBox3.TabIndex = 21;
			this.textBox3.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(176, 152);
			this.textBox2.Name = "textBox2";
			this.textBox2.TabIndex = 20;
			this.textBox2.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(48, 152);
			this.label4.Name = "label4";
			this.label4.TabIndex = 19;
			this.label4.Text = "Adresa:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(320, 112);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 23);
			this.button1.TabIndex = 18;
			this.button1.Text = "Cautare furnizor";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(176, 112);
			this.textBox1.Name = "textBox1";
			this.textBox1.TabIndex = 17;
			this.textBox1.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(48, 112);
			this.label3.Name = "label3";
			this.label3.TabIndex = 16;
			this.label3.Text = "Nume:";
			// 
			// listBox1
			// 
			this.listBox1.Location = new System.Drawing.Point(-8, 272);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(856, 4);
			this.listBox1.TabIndex = 30;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(48, 296);
			this.label9.Name = "label9";
			this.label9.TabIndex = 31;
			this.label9.Text = "Date produs:";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(48, 336);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(104, 24);
			this.label10.TabIndex = 32;
			this.label10.Text = " Denumire:";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(320, 336);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(104, 23);
			this.button3.TabIndex = 34;
			this.button3.Text = "Cautare produs";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(176, 336);
			this.textBox7.Name = "textBox7";
			this.textBox7.TabIndex = 33;
			this.textBox7.Text = "";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(48, 384);
			this.label11.Name = "label11";
			this.label11.TabIndex = 35;
			this.label11.Text = "Categorie";
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(176, 384);
			this.textBox8.Name = "textBox8";
			this.textBox8.TabIndex = 36;
			this.textBox8.Text = "";
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(448, 384);
			this.textBox9.Name = "textBox9";
			this.textBox9.TabIndex = 37;
			this.textBox9.Text = "";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(320, 384);
			this.label12.Name = "label12";
			this.label12.TabIndex = 38;
			this.label12.Text = "Descriere:";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(320, 432);
			this.label13.Name = "label13";
			this.label13.TabIndex = 39;
			this.label13.Text = "UM:";
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(448, 432);
			this.textBox10.Name = "textBox10";
			this.textBox10.TabIndex = 40;
			this.textBox10.Text = "";
			// 
			// textBox11
			// 
			this.textBox11.Location = new System.Drawing.Point(176, 432);
			this.textBox11.Name = "textBox11";
			this.textBox11.TabIndex = 42;
			this.textBox11.Text = "";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(48, 432);
			this.label14.Name = "label14";
			this.label14.TabIndex = 41;
			this.label14.Text = "Cantitate";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(48, 472);
			this.label15.Name = "label15";
			this.label15.TabIndex = 43;
			this.label15.Text = "Pret achizitie:";
			// 
			// textBox12
			// 
			this.textBox12.Location = new System.Drawing.Point(176, 472);
			this.textBox12.Name = "textBox12";
			this.textBox12.TabIndex = 44;
			this.textBox12.Text = "";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(320, 472);
			this.label16.Name = "label16";
			this.label16.TabIndex = 46;
			this.label16.Text = "Valuta:";
			// 
			// textBox13
			// 
			this.textBox13.Location = new System.Drawing.Point(448, 472);
			this.textBox13.Name = "textBox13";
			this.textBox13.TabIndex = 45;
			this.textBox13.Text = "";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(680, 408);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(80, 40);
			this.button4.TabIndex = 47;
			this.button4.Text = "Adaugare produs";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(704, 616);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(80, 48);
			this.button5.TabIndex = 50;
			this.button5.Text = "Printeaza";
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(704, 544);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(80, 48);
			this.button6.TabIndex = 51;
			this.button6.Text = "inregistrare comanda";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// listBox2
			// 
			this.listBox2.Location = new System.Drawing.Point(56, 536);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(592, 134);
			this.listBox2.TabIndex = 52;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
														   "BCR",
														   "BRD",
														   "Banc Post",
														   "Raiffeisen",
														   "Alpha Bank"});
			this.comboBox1.Location = new System.Drawing.Point(456, 232);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 53;
			// 
			// Intrari
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(848, 734);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.textBox13);
			this.Controls.Add(this.textBox12);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.textBox11);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.textBox10);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.textBox9);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Intrari";
			this.Text = "Intrari";
			this.Load += new System.EventHandler(this.Intrari_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void Intrari_Load(object sender, System.EventArgs e)
		{
		
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if (connection==null || connection.State == ConnectionState.Closed)
			{
				connection = new OleDbConnection();
				string connstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath+"\\firma.mdb;User Id=admin;Password=;";			
				connection.ConnectionString = connstr;
				connection.Open();
			}
			if (textBox1.Text=="")
			{
				MessageBox.Show("Trebuie sa completati campul nume");
			}
			else
			{

				ds = new DataSet();
				cmd = new OleDbCommand();
				cmd.Connection = connection;
				cmd.CommandText = "select * from furnizori where nume='"+textBox1.Text+"'" ;
				da = new OleDbDataAdapter(cmd);
				da.Fill(ds);
				bool este;
				este=false;
				if (ds.Tables[0].Rows.Count!=0)
				{
					este=true;
				}
				label4.Visible=true;
				label5.Visible=true;
				label7.Visible=true;
				textBox2.Visible=true;
				textBox3.Visible=true;
				textBox5.Visible=true;
				label6.Visible=true;
				label8.Visible=true;
				textBox4.Visible=true;
				comboBox1.Visible=true;
	
				if (este)
				{
					MessageBox.Show("Furnizorul a fost gasit in baza de date");
					foreach (DataRow row in ds.Tables[0].Rows)
					{
						textBox2.Text=""+row["adresa"]+"";
						textBox3.Text=""+row["localitate"]+"";
						textBox5.Text=row["cont_bancar"].ToString();
						textBox4.Text=""+row["telefon"]+"";
						comboBox1.Text=""+row["banca"]+"";
						label9.Visible=true;
						label10.Visible=true;
						textBox7.Visible=true;
						button3.Visible=true;
					}
				}
				else
				{
					MessageBox.Show("Furnizorul nu a fost gasit in baza de date. Va rugam introduceti datele necesare");
					button2.Visible=true;
				}
				
			}
			if (connection!=null && (connection.State == ConnectionState.Open || connection.State == ConnectionState.Connecting))
			{
				connection.Close();
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if (connection==null || connection.State == ConnectionState.Closed)
			{
				connection = new OleDbConnection();
				string connstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath+"\\firma.mdb;User Id=admin;Password=;";			
				connection.ConnectionString = connstr;
				connection.Open();
			}
			if ((textBox1.Text=="")|| (textBox2.Text=="")||(textBox3.Text=="")||(textBox4.Text=="")||(textBox5.Text=="")||(comboBox1.Text==""))
			{
				MessageBox.Show("Toate campurile trebuie sa fie completate");
			}
			else
			{

				ds = new DataSet();
				cmd = new OleDbCommand();
				cmd.Connection = connection;
				cmd.CommandText = "Insert into furnizori (nume,adresa,localitate,telefon,cont_bancar,banca) values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"',"+textBox5.Text.ToString()+",'"+comboBox1.Text.ToString()+"')";
				cmd.ExecuteNonQuery();
				MessageBox.Show("Furnizorul a fost inregistrat in baza de date");
				label9.Visible=true;
				label10.Visible=true;
				textBox7.Visible=true;
				button3.Visible=true;
				
			}
			if (connection!=null && (connection.State == ConnectionState.Open || connection.State == ConnectionState.Connecting))
			{
				connection.Close();
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			if (connection==null || connection.State == ConnectionState.Closed)
			{
				connection = new OleDbConnection();
				string connstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath+"\\firma.mdb;User Id=admin;Password=;";			
				connection.ConnectionString = connstr;
				connection.Open();
			}
			if (textBox7.Text=="")
			{
				MessageBox.Show("Completati denumirea produsului");
			}
			else
			{
				ds = new DataSet();
				cmd = new OleDbCommand();
				cmd.Connection = connection;
				cmd.CommandText = "select * from produse where denumire ='"+textBox7.Text+ "'";
				da = new OleDbDataAdapter(cmd);
				da.Fill(ds);
				bool este;
				este=false;
				if (ds.Tables[0].Rows.Count!=0)
				{
					este=true;
				}

				label11.Visible=true;
				label12.Visible=true;
				label13.Visible=true;
				label14.Visible=true;
				label15.Visible=true;
				label16.Visible=true;

				button4.Visible=true;
			
				textBox8.Visible=true;
				textBox9.Visible=true;
				textBox10.Visible=true;
				textBox11.Visible=true;
				textBox12.Visible=true;
				textBox13.Visible=true;

				if (este)
				{
					MessageBox.Show("Produsul a fost gasit in baza de date");
					foreach (DataRow row in ds.Tables[0].Rows)
					{
						textBox8.Text=""+row["grupa"]+"";
						textBox9.Text=""+row["descriere"]+"";
						textBox10.Text=""+row["um"]+"";
						textBox13.Text=""+row["valuta"]+"";
					}
					button4.Visible=true;
				}
				else
				{
					MessageBox.Show("Produsul nu a fost gasit in baza de date. Va rugam introduceti datele necesare");
					button4.Visible=true;
				}
				
			}
			if (connection!=null && (connection.State == ConnectionState.Open || connection.State == ConnectionState.Connecting))
			{
				connection.Close();
			}


		
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			if (connection==null || connection.State == ConnectionState.Closed)
			{
				connection = new OleDbConnection();
				string connstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath+"\\firma.mdb;User Id=admin;Password=;";			
				connection.ConnectionString = connstr;
				connection.Open();
			}
			if ((textBox7.Text=="")||(textBox8.Text=="")||(textBox9.Text=="")||(textBox10.Text=="")||(textBox11.Text=="")||(textBox12.Text=="")||(textBox13.Text==""))
			{
				MessageBox.Show("Toate campurile trebuie sa fie completate");
			}
			else
			{
				ds = new DataSet();
				cmd = new OleDbCommand();
				cmd.Connection = connection;
				cmd.CommandText = "select * from produse where denumire ='"+textBox7.Text+ "'";
				da = new OleDbDataAdapter(cmd);
				da.Fill(ds);
				bool este;
				este=false;
				if (ds.Tables[0].Rows.Count!=0)
				{
					este=true;
				}
				if (!este)
				{
					cmd.CommandText = "Insert into produse (denumire,descriere,cant,um,pret_achizitie,pret_vanzare,valuta,grupa) values('"+textBox7.Text+"','"+textBox9.Text+"',"+textBox11.Text.ToString()+",'"+textBox10.Text+"',"+textBox12.Text.ToString()+","+double.Parse(textBox12.Text)*1.2+",'"+textBox13.Text+"','"+textBox8.Text+"')";
					cmd.ExecuteNonQuery();
					MessageBox.Show("Produsul a fost inregistrat in baza de date");
				}
				else
				{
					foreach (DataRow row in ds.Tables[0].Rows)
					{
						cmd.CommandText = "Update produse set cant=cant+"+row["cant"].ToString()+" where denumire = '"+row["denumire"]+"'";
						cmd.ExecuteNonQuery();
					}
					MessageBox.Show("Datele despre produs au fost actualizate"); 
				}
				if (connection!=null && (connection.State == ConnectionState.Open || connection.State == ConnectionState.Connecting))
				{
					connection.Close();
				}
				listBox2.Visible=true;
				button6.Visible=true;
		
				string obiect="Produs: '"+textBox7.Text+"','"+textBox9.Text+"',"+textBox11.Text.ToString()+",'"+textBox10.Text+"',"+textBox12.Text.ToString()+",'"+textBox13.Text+"','"+textBox8.Text+"'";
				listBox2.Items.Add(obiect); 

			

				valoare = valoare + (double.Parse(textBox12.Text)* double.Parse(textBox11.Text));
            
				textBox8.Text="";
				textBox9.Text="";
				textBox10.Text="";
				textBox11.Text="";
				textBox12.Text="";
				textBox13.Text="";
				textBox7.Text="";

			}
			if (connection!=null && (connection.State == ConnectionState.Open || connection.State == ConnectionState.Connecting))
			{
				connection.Close();
			}
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			if (connection==null || connection.State == ConnectionState.Closed)
		    {
				connection = new OleDbConnection();
				string connstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath+"\\firma.mdb;User Id=admin;Password=;";			
				connection.ConnectionString = connstr;
				connection.Open();
		    }
			if (listBox1.Items.Count==0)
			{
				MessageBox.Show("Nu este nici un produs adaugat in comanda");
			}
			else
			{
				ds = new DataSet();
				cmd = new OleDbCommand();
				cmd.Connection = connection;
				cmd.CommandText = "select * from furnizori where nume='"+textBox1.Text+"'" ;
				da = new OleDbDataAdapter(cmd);
				da.Fill(ds);

				foreach (DataRow row in ds.Tables[0].Rows)
				{
					cmd.CommandText = "Insert into Comenzi_aprovizionare (id_furnizor,data,valoare) values ("+row["id_furnizor"].ToString()+","+DateTime.Now.ToShortDateString()+","+valoare.ToString()+")";
					cmd.ExecuteNonQuery();
					//break;
				}
			}
     		if (connection!=null && (connection.State == ConnectionState.Open || connection.State == ConnectionState.Connecting))
			{
				connection.Close();
			}
			button5.Visible=true;
		}
	}
}
