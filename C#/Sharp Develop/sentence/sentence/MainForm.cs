/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 2/29/2020
 * Time: 6:25 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace sentence
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
		string output;
		
		void Button1Click(object sender, EventArgs e)
		{
			output = "a";
			textBox1.Text += output;
		}
		void Button2Click(object sender, EventArgs e)
		{
			output = "b";
			textBox1.Text += output;
		}
	}
}
