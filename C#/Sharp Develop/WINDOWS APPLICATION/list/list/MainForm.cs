/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 2/22/2020
 * Time: 11:19 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace list
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
			if (this.textBox1.Text != "")
			{
				listBox1.Items.Add(this.textBox1.Text);
				this.textBox1.Focus();
				this.textBox1.Clear();
			}
			else
			{
				MessageBox.Show("Please enter a name to add!", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
				this.textBox1.Focus();
}
		}
		void Button3Click(object sender, EventArgs e)
		{
	if (this.listBox1.SelectedIndex >= 0)
		{
			this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
		}
		}

		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		void Button5Click(object sender, EventArgs e)
		{
			if(colorDialog1.ShowDialog()==DialogResult.OK)
		{
			this.listBox1.BackColor = colorDialog1.Color;
		}
		}
		void Button4Click(object sender, EventArgs e)
		{
			if(fontDialog1.ShowDialog()==DialogResult.OK)
			listBox1.Font=fontDialog1.Font;
		}
	}
}
