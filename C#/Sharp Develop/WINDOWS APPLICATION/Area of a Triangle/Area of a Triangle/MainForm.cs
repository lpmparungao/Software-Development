/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 2/1/2020
 * Time: 12:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Area_of_a_Triangle
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
			float b = Convert.ToInt32(textBox1.Text);
			float h = Convert.ToInt32(textBox2.Text);
			float result = (b*h)/2;
			label4.Text = result.ToString() + "m²";
		}
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			label4.Text= " ";
		}
		void Button3Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

	}
}
