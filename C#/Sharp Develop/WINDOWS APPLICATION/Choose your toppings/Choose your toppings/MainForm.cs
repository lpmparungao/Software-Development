/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 2/22/2020
 * Time: 9:13 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Choose_your_toppings
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
			if (checkBox1.Checked)
			{
				MessageBox.Show("You selected Pepperoni" , "My Toppings");
			}
			if (checkBox2.Checked)
			{
				MessageBox.Show("You selected Cheese.", "My Toppings");
			}
			if (checkBox3.Checked)
			{
				MessageBox.Show("You selected Anchovies.", "My Toppings");
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
				this.Close();
		}
	}
}
