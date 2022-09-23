/*
 * Created by SharpDevelop.
 * User: Calvin
 * Date: 3/11/2020
 * Time: 10:42 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Silverilocks
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton Caramelf;
		private System.Windows.Forms.RadioButton Vanillaf;
		private System.Windows.Forms.RadioButton Chocolatef;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton Partyf;
		private System.Windows.Forms.RadioButton Regularf;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader Flavor;
		private System.Windows.Forms.ColumnHeader Size;
		private System.Windows.Forms.ColumnHeader Quantity;
		private System.Windows.Forms.ColumnHeader Price;
		private System.Windows.Forms.Button Clear;
		private System.Windows.Forms.Button Order;
		private System.Windows.Forms.Button Exit;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Caramelf = new System.Windows.Forms.RadioButton();
			this.Vanillaf = new System.Windows.Forms.RadioButton();
			this.Chocolatef = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.Partyf = new System.Windows.Forms.RadioButton();
			this.Regularf = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.Flavor = new System.Windows.Forms.ColumnHeader();
			this.Size = new System.Windows.Forms.ColumnHeader();
			this.Quantity = new System.Windows.Forms.ColumnHeader();
			this.Price = new System.Windows.Forms.ColumnHeader();
			this.Clear = new System.Windows.Forms.Button();
			this.Order = new System.Windows.Forms.Button();
			this.Exit = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.Caramelf);
			this.groupBox1.Controls.Add(this.Vanillaf);
			this.groupBox1.Controls.Add(this.Chocolatef);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(117, 106);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Flavor";
			// 
			// Caramelf
			// 
			this.Caramelf.Location = new System.Drawing.Point(7, 81);
			this.Caramelf.Name = "Caramelf";
			this.Caramelf.Size = new System.Drawing.Size(104, 24);
			this.Caramelf.TabIndex = 2;
			this.Caramelf.TabStop = true;
			this.Caramelf.Text = "Caramel";
			this.Caramelf.UseVisualStyleBackColor = true;
			
			// 
			// Vanillaf
			// 
			this.Vanillaf.Location = new System.Drawing.Point(7, 50);
			this.Vanillaf.Name = "Vanillaf";
			this.Vanillaf.Size = new System.Drawing.Size(104, 24);
			this.Vanillaf.TabIndex = 1;
			this.Vanillaf.TabStop = true;
			this.Vanillaf.Text = "Vanilla";
			this.Vanillaf.UseVisualStyleBackColor = true;
			
			// 
			// Chocolatef
			// 
			this.Chocolatef.Location = new System.Drawing.Point(7, 19);
			this.Chocolatef.Name = "Chocolatef";
			this.Chocolatef.Size = new System.Drawing.Size(104, 24);
			this.Chocolatef.TabIndex = 0;
			this.Chocolatef.TabStop = true;
			this.Chocolatef.Text = "Chocolate";
			this.Chocolatef.UseVisualStyleBackColor = true;
			
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.Partyf);
			this.groupBox2.Controls.Add(this.Regularf);
			this.groupBox2.Location = new System.Drawing.Point(13, 126);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(117, 83);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Size";
			// 
			// Partyf
			// 
			this.Partyf.Location = new System.Drawing.Point(6, 49);
			this.Partyf.Name = "Partyf";
			this.Partyf.Size = new System.Drawing.Size(104, 24);
			this.Partyf.TabIndex = 2;
			this.Partyf.TabStop = true;
			this.Partyf.Text = "Party";
			this.Partyf.UseVisualStyleBackColor = true;
		
			// 
			// Regularf
			// 
			this.Regularf.Location = new System.Drawing.Point(6, 19);
			this.Regularf.Name = "Regularf";
			this.Regularf.Size = new System.Drawing.Size(104, 24);
			this.Regularf.TabIndex = 0;
			this.Regularf.TabStop = true;
			this.Regularf.Text = "Regular";
			this.Regularf.UseVisualStyleBackColor = true;
	
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 221);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 18);
			this.label1.TabIndex = 3;
			this.label1.Text = "Quantity:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(13, 244);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 4;
			
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.Flavor,
			this.Size,
			this.Quantity,
			this.Price});
			this.listView1.Location = new System.Drawing.Point(148, 13);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(351, 186);
			this.listView1.TabIndex = 5;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			
			// 
			// Flavor
			// 
			this.Flavor.Text = "Flavor";
			this.Flavor.Width = 100;
			// 
			// Size
			// 
			this.Size.Text = "Size";
			this.Size.Width = 80;
			// 
			// Quantity
			// 
			this.Quantity.Text = "Quantity";
			// 
			// Price
			// 
			this.Price.Text = "Price";
			this.Price.Width = 100;
			// 
			// Clear
			// 
			this.Clear.Location = new System.Drawing.Point(276, 221);
			this.Clear.Name = "Clear";
			this.Clear.Size = new System.Drawing.Size(75, 23);
			this.Clear.TabIndex = 7;
			this.Clear.Text = "Clear";
			this.Clear.UseVisualStyleBackColor = true;
			// 
			// Order
			// 
			this.Order.Location = new System.Drawing.Point(184, 221);
			this.Order.Name = "Order";
			this.Order.Size = new System.Drawing.Size(75, 23);
			this.Order.TabIndex = 8;
			this.Order.Text = "Order Now";
			this.Order.UseVisualStyleBackColor = true;
			this.Order.Click += new System.EventHandler(this.OrderClick);
			// 
			// Exit
			// 
			this.Exit.Location = new System.Drawing.Point(369, 221);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(75, 23);
			this.Exit.TabIndex = 9;
			this.Exit.Text = "Exit";
			this.Exit.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(510, 276);
			this.Controls.Add(this.Exit);
			this.Controls.Add(this.Order);
			this.Controls.Add(this.Clear);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "Silverilocks";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
