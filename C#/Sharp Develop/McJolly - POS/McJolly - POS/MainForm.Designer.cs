/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 3/7/2020
 * Time: 8:03 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace McJolly___POS
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelAmount1;
		private System.Windows.Forms.Button buttonAddOrder;
		private System.Windows.Forms.Button buttonRemoveOrder;
		private System.Windows.Forms.Button buttonCancelOrder;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Label labelTotalAmount;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label labelDiscount;
		private System.Windows.Forms.CheckBox checkBoxDiscount;
		private System.Windows.Forms.Button buttonCheckOut;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem addItemsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
		private System.Windows.Forms.ListView listViewOrders;
		private System.Windows.Forms.Label labelDate;
		private System.Windows.Forms.ListBox listboxMenu;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.listboxMenu = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.labelAmount1 = new System.Windows.Forms.Label();
			this.labelDate = new System.Windows.Forms.Label();
			this.buttonAddOrder = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.buttonRemoveOrder = new System.Windows.Forms.Button();
			this.buttonCancelOrder = new System.Windows.Forms.Button();
			this.listViewOrders = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.labelTotalAmount = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.labelDiscount = new System.Windows.Forms.Label();
			this.checkBoxDiscount = new System.Windows.Forms.CheckBox();
			this.buttonCheckOut = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listboxMenu
			// 
			this.listboxMenu.FormattingEnabled = true;
			this.listboxMenu.ItemHeight = 16;
			this.listboxMenu.Items.AddRange(new object[] {
			"Regular McYum",
			"McYum w/ Cheese",
			"Double McYum",
			"Cheezy Bacon McYum",
			"McYum w/ TLC",
			"Big McJolly",
			"Quarter Pounder",
			"Champ",
			"McJolly Spaghetti",
			"Palabok",
			"Crispy Strips",
			"Chicken McJolly Nuggets",
			"French Fries",
			"Sundae",
			"Sundae Cone",
			"Softdrinks",
			"Iced Tea"});
			this.listboxMenu.Location = new System.Drawing.Point(27, 31);
			this.listboxMenu.Name = "listboxMenu";
			this.listboxMenu.Size = new System.Drawing.Size(327, 292);
			this.listboxMenu.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(27, 343);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 22);
			this.label1.TabIndex = 1;
			this.label1.Text = "Amount:";
			// 
			// labelAmount1
			// 
			this.labelAmount1.Location = new System.Drawing.Point(103, 343);
			this.labelAmount1.Name = "labelAmount1";
			this.labelAmount1.Size = new System.Drawing.Size(100, 23);
			this.labelAmount1.TabIndex = 2;
			this.labelAmount1.Text = "0";
			// 
			// labelDate
			// 
			this.labelDate.Location = new System.Drawing.Point(668, 9);
			this.labelDate.Name = "labelDate";
			this.labelDate.Size = new System.Drawing.Size(288, 23);
			this.labelDate.TabIndex = 3;
			this.labelDate.Text = "Date";
			// 
			// buttonAddOrder
			// 
			this.buttonAddOrder.ImageIndex = 0;
			this.buttonAddOrder.ImageList = this.imageList1;
			this.buttonAddOrder.Location = new System.Drawing.Point(374, 42);
			this.buttonAddOrder.Name = "buttonAddOrder";
			this.buttonAddOrder.Size = new System.Drawing.Size(62, 42);
			this.buttonAddOrder.TabIndex = 4;
			this.buttonAddOrder.UseVisualStyleBackColor = true;
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "arrow2.png");
			this.imageList1.Images.SetKeyName(1, "arrow1.png");
			this.imageList1.Images.SetKeyName(2, "1766.png");
			// 
			// buttonRemoveOrder
			// 
			this.buttonRemoveOrder.ImageIndex = 1;
			this.buttonRemoveOrder.ImageList = this.imageList1;
			this.buttonRemoveOrder.Location = new System.Drawing.Point(374, 90);
			this.buttonRemoveOrder.Name = "buttonRemoveOrder";
			this.buttonRemoveOrder.Size = new System.Drawing.Size(60, 42);
			this.buttonRemoveOrder.TabIndex = 5;
			this.buttonRemoveOrder.UseVisualStyleBackColor = true;
			// 
			// buttonCancelOrder
			// 
			this.buttonCancelOrder.ImageIndex = 2;
			this.buttonCancelOrder.ImageList = this.imageList1;
			this.buttonCancelOrder.Location = new System.Drawing.Point(372, 267);
			this.buttonCancelOrder.Name = "buttonCancelOrder";
			this.buttonCancelOrder.Size = new System.Drawing.Size(62, 44);
			this.buttonCancelOrder.TabIndex = 6;
			this.buttonCancelOrder.UseVisualStyleBackColor = true;
			// 
			// listViewOrders
			// 
			this.listViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnHeader1,
			this.columnHeader2,
			this.columnHeader3});
			this.listViewOrders.Location = new System.Drawing.Point(457, 31);
			this.listViewOrders.Name = "listViewOrders";
			this.listViewOrders.Size = new System.Drawing.Size(434, 292);
			this.listViewOrders.TabIndex = 7;
			this.listViewOrders.UseCompatibleStateImageBehavior = false;
			this.listViewOrders.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Name";
			this.columnHeader1.Width = 215;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Quantity";
			this.columnHeader2.Width = 55;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Price";
			this.columnHeader3.Width = 73;
			// 
			// labelTotalAmount
			// 
			this.labelTotalAmount.Location = new System.Drawing.Point(457, 342);
			this.labelTotalAmount.Name = "labelTotalAmount";
			this.labelTotalAmount.Size = new System.Drawing.Size(100, 23);
			this.labelTotalAmount.TabIndex = 8;
			this.labelTotalAmount.Text = "Amount:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(534, 343);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "0";
			// 
			// labelDiscount
			// 
			this.labelDiscount.Location = new System.Drawing.Point(457, 365);
			this.labelDiscount.Name = "labelDiscount";
			this.labelDiscount.Size = new System.Drawing.Size(130, 23);
			this.labelDiscount.TabIndex = 10;
			this.labelDiscount.Text = "Discounted Price:";
			// 
			// checkBoxDiscount
			// 
			this.checkBoxDiscount.Location = new System.Drawing.Point(457, 391);
			this.checkBoxDiscount.Name = "checkBoxDiscount";
			this.checkBoxDiscount.Size = new System.Drawing.Size(104, 24);
			this.checkBoxDiscount.TabIndex = 12;
			this.checkBoxDiscount.Text = "Discounted";
			this.checkBoxDiscount.UseVisualStyleBackColor = true;
			// 
			// buttonCheckOut
			// 
			this.buttonCheckOut.Location = new System.Drawing.Point(781, 391);
			this.buttonCheckOut.Name = "buttonCheckOut";
			this.buttonCheckOut.Size = new System.Drawing.Size(89, 23);
			this.buttonCheckOut.TabIndex = 13;
			this.buttonCheckOut.Text = "Checkout";
			this.buttonCheckOut.UseVisualStyleBackColor = true;
			this.buttonCheckOut.Click += new System.EventHandler(this.ButtonCheckOutClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.addItemsToolStripMenuItem,
			this.cancelToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(147, 52);
			// 
			// addItemsToolStripMenuItem
			// 
			this.addItemsToolStripMenuItem.Name = "addItemsToolStripMenuItem";
			this.addItemsToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
			this.addItemsToolStripMenuItem.Text = "Add Items";
			// 
			// cancelToolStripMenuItem
			// 
			this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
			this.cancelToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
			this.cancelToolStripMenuItem.Text = "Cancel";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(943, 452);
			this.Controls.Add(this.buttonCheckOut);
			this.Controls.Add(this.checkBoxDiscount);
			this.Controls.Add(this.labelDiscount);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.labelTotalAmount);
			this.Controls.Add(this.listViewOrders);
			this.Controls.Add(this.buttonCancelOrder);
			this.Controls.Add(this.buttonRemoveOrder);
			this.Controls.Add(this.buttonAddOrder);
			this.Controls.Add(this.labelDate);
			this.Controls.Add(this.labelAmount1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listboxMenu);
			this.Name = "MainForm";
			this.Text = "McJolly - POS";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
