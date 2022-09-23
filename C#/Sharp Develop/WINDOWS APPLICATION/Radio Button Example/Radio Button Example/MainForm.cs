/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 2/22/2020
 * Time: 8:59 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Radio_Button_Example
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			{
			if (radioButton1.Checked)
				{
					MessageBox.Show("You selected Football.", "MyFavorite Sport");
				}
			else if (radioButton2.Checked)
				{
				MessageBox.Show("You selected Basketball.", "MyFavorite Sport");
				}
			else if (radioButton3.Checked)
				{
					MessageBox.Show("You selected Baseball.", "My Favorite Sport");
				}
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
