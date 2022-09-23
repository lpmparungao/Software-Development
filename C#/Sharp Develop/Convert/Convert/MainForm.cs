/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 2/29/2020
 * Time: 3:25 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Convert
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


			
			//input in.
			if ( textBox1.Text != "")
			{
			
			string input, output;
			input = listBox1.Text;
			output = listBox2.Text;
			double x = double.Parse( textBox1.Text);
			double result;
			
			if (input == "in." && output == "in.")
			{
				result= x;
				textBox2.Text = result.ToString();
			}
			

			
			if (input == "in." && output == "ft.")
			{
				result= x * 0.083;
				textBox2.Text = result.ToString();
			}
			
			
			if (input == "in." && output == "yd.")
			{
				result= x * 0.028;
				textBox2.Text = result.ToString();
			}

			
			//input ft.
			
			if (input == "ft." && output == "in.")
			{
				result= x*12;
				textBox2.Text = result.ToString();
			}
			
			
			
			if (input == "ft." && output == "ft.")
			{
				result= x;
				textBox2.Text = result.ToString();
			}

			
			
			if (input == "ft." && output == "yd.")
			{
				result= x * 0.33;
				textBox2.Text = result.ToString();
			}
			
			
			// input yd.
			
			if (input == "yd." && output == "in.")
			{
				result= x * 36;
				textBox2.Text = result.ToString();
			}

			
			if (input == "yd." && output == "ft.")
			{
				result= x * 3;
				textBox2.Text = result.ToString();
			}

			
			if (input == "yd." && output == "yd.")
			{
				result= x ;
				textBox2.Text = result.ToString();
			}			
	
			
			if (input == "" || output == "" ) 
			{
				MessageBox.Show("Please select unit", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}		
			}
			
			else 
			{
				MessageBox.Show("Please enter a value", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
}
