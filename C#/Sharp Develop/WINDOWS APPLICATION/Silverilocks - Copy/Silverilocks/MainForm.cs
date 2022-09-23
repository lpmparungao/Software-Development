using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Silverilocks
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			this.BackColor = System.Drawing.Color.Silver;
		}
		
		void OrderClick(object sender, EventArgs e)
		{
			string cho = "Chocolate";
			string van = "Vanilla";
			string car = "Caramel";
			string reg = "Regular";
			string par = "Party";
			double quan = Convert.ToDouble(textBox1.Text);
			double price;
			double.TryParse(textBox1.Text,out quan);
			if(Chocolatef.Checked && Regularf.Checked)
			{
				price = (54.75+200.00)*quan;
				ListViewItem item1 = new ListViewItem(cho);
				item1.SubItems.Add(reg);
				item1.SubItems.Add(quan.ToString());
				item1.SubItems.Add(price.ToString());
				listView1.Items.Add(item1);
				
			}
			else if(Chocolatef.Checked&&Partyf.Checked)
			{
				price = (54.75+800.00)*quan;
				ListViewItem item1 = new ListViewItem(cho);
				item1.SubItems.Add(par);
				item1.SubItems.Add(quan.ToString());
				item1.SubItems.Add(price.ToString());
				listView1.Items.Add(item1);
			}
			else if (Vanillaf.Checked&&Regularf.Checked)
			{
				price = (48.50+200.00)*quan;
				ListViewItem item1 = new ListViewItem(van);
				item1.SubItems.Add(reg);
				item1.SubItems.Add(quan.ToString());
				item1.SubItems.Add(price.ToString());
				listView1.Items.Add(item1);
			}
			else if(Vanillaf.Checked&&Partyf.Checked)
			{
				price = (48.50+800.00)*quan;
				ListViewItem item1 = new ListViewItem(van);
				item1.SubItems.Add(par);
				item1.SubItems.Add(quan.ToString());
				item1.SubItems.Add(price.ToString());
				listView1.Items.Add(item1);
			}
			else if(Caramelf.Checked&&Regularf.Checked)
			{
				price = (52.75+200.00)*quan;
				ListViewItem item1 = new ListViewItem(car);
				item1.SubItems.Add(reg);
				item1.SubItems.Add(quan.ToString());
				item1.SubItems.Add(price.ToString());
				listView1.Items.Add(item1);
			}
			else if(Caramelf.Checked&&Partyf.Checked)
			{
				price = (52.75+800.00)*quan;
				ListViewItem item1 = new ListViewItem(car);
				item1.SubItems.Add(par);
				item1.SubItems.Add(quan.ToString());
				item1.SubItems.Add(price.ToString());
				listView1.Items.Add(item1);
			}
		}
		void ClearClick(object sender, EventArgs e)
		{
			listView1.Clear();
			textBox1.Clear();
		}
		void ExitClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
