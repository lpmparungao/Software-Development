/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 2/22/2020
 * Time: 11:37 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PizzaChart
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
		void OrderButtonClick(object sender, EventArgs e)
		{
			
			
			
			double che,anch,ham,veg,pine,pep, totalamount, quantity;
			totalamount = 0;
					if (CheeseButton.Checked)
					{
					che=12.75;
					totalamount += che;
					}
					if (AnchoviesButton.Checked)
					{
					anch=18.50;
					totalamount += anch;
					}
					if (HamButton.Checked)
					{
					ham=40.90;
					totalamount += ham;
					}
					if (VegetableButton.Checked)
					{
					veg=50.75;
					totalamount += veg;
					}
					if (PineappleButton.Checked)
					{
					pine=75.50;
					totalamount += pine;
					}
					if (PepperoniButton.Checked)
					{
					pep=45.50;
					totalamount += pep;
					}
			
			
			 if (ThinButton.Checked)
			{
				double bprice= 275.5;
				totalamount += bprice;
			   if (PanButton.Checked)
				{
					double sprice= 100;
					totalamount += sprice;
				}
	
				
				else if (RegularButton.Checked)
				{
					double sprice= 200;
					totalamount += sprice;
				}
				
				
				else if (PartyButton.Checked)
				{
					double sprice= 400;
					totalamount += sprice;
				}
				else 
				{
					MessageBox.Show ("Please Choose Size" , "ERROR");
				}
			}
			
			else if (ThickButton.Checked)
			{
				double bprice= 150.75;
				totalamount += bprice;
					
				if (PanButton.Checked)
				{
					double sprice= 100;
					totalamount += sprice;
				}
	
				
				else if (RegularButton.Checked)
				{
					double sprice= 200;
					totalamount += sprice;
				}
				
				
				else if (PartyButton.Checked)
				{
					double sprice= 400;
					totalamount += sprice;
				}
				else
				{
				MessageBox.Show ("Please Choose Size" , "ERROR");
				}
			}
			if (double.TryParse(QuantityText.Text, out quantity)) 
			{
				double amount =  quantity * totalamount;
				AmountLabel.Text = "Php" + amount.ToString(); 
			}
			else
			{
				MessageBox.Show ("Enter Quantity", "ERROR");
			}

// end
		}
		void ExitButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}


	}
}

	
