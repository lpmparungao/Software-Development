/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 2/1/2020
 * Time: 12:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Arithmetic_Works
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
	        double x = Convert.ToInt32(textBox1.Text);
            double y = Convert.ToInt32(textBox2.Text);
            double answer = x + y;
            label4.Text = answer.ToString();

		}
		void Button2Click(object sender, EventArgs e)
		{
			double x = Convert.ToInt32(textBox1.Text);
            double y = Convert.ToInt32(textBox2.Text);
            double answer = x * y;
            label4.Text = answer.ToString();
		}
		void Button3Click(object sender, EventArgs e)
		{
			textBox1.Clear();
            textBox2.Clear();
            label4.Text = " ";
		}
		void Button4Click(object sender, EventArgs e)
		{
			Application.Exit();	
		}
	}
}
