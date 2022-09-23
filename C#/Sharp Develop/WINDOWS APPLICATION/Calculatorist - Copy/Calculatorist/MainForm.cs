using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculatorist
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			this.BackColor = System.Drawing.Color.Gold;
		}

		void ComputeClick(object sender, EventArgs e)
		{
			double a = Convert.ToDouble(textBox1.Text);
			double b = Convert.ToDouble(textBox2.Text);
			double resulti;
			if(double.TryParse(textBox1.Text, out a))
			   {
				if(double.TryParse(textBox2.Text, out b))
				{
					if(listBox1.SelectedIndex != -1)
					{
						if (listBox1.SelectedIndex == 0)
						{
							resulti = a+b;
							answer.Text= resulti.ToString();
							string c= a + "+" + b + "="+ resulti;
							listBox2.Items.Add(c);
						}
						else if(listBox1.SelectedIndex == 1)
						{
							resulti = a-b;
							answer.Text= resulti.ToString();
							string c= a + "-" + b + "="+ resulti;
							listBox2.Items.Add(c);
						}
						else if(listBox1.SelectedIndex == 2)
						{
							resulti = a*b;
							answer.Text= resulti.ToString();
							string c= a + "*" + b + "="+ resulti;
							listBox2.Items.Add(c);
						}
						else if(listBox1.SelectedIndex== 3)
						{
							resulti = a/b;
							answer.Text= resulti.ToString();
							string c= a + "/" + b + "="+ resulti;
							listBox2.Items.Add(c);
						}
					}
					else
					{
						MessageBox.Show("Please choose an Operation to be used.", "Error", MessageBoxButtons.OK , MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBox.Show("Please enter a valid input", "Error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
				}
			   }
			else
			{
				MessageBox.Show("Please enter a valid input", "Error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
			}
		}
		void ClearistClick(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
		}
		void ExitClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
