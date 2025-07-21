/*
 * Created by SharpDevelop.
 * User: user
 * Date: 10/8/2017
 * Time: 6:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Project001
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class UserPage : Form
	{
		public UserPage()
		{
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void UserPage_Load(object sender, EventArgs e)
		{
			IsMdiContainer = true;
		}
	}
}
