/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 2/22/2020
 * Time: 8:13 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Positive_or_negative
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
			int num = Convert.ToInt16(textBox1.Text);
				if (num >= 1)
					MessageBox.Show("It is a Positive number!!!!", "POSorNEG");
				else
					MessageBox.Show("It is an Negative number!!!!", "POSorNEG");
		}
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.Focus();

		}
		void Button3Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}
