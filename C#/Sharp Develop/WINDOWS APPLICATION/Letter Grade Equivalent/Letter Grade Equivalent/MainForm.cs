/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 2/22/2020
 * Time: 8:23 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Letter_Grade_Equivalent
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
			int grade = Convert.ToInt16(textBox1.Text);
				if (grade >= 90)
					textBox2.Text="A";
				else if ((grade>=80) && (grade<=89))
					textBox2.Text="B";
				else if ((grade>= 70) && (grade <=79))
					textBox2.Text="C";
				else if ((grade>=60) && (grade<=69))
					textBox2.Text="D";
				else if (grade<60)
					textBox2.Text = "F" ;
		}
		void Button2Click(object sender, EventArgs e)
		{
				textBox1.Clear();
				textBox2.Clear();
				textBox1.Focus();

		}
		void Button3Click(object sender, EventArgs e)
		{
				this.Close();
		}
	}
}
