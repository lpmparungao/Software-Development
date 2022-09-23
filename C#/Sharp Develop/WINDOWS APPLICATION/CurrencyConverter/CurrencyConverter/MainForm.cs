/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 2/1/2020
 * Time: 10:28 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CurrencyConverter
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
		void DollarButtonClick(object sender, EventArgs e)
		{
			int x = Convert.ToInt32(textBox1.Text);
			double converted =x * 0.020;
			label3.Text = "$"+converted.ToString();
		}
		
		
		void EuroButtonClick(object sender, EventArgs e)
		{
			int x = Convert.ToInt32(textBox1.Text);
			double converted =x * 0.018;
			label3.Text = "€"+converted.ToString();
		}
		
		
		
		void YenButtonClick(object sender, EventArgs e)
		{
			int x = Convert.ToInt32(textBox1.Text);
			double converted =x * 2.12;
			label3.Text = "¥"+converted.ToString();
		}
		
		
		void RiyalButtonClick(object sender, EventArgs e)
		{
			int x = Convert.ToInt32(textBox1.Text);
			double converted =x * 0.074;
			label3.Text = "SAR "+converted.ToString();
		}
		
		
		void ClearButtonClick(object sender, EventArgs e)
		{
			textBox1.Clear();
			label3.Text = " ";
		}
		
		
		void ExitButtonClick(object sender, EventArgs e)
		{
			Application.Exit();
		}

	}
}
