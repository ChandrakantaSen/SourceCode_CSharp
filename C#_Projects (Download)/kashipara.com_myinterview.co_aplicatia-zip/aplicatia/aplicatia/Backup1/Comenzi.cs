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
	/// Summary description for Comenzi.
	/// </summary>
	public class Comenzi : System.Windows.Forms.Form
	{
		private OleDbConnection connection;
		private OleDbCommand cmd;
		private OleDbDataAdapter da;
		private DataSet ds,ds1,ds2;
		private bool valabil=false;
		private double valoare=0; 
		private double aux=0;
		private double cantitati=0;
		private double val_tot=0;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private string dePrintat;
			
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Comenzi()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();


						//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Comenzi));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button4 = new System.Windows.Forms.Button();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label16 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label17 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(288, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(288, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Inregistrare comanda";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(48, 64);
			this.label2.Name = "label2";
			this.label2.TabIndex = 1;
			this.label2.Text = "Date Client:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(48, 104);
			this.label3.Name = "label3";
			this.label3.TabIndex = 2;
			this.label3.Text = "Nume:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(176, 104);
			this.textBox1.Name = "textBox1";
			this.textBox1.TabIndex = 3;
			this.textBox1.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(320, 104);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Cautare client";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(48, 144);
			this.label4.Name = "label4";
			this.label4.TabIndex = 5;
			this.label4.Text = "Adresa:";
			this.label4.Visible = false;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(176, 144);
			this.textBox2.Name = "textBox2";
			this.textBox2.TabIndex = 6;
			this.textBox2.Text = "";
			this.textBox2.Visible = false;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(176, 184);
			this.textBox3.Name = "textBox3";
			this.textBox3.TabIndex = 7;
			this.textBox3.Text = "";
			this.textBox3.Visible = false;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(48, 184);
			this.label5.Name = "label5";
			this.label5.TabIndex = 8;
			this.label5.Text = "Localitate";
			this.label5.Visible = false;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(320, 184);
			this.label6.Name = "label6";
			this.label6.TabIndex = 9;
			this.label6.Text = "Telefon:";
			this.label6.Visible = false;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(456, 176);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(104, 20);
			this.textBox4.TabIndex = 10;
			this.textBox4.Text = "";
			this.textBox4.Visible = false;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(48, 224);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(104, 24);
			this.label7.TabIndex = 11;
			this.label7.Text = "Cont bancar:";
			this.label7.Visible = false;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(176, 232);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(104, 20);
			this.textBox5.TabIndex = 12;
			this.textBox5.Text = "";
			this.textBox5.Visible = false;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(320, 224);
			this.label8.Name = "label8";
			this.label8.TabIndex = 14;
			this.label8.Text = "Banca:";
			this.label8.Visible = false;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(640, 192);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(80, 32);
			this.button2.TabIndex = 15;
			this.button2.Text = "Inregistrare client";
			this.button2.Visible = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(48, 296);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(112, 24);
			this.label9.TabIndex = 16;
			this.label9.Text = "Date comanda:";
			this.label9.Visible = false;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(48, 328);
			this.label10.Name = "label10";
			this.label10.TabIndex = 17;
			this.label10.Text = "Categorie produs:";
			this.label10.Visible = false;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
														   "Centrala termica",
														   "Calorifer",
														   "Tub pp cu mufa",
														   "Cot",
														   "Ramificatie",
														   "Reductie ",
														   "Piesa curatire",
														   "Mansou",
														   "Conector ",
														   "Ventil",
														   "Tevi"});
			this.comboBox1.Location = new System.Drawing.Point(48, 368);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 18;
			this.comboBox1.Visible = false;
			this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(224, 328);
			this.label11.Name = "label11";
			this.label11.TabIndex = 19;
			this.label11.Text = "Produse:";
			this.label11.Visible = false;
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.Location = new System.Drawing.Point(216, 368);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 21);
			this.comboBox2.TabIndex = 20;
			this.comboBox2.Visible = false;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(528, 328);
			this.label12.Name = "label12";
			this.label12.TabIndex = 21;
			this.label12.Text = "Cantitate:";
			this.label12.Visible = false;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(384, 368);
			this.textBox7.Name = "textBox7";
			this.textBox7.TabIndex = 22;
			this.textBox7.Text = "";
			this.textBox7.Visible = false;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(680, 328);
			this.label13.Name = "label13";
			this.label13.TabIndex = 23;
			this.label13.Text = "Lungime Tevi:";
			this.label13.Visible = false;
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(528, 368);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(104, 20);
			this.textBox8.TabIndex = 24;
			this.textBox8.Text = "";
			this.textBox8.Visible = false;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(384, 328);
			this.label14.Name = "label14";
			this.label14.TabIndex = 25;
			this.label14.Text = "Pret unitar:";
			this.label14.Visible = false;
			// 
			// listBox1
			// 
			this.listBox1.HorizontalScrollbar = true;
			this.listBox1.Location = new System.Drawing.Point(16, 488);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(584, 108);
			this.listBox1.TabIndex = 28;
			this.listBox1.Visible = false;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(416, 624);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(96, 48);
			this.button4.TabIndex = 29;
			this.button4.Text = "Inregistreaza comanda";
			this.button4.Visible = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// listBox2
			// 
			this.listBox2.Location = new System.Drawing.Point(0, 280);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(848, 4);
			this.listBox2.TabIndex = 30;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(752, 624);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(88, 32);
			this.button5.TabIndex = 31;
			this.button5.Text = "Print";
			this.button5.Visible = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(232, 440);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(96, 32);
			this.button6.TabIndex = 32;
			this.button6.Text = "Adauga produs";
			this.button6.Visible = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox10);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Location = new System.Drawing.Point(624, 440);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(224, 128);
			this.groupBox1.TabIndex = 34;
			this.groupBox1.TabStop = false;
			this.groupBox1.Visible = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(8, 72);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(64, 23);
			this.label16.TabIndex = 2;
			this.label16.Text = "Nume:";
			this.label16.Visible = false;
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(24, 24);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(192, 40);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Comanda primita de la distribuitor";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// comboBox3
			// 
			this.comboBox3.Items.AddRange(new object[] {
														   "BCR",
														   "BRD",
														   "Banc Post",
														   "Raiffeisen",
														   "Alpha Bank"});
			this.comboBox3.Location = new System.Drawing.Point(456, 224);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(121, 21);
			this.comboBox3.TabIndex = 35;
			this.comboBox3.Visible = false;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(672, 368);
			this.numericUpDown1.Maximum = new System.Decimal(new int[] {
																		   20,
																		   0,
																		   0,
																		   0});
			this.numericUpDown1.Minimum = new System.Decimal(new int[] {
																		   4,
																		   0,
																		   0,
																		   0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.TabIndex = 36;
			this.numericUpDown1.Value = new System.Decimal(new int[] {
																		 4,
																		 0,
																		 0,
																		 0});
			this.numericUpDown1.Visible = false;
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(32, 640);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(136, 24);
			this.label17.TabIndex = 37;
			this.label17.Text = "Valoare factura actuala:";
			this.label17.Visible = false;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(200, 640);
			this.textBox6.Name = "textBox6";
			this.textBox6.TabIndex = 38;
			this.textBox6.Text = "";
			this.textBox6.Visible = false;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(648, 624);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(80, 32);
			this.button3.TabIndex = 39;
			this.button3.Text = "Print Preview";
			this.button3.Click += new System.EventHandler(this.button3_Click_1);
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(96, 72);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(112, 20);
			this.textBox10.TabIndex = 3;
			this.textBox10.Text = "";
			this.textBox10.Visible = false;
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Document = this.printDocument1;
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Location = new System.Drawing.Point(22, 29);
			this.printPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
			this.printPreviewDialog1.Visible = false;
			// 
			// printDialog1
			// 
			this.printDialog1.Document = this.printDocument1;
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// Comenzi
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(864, 702);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
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
			this.Name = "Comenzi";
			this.Text = "Comenzi";
			this.Load += new System.EventHandler(this.Comenzi_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Comenzi_Load(object sender, System.EventArgs e)
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
				MessageBox.Show("Completati numele clientului");
			}
			else
			{
				ds = new DataSet();
				cmd = new OleDbCommand();
				cmd.Connection = connection;
				cmd.CommandText = "select * from clienti where nume='"+textBox1.Text+"'" ;
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
				label6.Visible=true;
				label7.Visible=true;
				label8.Visible=true;
				textBox2.Visible=true;
				textBox3.Visible=true;
				textBox4.Visible=true;
				textBox5.Visible=true;
				comboBox3.Visible=true;
			
				if (este)
				{
					MessageBox.Show("Clientul fost gasit in baza de date");
					foreach (DataRow row in ds.Tables[0].Rows)
					{
						textBox2.Text=""+row["adresa"]+"";
						textBox3.Text=""+row["localitate"]+"";
						textBox5.Text=row["cont_bancar"].ToString();
						textBox4.Text=""+row["telefon"]+"";
						comboBox3.Text=""+row["banca"]+"";	
					}
					button2.Visible=false;
					label9.Visible=true;
					label10.Visible=true;
					label11.Visible=true;
					label12.Visible=true;
					label14.Visible=true;
					comboBox1.Visible=true;
					comboBox2.Visible=true;
					textBox7.Visible=true;
					textBox8.Visible=true;
					button6.Visible=true;
					groupBox1.Visible=true;
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
			if ((textBox1.Text=="")||(textBox2.Text=="")||(textBox3.Text=="")||(textBox4.Text=="")||(textBox5.Text=="")||(comboBox3.Text==""))
			{
				MessageBox.Show("Toate campurile trebuie sa fie completate");
			}
			else
			{
				ds = new DataSet();
				cmd = new OleDbCommand();
				cmd.Connection = connection;
				cmd.CommandText = "Insert into clienti (nume,adresa,localitate,telefon,cont_bancar,banca) values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"',"+textBox5.Text.ToString()+",'"+comboBox1.Text.ToString()+"')";
				cmd.ExecuteNonQuery();
				MessageBox.Show("Furnizorul a fost inregistrat in baza de date");

				label9.Visible=true;
				label10.Visible=true;
				label11.Visible=true;
				label12.Visible=true;
				label14.Visible=true;
				comboBox1.Visible=true;
				comboBox2.Visible=true;
				textBox7.Visible=true;
				textBox8.Visible=true;
				button6.Visible=true;
				groupBox1.Visible=true;
			}
			if (connection!=null && (connection.State == ConnectionState.Open || connection.State == ConnectionState.Connecting))
			{
				connection.Close();
			}
		}

		private void comboBox1_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			comboBox2.Items.Clear();
			textBox7.Text="";
			textBox8.Text="";
			numericUpDown1.Value=4;
			if (connection==null || connection.State == ConnectionState.Closed)
			{
				connection = new OleDbConnection();
				string connstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath+"\\firma.mdb;User Id=admin;Password=;";			
				connection.ConnectionString = connstr;
				connection.Open();
			}
			ds = new DataSet();
			cmd = new OleDbCommand();
			cmd.Connection = connection;
			if (comboBox1.Text.ToString()=="Tevi")
			{
				cmd.CommandText = "Select * from tevi";
				da = new OleDbDataAdapter(cmd);
				da.Fill(ds);
				foreach (DataRow row in ds.Tables[0].Rows)
				{
					comboBox2.Items.Add(row["denumire"]);

				}
				
				label13.Visible=true;
				numericUpDown1.Visible=true;
			}
			else
			{
				cmd.CommandText = "Select * from produse where grupa='"+comboBox1.Text+"'";
				da = new OleDbDataAdapter(cmd);
				da.Fill(ds);
				foreach (DataRow row in ds.Tables[0].Rows)
				{
					comboBox2.Items.Add(row["denumire"]);

				}
				label13.Visible=false;
				numericUpDown1.Visible=false;
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
			ds = new DataSet();
			ds1 = new DataSet();
			ds2 = new DataSet();
			cmd = new OleDbCommand();
			cmd.Connection = connection;
			//pentru tevi
			if (comboBox1.Text.ToString()=="Tevi")
			{
				if (numericUpDown1.Value==20)
				{
					cmd.CommandText = "Select * from tevi where denumire='"+comboBox2.Text+"'";
					da = new OleDbDataAdapter(cmd);
					da.Fill(ds);
					foreach (DataRow row in ds.Tables[0].Rows)
					{
						if (Double.Parse(textBox8.Text.ToString())<=Double.Parse(row["cant"].ToString()))
						{
							cantitati=Double.Parse(textBox8.Text.ToString())-Double.Parse(row["cant"].ToString());
							MessageBox.Show("Produsul este disponibil in cantitatea solicitata");
							cmd.CommandText="Update tevi set cant="+cantitati+" where denumire='"+comboBox2.Text+"'";
							
						}
						else 
						{
							MessageBox.Show("Produsul nu este disponibil in cantitatea solicitata");
							textBox8.Text="";
							valabil=false;
								
						}
					}
				}
				else 
				{
					cmd.CommandText = "Select * from tevi where denumire='"+comboBox2.Text+"'";
					da = new OleDbDataAdapter(cmd);
					da.Fill(ds);
					valoare=0;
					foreach (DataRow row in ds.Tables[0].Rows)
					{
						valoare=double.Parse(row["id_teava"].ToString());
						cantitati=double.Parse(row["cant"].ToString());
					}
					cmd.CommandText="Select * from resturi where id_teava="+valoare.ToString();
					da = new OleDbDataAdapter(cmd);
					da.Fill(ds1);
					double nr_buc=0;
					double lung=0;
					lung=double.Parse(numericUpDown1.Value.ToString());
					nr_buc=double.Parse(textBox8.Text.ToString());
					foreach (DataRow row in ds1.Tables[0].Rows)
					{
						aux=Convert.ToDouble(row["lungime"].ToString());
						
						if((aux-lung>=0)&&(nr_buc>0))
						{
						
							while( ((aux-lung)>0)&&(nr_buc>0))
							{
								nr_buc=nr_buc-1;
								aux=aux-lung;
							}
							cmd.CommandText="Update resturi set lungime="+aux.ToString()+" where nr_ordine="+row["nr_ordine"].ToString();
							cmd.ExecuteNonQuery();
						}
					}
					
					if (nr_buc==0)
					{
						//MessageBox.Show("Produsul este disponibil in cantitea solicitata");
					    valabil=true;  
						
					}
					else
					{
						cmd.CommandText = "Select * from tevi where denumire='"+comboBox2.Text+"'";
						da = new OleDbDataAdapter(cmd);
						da.Fill(ds2);
						double cate=0;
						double[] aux2= new double[10];
						int i=0;
						foreach (DataRow row in ds2.Tables[0].Rows)
						{
							cate=double.Parse(row["cant"].ToString());
							while((cate>0)&&(nr_buc>0))
							{
								i=i+1;
								aux2[i]=20;
								cate=cate-1;
								while( ((aux2[i]-lung)>0)&&(nr_buc>0))
								{
									nr_buc=nr_buc-1;
									aux2[i]=aux2[i]-lung;
								}
							}
						}
						if (nr_buc==0)
						{
							for (int j=1; j<=i;j++)
							{
								if (aux2[j]>=4)
								{
									
									cmd.CommandText="Insert into resturi (id_teava,lungime) values ("+valoare.ToString()+","+aux2[j].ToString()+")";
									cmd.ExecuteNonQuery();
									
								}
							}

							//MessageBox.Show("Produsul este disponibil in cantitea solicitata");
							cmd.CommandText="Update tevi set cant="+cate.ToString()+" where id_teava="+valoare.ToString();
							cmd.ExecuteNonQuery();
							valabil=true;
							
						}
						else
						{
							MessageBox.Show("Produsul nu este disponibil in cantitea solicitata");
							valabil=false;
						}
					}
					cmd.CommandText="Delete * from resturi where lungime<4";
					cmd.ExecuteNonQuery();		
				}
			}
            //pentru produse
			else
			{
				cmd.CommandText = "Select * from produse where grupa='"+comboBox1.Text+"' and denumire='"+comboBox2.Text+"'";
				da = new OleDbDataAdapter(cmd);
				da.Fill(ds);
				foreach (DataRow row in ds.Tables[0].Rows)
				{
					if (Double.Parse(textBox8.Text)<=Double.Parse(row["cant"].ToString()))
					{
						cantitati=Double.Parse(textBox8.Text)-Double.Parse(row["cant"].ToString());
						//MessageBox.Show("Produsul este disponibil in cantitatea solicitata");
						cmd.CommandText="Update produse set cant="+cantitati+" where denumire='"+comboBox2.Text+"'";
					   valabil=true;
					}
					else 
					{
						MessageBox.Show("Produsul nu este disponibil in cantitatea solicitata");
						textBox8.Text="";
						valabil=false;
							
					}
				}	

			}
			if (connection!=null && (connection.State == ConnectionState.Open || connection.State == ConnectionState.Connecting))
			{
				connection.Close();
			}

			//actualizare val

			if (valabil)
			{
				
				listBox1.Visible=true;
				label17.Visible=true;
				textBox6.Visible=true;
				MessageBox.Show("Produsul a fost inregistrat");

				if (comboBox1.Text.ToString()=="Tevi")
				{
					if (connection==null || connection.State == ConnectionState.Closed)
					{
						connection = new OleDbConnection();
						string connstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath+"\\firma.mdb;User Id=admin;Password=;";			
						connection.ConnectionString = connstr;
						connection.Open();
					}
					double aux3=0;
					ds = new DataSet();
					cmd = new OleDbCommand();
					cmd.Connection = connection;
					cmd.CommandText = "Select * from tevi where denumire='"+comboBox2.Text+"'";
					da = new OleDbDataAdapter(cmd);
					da.Fill(ds);
					valoare=0;
					foreach (DataRow row in ds.Tables[0].Rows)
					{
						valoare=(double.Parse(row["pret_vanzare"].ToString())/20)*double.Parse(numericUpDown1.Value.ToString())*double.Parse(textBox8.Text.ToString());
						//textBox7.Text=valoare.ToString();
					}

					if (connection!=null && (connection.State == ConnectionState.Open || connection.State == ConnectionState.Connecting))
					{
						connection.Close();
					}
					val_tot=val_tot+double.Parse(valoare.ToString());
    			
                    string obiect="Produs: '"+comboBox2.Text+"', din categoria:'"+comboBox1.Text+"',cantitate: "+textBox8.Text.ToString()+",lungime tevi: "+numericUpDown1.Value.ToString()+",la pretul de vanzare: "+textBox7.Text.ToString()+",  valoare totala:"+valoare.ToString();
					
					if (listBox1.Items.Count==0)
					{
							dePrintat="Incheiere Tranzactie \n \n \n"+"Nume client:"+textBox1.Text.ToString()+"\n Adresa client: "+textBox2.Text.ToString()+"\n Localitate: "+textBox3.Text.ToString()+
										"\n Telefon: "+textBox4.Text.ToString()+"\n  Cont bancar: "+textBox5.Text.ToString()+"\n Banca: "+comboBox3.Text.ToString()+"\n \n"+listBox1.Items.ToString()+"\n";
			
					}
					listBox1.Items.Add(obiect); 
				    dePrintat=dePrintat+"\n"+obiect;
					textBox6.Text=val_tot.ToString();
				}
				else
				{	
					valoare=0;
					valoare=double.Parse(textBox7.Text.ToString())*double.Parse(textBox8.Text.ToString());
					val_tot=val_tot+double.Parse(valoare.ToString());
					string obiect="Produs: '"+comboBox2.Text+"',   din categoria:'"+comboBox1.Text+"',   cantitate: "+textBox8.Text.ToString()+",   la pretul de vanzare: "+textBox7.Text.ToString()+",  valoare totala:"+valoare.ToString();
					listBox1.Items.Add(obiect); 
					textBox6.Text=val_tot.ToString();
				}
			
				button4.Visible=true;
				button5.Visible=true;
			
				comboBox1.Text="";
				comboBox2.Text="";
				textBox7.Text="";
				textBox8.Text="";
				numericUpDown1.Value=4;
				numericUpDown1.Visible=false;
				label13.Visible=false;
			}
			
		}

		private void comboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			textBox7.Text="";
			if (connection==null || connection.State == ConnectionState.Closed)
			{
				connection = new OleDbConnection();
				string connstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath+"\\firma.mdb;User Id=admin;Password=;";			
				connection.ConnectionString = connstr;
				connection.Open();
			}
			ds = new DataSet();
			cmd = new OleDbCommand();
			cmd.Connection = connection;
			if (comboBox1.Text.ToString()=="Tevi")
			{
                label13.Visible=true;
				numericUpDown1.Visible=true;
				cmd.CommandText = "Select * from tevi where denumire='"+comboBox2.Text+"'";
				da = new OleDbDataAdapter(cmd);
				da.Fill(ds);
				foreach (DataRow row in ds.Tables[0].Rows)
				{
					textBox7.Text=row["pret_vanzare"].ToString();
				}
			}
			else
			{
				cmd.CommandText = "Select * from produse where denumire='"+comboBox2.Text+"'";
				da = new OleDbDataAdapter(cmd);
				da.Fill(ds);
				foreach (DataRow row in ds.Tables[0].Rows)
				{
					textBox7.Text=row["pret_vanzare"].ToString();
				}
			}
			if (connection!=null && (connection.State == ConnectionState.Open || connection.State == ConnectionState.Connecting))
			{
				connection.Close();
			}
		
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			
			
		}

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
		{
    	}

		private void button4_Click(object sender, System.EventArgs e)
		{
			double id_distribuitor=0;
			double id_client=0;
			if (connection==null || connection.State == ConnectionState.Closed)
			{
				connection = new OleDbConnection();
				string connstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath+"\\firma.mdb;User Id=admin;Password=;";			
				connection.ConnectionString = connstr;
				connection.Open();
			}
			ds = new DataSet();
			ds2= new DataSet();
			cmd = new OleDbCommand();
			cmd.Connection = connection;
			bool poate=false;
			if (listBox1.Items.Count==0)
			{
				MessageBox.Show("Nu este nici un produs adaugat in comanda");
			}
			else
			{
				
				if (checkBox1.Checked==true)
				{
					if (textBox10.Text=="")
					{
						MessageBox.Show("Completati numele distribuitorului");
						poate=false;
					}
					else 
					{
						cmd.CommandText="select * from distribuitori where nume='"+textBox10.Text+"'" ;
						poate=true;
						da = new OleDbDataAdapter(cmd);
						da.Fill(ds);
						id_distribuitor=0;
						foreach (DataRow row in ds.Tables[0].Rows)
						{
							id_distribuitor=double.Parse(row["id"].ToString());
						
						}
						if (id_distribuitor==0)
						{
							MessageBox.Show("Distribuitorul nu a fost gasit in baza de date");
						}
						else
						{
							cmd.CommandText="select * from clienti where nume='"+textBox1.Text+"'";
							da = new OleDbDataAdapter(cmd);
							da.Fill(ds2);
							foreach (DataRow row in ds2.Tables[0].Rows)
							{
								id_client=double.Parse(row["id_client"].ToString());
						
							}
							cmd.CommandText = "Insert into Comenzi_distribuitori(id_distribuitor,id_client,data,valoare) values ("+id_distribuitor.ToString()+","+id_client.ToString()+","+DateTime.Now.ToShortDateString()+","+val_tot.ToString()+")";
							cmd.ExecuteNonQuery();
							MessageBox.Show("Comanda dumneavoastra a fost inregistrata");
						}
					}
				}
				else 
				{
					cmd.CommandText="select * from clienti where nume='"+textBox1.Text+"'";
					da = new OleDbDataAdapter(cmd);
					da.Fill(ds);
					foreach (DataRow row in ds.Tables[0].Rows)
					{
						id_client=double.Parse(row["id_client"].ToString());
						
					}
					cmd.CommandText = "Insert into Comenzi_vanzare(id_client,data,valoare) values ("+id_client.ToString()+","+DateTime.Now.ToShortDateString()+","+val_tot.ToString()+")";
					cmd.ExecuteNonQuery();
					MessageBox.Show("Comanda dumneavoastra a fost inregistrata");
				}
			}
			if (connection!=null && (connection.State == ConnectionState.Open || connection.State == ConnectionState.Connecting))
			{
				connection.Close();
			}
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if (checkBox1.Checked==true)
			{
				label16.Visible=true;
				textBox10.Visible=true;
			}
			else
			{
				label16.Visible=false;
				textBox10.Visible=false;
			}

		}

		private void groupBox1_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void button3_Click_1(object sender, System.EventArgs e)
		{
			printPreviewDialog1.ShowDialog();
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
                e.Graphics.DrawString(dePrintat,new Font("Arial",12), new SolidBrush(Color.Black), printDocument1.DefaultPageSettings.Margins.Left,
				printDocument1.DefaultPageSettings.Margins.Top);
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			printDocument1.Print();
		}
	}
}
