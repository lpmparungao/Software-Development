/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 3/7/2020
 * Time: 8:03 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace McJolly___POS
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
		void MainFormLoad(object sender, EventArgs e)
		{
			string date = System.DateTime.Now.ToLongDateString();
			labelDate.Text = "Date:" + date ; 
        }
		void ButtonCheckOutClick(object sender, EventArgs e)
		{
	
		}

	}
}