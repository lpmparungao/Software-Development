/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 2/1/2020
 * Time: 11:28 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Multiply
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
			int x = Convert.ToInt32(textBox1.Text);
			int y = Convert.ToInt32(textBox2.Text);
			int result = x * y;
			label3.Text = result.ToString();
		}
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			label3.Text = "0";
		}
		void Button3Click(object sender, EventArgs e)
		{
			Application.Exit();
		}


	}
}
