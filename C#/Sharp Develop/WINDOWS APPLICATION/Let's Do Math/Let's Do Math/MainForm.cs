/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 02/22/2020
 * Time: 1:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Let_s_Do_Math
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
		void ComputeButtonClick(object sender, EventArgs e)
		{
			
				double sum, product, diff, quotient, num1, num2;
				double Result = 0;
			
			if (double.TryParse(num1TextBox.Text, out num1))
				{ 
			if (double.TryParse(num2TextBox.Text, out num2))
					{

			if (AddradioButton1.Checked)
				{
				sum = num1 + num2;
				Result += sum;

				}

				else if (MultiplyradioButton2.Checked)
				{
				product = num1 * num2;
				Result += product;

				}

				else if (SubtractradioButton3.Checked)
				{
				diff = num1 - num2;
				Result += diff;

				}

				else if (DivideradioButton4.Checked)
				{
				quotient = num1 / num2;
				Result += quotient;
	
				}
				resultTextBox.Text = Result.ToString();
				}
				else 
				{
					MessageBox.Show("Please Enter Value on Second Text Box");
				}
				}
				else 
				{
					MessageBox.Show("Please Enter Value on First Text Box");
				}


		}
		
	
		void ClearButtonClick(object sender, EventArgs e)
		{
			num1TextBox.Clear();
			num2TextBox.Clear();
			resultTextBox.Clear();
		}
		void ExitButtonClick(object sender, EventArgs e)
		{
			this.Close();
			
		}
	}
}

	

