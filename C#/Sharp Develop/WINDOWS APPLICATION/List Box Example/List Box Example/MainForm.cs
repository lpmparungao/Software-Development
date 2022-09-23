/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 2/22/2020
 * Time: 9:28 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace List_Box_Example
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
	string city;
			if (listBox1.SelectedIndex !=-1)
			{
				city=listBox1.SelectedItem.ToString();
				
				switch (city) 
				{
						case "Honolulu" :
						label3.Text = "Hawaii-Aleutian";
						break;
						case "San Francisco" : 
						label3.Text = "Pacific";
						break;
						case "Denver" : 
						label3.Text = "Mountain"; 
						break;
						case "Minneapolis" : 
						label3.Text = "Central"; 
						break;
						case "New York" : 
						label3.Text = "Eastern"; 
						break;
				}
			}
			else
			{
				MessageBox.Show("Select a City");
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();	
		}
		
	}
}
