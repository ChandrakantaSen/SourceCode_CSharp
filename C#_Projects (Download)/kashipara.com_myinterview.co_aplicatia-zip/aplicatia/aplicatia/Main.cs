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
        private MenuItem menuItem2;
        private MenuItem menuItem10;
        private MenuItem menuItem4;
        private MenuItem menuItem11;
        private MenuItem menuItem8;
        private MenuItem menuItem12;
        private MenuItem menuItem13;
        private MenuItem menuItem14;
		private System.ComponentModel.IContainer components;

		

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		public void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Id");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nume");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Adresa");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Localitate");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Telefon");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Cont bancar");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Banca");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Clienti", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Id");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Nume");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Adresa");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Localitate");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Telefon");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Cont bancar");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Banca");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Furnizori", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Id");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Nume");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Adresa");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Localitate");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Telefon");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Cont bancar");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Banca");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Agenti de vanzari", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Id");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Nume");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Adresa");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Localitate");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Telefon");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Cont bancar");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Banca");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Distribuitori", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31});
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Id material");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Denumire");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Descriere");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Cantitate");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Um");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Pret achizitie");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Pret vanzare");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Valuta");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Categorie");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Produse", new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode34,
            treeNode35,
            treeNode36,
            treeNode37,
            treeNode38,
            treeNode39,
            treeNode40,
            treeNode41});
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Id teava");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Denumire");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Descriere");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Cantitate");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Um");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Pret achizitie");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Pret vanzare");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Culoare");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Categorie");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Tevi", new System.Windows.Forms.TreeNode[] {
            treeNode43,
            treeNode44,
            treeNode45,
            treeNode46,
            treeNode47,
            treeNode48,
            treeNode49,
            treeNode50,
            treeNode51});
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Id comanda");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Id furnizor");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Data");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("Valoare");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("Comenzi aprovizionare", new System.Windows.Forms.TreeNode[] {
            treeNode53,
            treeNode54,
            treeNode55,
            treeNode56});
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("Id comanda");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("Id client");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Data");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("Valoare");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("Comenzi vanzare", new System.Windows.Forms.TreeNode[] {
            treeNode58,
            treeNode59,
            treeNode60,
            treeNode61});
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Firma", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode16,
            treeNode24,
            treeNode32,
            treeNode42,
            treeNode52,
            treeNode57,
            treeNode62});
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
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
            this.menuItem3,
            this.menuItem12});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem8});
            this.menuItem1.Text = "Colaboratori";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 0;
            this.menuItem8.Text = "Adaugare";
            this.menuItem8.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 1;
            this.menuItem9.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem4});
            this.menuItem9.Text = "Comenzi";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem10});
            this.menuItem2.Text = "Distribuire";
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 0;
            this.menuItem10.Text = "Adaugare";
            this.menuItem10.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem11});
            this.menuItem4.Text = "Aprovizionare";
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 0;
            this.menuItem11.Text = "Adaugare";
            this.menuItem11.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 2;
            this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem7,
            this.menuItem6});
            this.menuItem5.Text = "Gestiune stocuri";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 0;
            this.menuItem7.Text = "Cautari";
            this.menuItem7.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.Text = "Situatie produse";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 3;
            this.menuItem3.Text = "Exit";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 4;
            this.menuItem12.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem13,
            this.menuItem14});
            this.menuItem12.Text = "Administrare";
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 0;
            this.menuItem13.Text = "Delogare";
            this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 1;
            this.menuItem14.Text = "Adaugare User";
            this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click);
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
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Width = 1247;
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
            this.monthCalendar1.Location = new System.Drawing.Point(1019, 75);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Structura bazei de date";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(48, 96);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "";
            treeNode1.Text = "Id";
            treeNode2.Name = "";
            treeNode2.Text = "Nume";
            treeNode3.Name = "";
            treeNode3.Text = "Adresa";
            treeNode4.Name = "";
            treeNode4.Text = "Localitate";
            treeNode5.Name = "";
            treeNode5.Text = "Telefon";
            treeNode6.Name = "";
            treeNode6.Text = "Cont bancar";
            treeNode7.Name = "";
            treeNode7.Text = "Banca";
            treeNode8.Name = "";
            treeNode8.Text = "Clienti";
            treeNode9.Name = "";
            treeNode9.Text = "Id";
            treeNode10.Name = "";
            treeNode10.Text = "Nume";
            treeNode11.Name = "";
            treeNode11.Text = "Adresa";
            treeNode12.Name = "";
            treeNode12.Text = "Localitate";
            treeNode13.Name = "";
            treeNode13.Text = "Telefon";
            treeNode14.Name = "";
            treeNode14.Text = "Cont bancar";
            treeNode15.Name = "";
            treeNode15.Text = "Banca";
            treeNode16.Name = "";
            treeNode16.Text = "Furnizori";
            treeNode17.Name = "";
            treeNode17.Text = "Id";
            treeNode18.Name = "";
            treeNode18.Text = "Nume";
            treeNode19.Name = "";
            treeNode19.Text = "Adresa";
            treeNode20.Name = "";
            treeNode20.Text = "Localitate";
            treeNode21.Name = "";
            treeNode21.Text = "Telefon";
            treeNode22.Name = "";
            treeNode22.Text = "Cont bancar";
            treeNode23.Name = "";
            treeNode23.Text = "Banca";
            treeNode24.Name = "";
            treeNode24.Text = "Agenti de vanzari";
            treeNode25.Name = "";
            treeNode25.Text = "Id";
            treeNode26.Name = "";
            treeNode26.Text = "Nume";
            treeNode27.Name = "";
            treeNode27.Text = "Adresa";
            treeNode28.Name = "";
            treeNode28.Text = "Localitate";
            treeNode29.Name = "";
            treeNode29.Text = "Telefon";
            treeNode30.Name = "";
            treeNode30.Text = "Cont bancar";
            treeNode31.Name = "";
            treeNode31.Text = "Banca";
            treeNode32.Name = "";
            treeNode32.Text = "Distribuitori";
            treeNode33.Name = "";
            treeNode33.Text = "Id material";
            treeNode34.Name = "";
            treeNode34.Text = "Denumire";
            treeNode35.Name = "";
            treeNode35.Text = "Descriere";
            treeNode36.Name = "";
            treeNode36.Text = "Cantitate";
            treeNode37.Name = "";
            treeNode37.Text = "Um";
            treeNode38.Name = "";
            treeNode38.Text = "Pret achizitie";
            treeNode39.Name = "";
            treeNode39.Text = "Pret vanzare";
            treeNode40.Name = "";
            treeNode40.Text = "Valuta";
            treeNode41.Name = "";
            treeNode41.Text = "Categorie";
            treeNode42.Name = "";
            treeNode42.Text = "Produse";
            treeNode43.Name = "";
            treeNode43.Text = "Id teava";
            treeNode44.Name = "";
            treeNode44.Text = "Denumire";
            treeNode45.Name = "";
            treeNode45.Text = "Descriere";
            treeNode46.Name = "";
            treeNode46.Text = "Cantitate";
            treeNode47.Name = "";
            treeNode47.Text = "Um";
            treeNode48.Name = "";
            treeNode48.Text = "Pret achizitie";
            treeNode49.Name = "";
            treeNode49.Text = "Pret vanzare";
            treeNode50.Name = "";
            treeNode50.Text = "Culoare";
            treeNode51.Name = "";
            treeNode51.Text = "Categorie";
            treeNode52.Name = "";
            treeNode52.Text = "Tevi";
            treeNode53.Name = "";
            treeNode53.Text = "Id comanda";
            treeNode54.Name = "";
            treeNode54.Text = "Id furnizor";
            treeNode55.Name = "";
            treeNode55.Text = "Data";
            treeNode56.Name = "";
            treeNode56.Text = "Valoare";
            treeNode57.Name = "";
            treeNode57.Text = "Comenzi aprovizionare";
            treeNode58.Name = "";
            treeNode58.Text = "Id comanda";
            treeNode59.Name = "";
            treeNode59.Text = "Id client";
            treeNode60.Name = "";
            treeNode60.Text = "Data";
            treeNode61.Name = "";
            treeNode61.Text = "Valoare";
            treeNode62.Name = "";
            treeNode62.Text = "Comenzi vanzare";
            treeNode63.Name = "";
            treeNode63.Text = "Firma";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode63});
            this.treeView1.Size = new System.Drawing.Size(288, 544);
            this.treeView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackgroundImage = global::Aplicatie.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 729);
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
			Application.Run(new Flash());
		}
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
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
		private void MainForm_Load(object sender, System.EventArgs e)
		{	

			
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
		this.Close();
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

        private void menuItem5_Click(object sender, EventArgs e)
        {

        }

        private void menuItem13_Click(object sender, EventArgs e)
        {
            Autentificare a = new Autentificare();
            a.Show();
            this.Close();
        }

        private void Exit()
        {
            throw new NotImplementedException();
        }

        private void menuItem14_Click(object sender, EventArgs e)
        {
            Useri us = new Useri();
            us.Show();
        }
	}
}
