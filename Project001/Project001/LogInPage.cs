using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project001
{
	public partial class LogInPage : Form
	{
		public static string userType = "";
		public static string userName = "";
		public static string userPwd  = "";
		
		public LogInPage()
		{
			InitializeComponent();
		}
		
		void LogInPage_Load(object sender, EventArgs e)
		{
			//Set focus on -- Login Button
			this.ActiveControl = Btn_Submit;
		}
		
		void Btn_Submit_Click(object sender, EventArgs e)
		{
			//Declare variables
			userType = Drp_UserType.Text.ToString();
			userName = Txt_UserName.Text.ToString();
			userPwd  = Txt_Password.Text.ToString();
			
			//Create object to Login Page
			HomePage homeObj = new HomePage();
			
			//Check LogIn Credentials
			if (userType == "Administrator")
			{
				if (userName == "admin" && userPwd == "Cisco001") 
				{
					this.Hide();
					homeObj.Show();
				}				
			}			
		}
		
		void Btn_Clear_Click(object sender, EventArgs e)
		{
			Drp_UserType.Text = "";
			Txt_UserName.Text = "";
			Txt_Password.Text = "";
		}
	}
}
