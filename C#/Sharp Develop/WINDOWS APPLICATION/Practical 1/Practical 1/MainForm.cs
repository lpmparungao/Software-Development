/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 2/29/2020
 * Time: 8:36 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Practical_1
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
//blue
			if (blueradio2.Checked)
			{
				if (blueradio1.Checked)
			{
					this.BackColor = Color.Blue ;
			}
				else if (redradio1.Checked)
			{
					this.BackColor = Color.Violet ;
			}
				else if (yellowradio1.Checked)
			{
					this.BackColor = Color.Green ;
			}
				
			}
			//red
		else if (redradio2.Checked)
			{
				if (blueradio1.Checked)
			{
					this.BackColor = Color.Violet ;
			}
				else if (redradio1.Checked)
			{
					this.BackColor = Color.Red ;
			}
				else if (yellowradio1.Checked)
			{
					this.BackColor = Color.Orange ;
			}
				
			}
		//yellow
				else if (yellowradio2.Checked)
			{
				if (blueradio1.Checked)
			{
					this.BackColor = Color.Green ;
			}
				else if (redradio1.Checked)
			{
					this.BackColor = Color.Orange ;
			}
				else if (yellowradio1.Checked)
			{
					this.BackColor = Color.Yellow ;
			}
				
			}
				else
				{
					MessageBox.Show("Please select the Second Color", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
					
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
