﻿/*
 * Created by SharpDevelop.
 * User: user
 * Date: 10/8/2017
 * Time: 6:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Project001
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Text = "Project001";
			this.Name = "MainForm";
		}
	}
}
