/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 2/29/2020
 * Time: 3:04 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RandomNumber
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
			Random rand = new Random ();
			int x = rand.Next(100);
			int y = rand.Next(100);
			
			int result = x+y ;
			
			textBox1.Text = x.ToString();
			textBox2.Text = y.ToString();
			textBox3.Text = result.ToString();
		}
	}
}
