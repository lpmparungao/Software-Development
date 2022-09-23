/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 2/29/2020
 * Time: 2:26 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ColorMix
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
			if (blueradio1.Checked)
			{
				if (blueradio2.Checked)
			{
					this.BackColor = Color.Blue ;
			}
				else if (redradio2.Checked)
			{
					this.BackColor = Color.Violet ;
			}
				else if (yellowradio2.Checked)
			{
					this.BackColor = Color.Green ;
			}
				
			}
			//red
		if (redradio1.Checked)
			{
				if (blueradio2.Checked)
			{
					this.BackColor = Color.Violet ;
			}
				else if (redradio2.Checked)
			{
					this.BackColor = Color.Red ;
			}
				else if (yellowradio2.Checked)
			{
					this.BackColor = Color.Orange ;
			}
				
			}
		//yellow
					if (yellowradio1.Checked)
			{
				if (blueradio2.Checked)
			{
					this.BackColor = Color.Green ;
			}
				else if (redradio2.Checked)
			{
					this.BackColor = Color.Orange ;
			}
				else if (yellowradio2.Checked)
			{
					this.BackColor = Color.Yellow ;
			}
				
			}
		
		
		}
	}
}
