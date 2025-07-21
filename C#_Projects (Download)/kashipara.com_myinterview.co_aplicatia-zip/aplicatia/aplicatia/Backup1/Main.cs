using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using System.Data;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;

namespace Aplicatie
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private OleDbConnection connection;
		private OleDbDataAdapter da,da2,da3,da4,da5,da6,da7,da8,da9;
		private DataSet ds;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.StatusBar statusBar1;
		public System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.ComponentModel.IContainer components;

		public MainForm()
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
				if (components != null) 
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
			this.components = new System.ComponentModel.Container();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.label1 = new System.Windows.Forms.Label();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem9,
																					  this.menuItem5,
																					  this.menuItem8,
																					  this.menuItem3});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.Text = "Inregistrare colaboratori";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 1;
			this.menuItem9.Text = "Inregistrare comanda";
			this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 2;
			this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem7,
																					  this.menuItem6});
			this.menuItem5.Text = "Gestiune stocuri";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 0;
			this.menuItem7.Text = "Inregistrare intrari materiale";
			this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 1;
			this.menuItem6.Text = "Situatie produse";
			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 3;
			this.menuItem8.Text = "Cautari";
			this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 4;
			this.menuItem3.Text = "Exit";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 707);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						  this.statusBarPanel1});
			this.statusBar1.ShowPanels = true;
			this.statusBar1.Size = new System.Drawing.Size(1264, 22);
			this.statusBar1.TabIndex = 0;
			// 
			// statusBarPanel1
			// 
			this.statusBarPanel1.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
			this.statusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.statusBarPanel1.Width = 1248;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.monthCalendar1.Location = new System.Drawing.Point(1080, 0);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.ShowTodayCircle = false;
			this.monthCalendar1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(96, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(208, 40);
			this.label1.TabIndex = 2;
			this.label1.Text = "Structura bazei de date";
			// 
			// treeView1
			// 
			this.treeView1.ImageIndex = -1;
			this.treeView1.Location = new System.Drawing.Point(48, 96);
			this.treeView1.Name = "treeView1";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
																				  new System.Windows.Forms.TreeNode("Firma", new System.Windows.Forms.TreeNode[] {
																																									 new System.Windows.Forms.TreeNode("Clienti", new System.Windows.Forms.TreeNode[] {
																																																														  new System.Windows.Forms.TreeNode("Id"),
																																																														  new System.Windows.Forms.TreeNode("Nume"),
																																																														  new System.Windows.Forms.TreeNode("Adresa"),
																																																														  new System.Windows.Forms.TreeNode("Localitate"),
																																																														  new System.Windows.Forms.TreeNode("Telefon"),
																																																														  new System.Windows.Forms.TreeNode("Cont bancar"),
																																																														  new System.Windows.Forms.TreeNode("Banca")}),
																																									 new System.Windows.Forms.TreeNode("Furnizori", new System.Windows.Forms.TreeNode[] {
																																																															new System.Windows.Forms.TreeNode("Id"),
																																																															new System.Windows.Forms.TreeNode("Nume"),
																																																															new System.Windows.Forms.TreeNode("Adresa"),
																																																															new System.Windows.Forms.TreeNode("Localitate"),
																																																															new System.Windows.Forms.TreeNode("Telefon"),
																																																															new System.Windows.Forms.TreeNode("Cont bancar"),
																																																															new System.Windows.Forms.TreeNode("Banca")}),
																																									 new System.Windows.Forms.TreeNode("Agenti de vanzari", new System.Windows.Forms.TreeNode[] {
																																																																	new System.Windows.Forms.TreeNode("Id"),
																																																																	new System.Windows.Forms.TreeNode("Nume"),
																																																																	new System.Windows.Forms.TreeNode("Adresa"),
																																																																	new System.Windows.Forms.TreeNode("Localitate"),
																																																																	new System.Windows.Forms.TreeNode("Telefon"),
																																																																	new System.Windows.Forms.TreeNode("Cont bancar"),
																																																																	new System.Windows.Forms.TreeNode("Banca")}),
																																									 new System.Windows.Forms.TreeNode("Distribuitori", new System.Windows.Forms.TreeNode[] {
																																																																new System.Windows.Forms.TreeNode("Id"),
																																																																new System.Windows.Forms.TreeNode("Nume"),
																																																																new System.Windows.Forms.TreeNode("Adresa"),
																																																																new System.Windows.Forms.TreeNode("Localitate"),
																																																																new System.Windows.Forms.TreeNode("Telefon"),
																																																																new System.Windows.Forms.TreeNode("Cont bancar"),
																																																																new System.Windows.Forms.TreeNode("Banca")}),
																																									 new System.Windows.Forms.TreeNode("Produse", new System.Windows.Forms.TreeNode[] {
																																																														  new System.Windows.Forms.TreeNode("Id material"),
																																																														  new System.Windows.Forms.TreeNode("Denumire"),
																																																														  new System.Windows.Forms.TreeNode("Descriere"),
																																																														  new System.Windows.Forms.TreeNode("Cantitate"),
																																																														  new System.Windows.Forms.TreeNode("Um"),
																																																														  new System.Windows.Forms.TreeNode("Pret achizitie"),
																																																														  new System.Windows.Forms.TreeNode("Pret vanzare"),
																																																														  new System.Windows.Forms.TreeNode("Valuta"),
																																																														  new System.Windows.Forms.TreeNode("Categorie")}),
																																									 new System.Windows.Forms.TreeNode("Tevi", new System.Windows.Forms.TreeNode[] {
																																																													   new System.Windows.Forms.TreeNode("Id teava"),
																																																													   new System.Windows.Forms.TreeNode("Denumire"),
																																																													   new System.Windows.Forms.TreeNode("Descriere"),
																																																													   new System.Windows.Forms.TreeNode("Cantitate"),
																																																													   new System.Windows.Forms.TreeNode("Um"),
																																																													   new System.Windows.Forms.TreeNode("Pret achizitie"),
																																																													   new System.Windows.Forms.TreeNode("Pret vanzare"),
																																																													   new System.Windows.Forms.TreeNode("Culoare"),
																																																													   new System.Windows.Forms.TreeNode("Categorie")}),
																																									 new System.Windows.Forms.TreeNode("Comenzi aprovizionare", new System.Windows.Forms.TreeNode[] {
																																																																		new System.Windows.Forms.TreeNode("Id comanda"),
																																																																		new System.Windows.Forms.TreeNode("Id furnizor"),
																																																																		new System.Windows.Forms.TreeNode("Data"),
																																																																		new System.Windows.Forms.TreeNode("Valoare")}),
																																									 new System.Windows.Forms.TreeNode("Comenzi vanzare", new System.Windows.Forms.TreeNode[] {
																																																																  new System.Windows.Forms.TreeNode("Id comanda"),
																																																																  new System.Windows.Forms.TreeNode("Id client"),
																																																																  new System.Windows.Forms.TreeNode("Data"),
																																																																  new System.Windows.Forms.TreeNode("Valoare")})})});
			this.treeView1.SelectedImageIndex = -1;
			this.treeView1.Size = new System.Drawing.Size(288, 544);
			this.treeView1.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(584, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(232, 40);
			this.label2.TabIndex = 4;
			this.label2.Text = "Datele din baza de date";
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(384, 96);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(600, 544);
			this.dataGrid1.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(1016, 200);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(208, 48);
			this.label3.TabIndex = 6;
			this.label3.Text = "Calea in care este instalata aplicatia si unde este localizata baza de date:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(1016, 264);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(232, 20);
			this.textBox1.TabIndex = 7;
			this.textBox1.Text = "";
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1264, 729);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.monthCalendar1);
			this.Controls.Add(this.statusBar1);
			this.Menu = this.mainMenu1;
			this.Name = "MainForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{	

			textBox1.Text=Application.StartupPath;
			if (connection==null || connection.State == ConnectionState.Closed)
			{
				connection = new OleDbConnection();
				string connstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath+"\\firma.mdb;User Id=admin;Password=;";			
				connection.ConnectionString = connstr;
				connection.Open();
			}
			if (connection!=null && connection.State == ConnectionState.Open)
			{
				da = new OleDbDataAdapter("select * from furnizori",connection);
				da2 = new OleDbDataAdapter("select * from clienti",connection);
				da3 = new OleDbDataAdapter("select * from distribuitori",connection);
				da4 = new OleDbDataAdapter("select * from agenti_vanzari",connection);
				da5 = new OleDbDataAdapter("select * from produse",connection);
				da6 = new OleDbDataAdapter("select * from comenzi_aprovizionare",connection);
				da7 = new OleDbDataAdapter("select * from comenzi_vanzare",connection);
				da8 = new OleDbDataAdapter("select * from resturi",connection);
				da9 = new OleDbDataAdapter("select * from tevi",connection);
				
				ds = new DataSet();
				da.Fill(ds,"furnizori");
				da2.Fill(ds,"clienti");
				da3.Fill(ds,"distribuitori");
				da4.Fill(ds,"agenti_vanzari");
				da5.Fill(ds,"produse");
				da6.Fill(ds,"comenzi_aprovizionare");
                da7.Fill(ds,"comenzi_vanzare");
				da8.Fill(ds,"resturi");
				da9.Fill(ds,"tevi");


				dataGrid1.DataSource = ds;
				//								
			}
			if (connection!=null && (connection.State == ConnectionState.Open || connection.State == ConnectionState.Connecting))
			{
				connection.Close();
				
			}
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			Comenzi com = new Comenzi();
			//com.MdiParent=this;
			com.Show();
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			Cautari caut = new Cautari();
			caut.Show();
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			Colaboratori colab = new Colaboratori();
			//colab.MdiParent=this;
			colab.Show();
	
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
		Application.Exit();
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			Intrari intr = new Intrari();
			intr.Show();
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			statusBar1.Panels[0].Text=DateTime.Now.ToLongTimeString();
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			Produse prod = new Produse();
			prod.Show();
		}
	}
}
