/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 2/22/2020
 * Time: 11:37 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PizzaChart
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox CrustBox;
		private System.Windows.Forms.GroupBox SizeBox;
		private System.Windows.Forms.GroupBox ToppingsBox;
		private System.Windows.Forms.RadioButton ThinButton;
		private System.Windows.Forms.RadioButton PartyButton;
		private System.Windows.Forms.RadioButton RegularButton;
		private System.Windows.Forms.RadioButton PanButton;
		private System.Windows.Forms.CheckBox PepperoniButton;
		private System.Windows.Forms.CheckBox PineappleButton;
		private System.Windows.Forms.CheckBox VegetableButton;
		private System.Windows.Forms.CheckBox HamButton;
		private System.Windows.Forms.CheckBox AnchoviesButton;
		private System.Windows.Forms.CheckBox CheeseButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button OrderButton;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Label AmountLabel;
		private System.Windows.Forms.Label Amount;
		private System.Windows.Forms.TextBox QuantityText;
		private System.Windows.Forms.RadioButton ThickButton;
		
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
			this.CrustBox = new System.Windows.Forms.GroupBox();
			this.ThinButton = new System.Windows.Forms.RadioButton();
			this.ThickButton = new System.Windows.Forms.RadioButton();
			this.SizeBox = new System.Windows.Forms.GroupBox();
			this.PartyButton = new System.Windows.Forms.RadioButton();
			this.RegularButton = new System.Windows.Forms.RadioButton();
			this.PanButton = new System.Windows.Forms.RadioButton();
			this.ToppingsBox = new System.Windows.Forms.GroupBox();
			this.PepperoniButton = new System.Windows.Forms.CheckBox();
			this.PineappleButton = new System.Windows.Forms.CheckBox();
			this.VegetableButton = new System.Windows.Forms.CheckBox();
			this.HamButton = new System.Windows.Forms.CheckBox();
			this.AnchoviesButton = new System.Windows.Forms.CheckBox();
			this.CheeseButton = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.OrderButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.AmountLabel = new System.Windows.Forms.Label();
			this.Amount = new System.Windows.Forms.Label();
			this.QuantityText = new System.Windows.Forms.TextBox();
			this.CrustBox.SuspendLayout();
			this.SizeBox.SuspendLayout();
			this.ToppingsBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// CrustBox
			// 
			this.CrustBox.Controls.Add(this.ThinButton);
			this.CrustBox.Controls.Add(this.ThickButton);
			this.CrustBox.Location = new System.Drawing.Point(51, 52);
			this.CrustBox.Name = "CrustBox";
			this.CrustBox.Size = new System.Drawing.Size(200, 109);
			this.CrustBox.TabIndex = 0;
			this.CrustBox.TabStop = false;
			this.CrustBox.Text = "Crust";
			// 
			// ThinButton
			// 
			this.ThinButton.Location = new System.Drawing.Point(7, 61);
			this.ThinButton.Name = "ThinButton";
			this.ThinButton.Size = new System.Drawing.Size(104, 24);
			this.ThinButton.TabIndex = 1;
			this.ThinButton.TabStop = true;
			this.ThinButton.Text = "Thin";
			this.ThinButton.UseVisualStyleBackColor = true;
			// 
			// ThickButton
			// 
			this.ThickButton.Location = new System.Drawing.Point(7, 31);
			this.ThickButton.Name = "ThickButton";
			this.ThickButton.Size = new System.Drawing.Size(104, 24);
			this.ThickButton.TabIndex = 0;
			this.ThickButton.TabStop = true;
			this.ThickButton.Text = "Thick";
			this.ThickButton.UseVisualStyleBackColor = true;
			// 
			// SizeBox
			// 
			this.SizeBox.Controls.Add(this.PartyButton);
			this.SizeBox.Controls.Add(this.RegularButton);
			this.SizeBox.Controls.Add(this.PanButton);
			this.SizeBox.Location = new System.Drawing.Point(51, 201);
			this.SizeBox.Name = "SizeBox";
			this.SizeBox.Size = new System.Drawing.Size(200, 145);
			this.SizeBox.TabIndex = 1;
			this.SizeBox.TabStop = false;
			this.SizeBox.Text = "Size";
			// 
			// PartyButton
			// 
			this.PartyButton.Location = new System.Drawing.Point(7, 96);
			this.PartyButton.Name = "PartyButton";
			this.PartyButton.Size = new System.Drawing.Size(104, 24);
			this.PartyButton.TabIndex = 2;
			this.PartyButton.TabStop = true;
			this.PartyButton.Text = "Party";
			this.PartyButton.UseVisualStyleBackColor = true;
			// 
			// RegularButton
			// 
			this.RegularButton.Location = new System.Drawing.Point(7, 65);
			this.RegularButton.Name = "RegularButton";
			this.RegularButton.Size = new System.Drawing.Size(104, 24);
			this.RegularButton.TabIndex = 1;
			this.RegularButton.TabStop = true;
			this.RegularButton.Text = "Regular";
			this.RegularButton.UseVisualStyleBackColor = true;
			// 
			// PanButton
			// 
			this.PanButton.Location = new System.Drawing.Point(7, 35);
			this.PanButton.Name = "PanButton";
			this.PanButton.Size = new System.Drawing.Size(104, 24);
			this.PanButton.TabIndex = 0;
			this.PanButton.TabStop = true;
			this.PanButton.Text = "Pan";
			this.PanButton.UseVisualStyleBackColor = true;
			// 
			// ToppingsBox
			// 
			this.ToppingsBox.Controls.Add(this.PepperoniButton);
			this.ToppingsBox.Controls.Add(this.PineappleButton);
			this.ToppingsBox.Controls.Add(this.VegetableButton);
			this.ToppingsBox.Controls.Add(this.HamButton);
			this.ToppingsBox.Controls.Add(this.AnchoviesButton);
			this.ToppingsBox.Controls.Add(this.CheeseButton);
			this.ToppingsBox.Location = new System.Drawing.Point(350, 61);
			this.ToppingsBox.Name = "ToppingsBox";
			this.ToppingsBox.Size = new System.Drawing.Size(200, 229);
			this.ToppingsBox.TabIndex = 2;
			this.ToppingsBox.TabStop = false;
			this.ToppingsBox.Text = "Toppings";
			// 
			// PepperoniButton
			// 
			this.PepperoniButton.Location = new System.Drawing.Point(7, 195);
			this.PepperoniButton.Name = "PepperoniButton";
			this.PepperoniButton.Size = new System.Drawing.Size(104, 24);
			this.PepperoniButton.TabIndex = 5;
			this.PepperoniButton.Text = "Pepperoni";
			this.PepperoniButton.UseVisualStyleBackColor = true;
			// 
			// PineappleButton
			// 
			this.PineappleButton.Location = new System.Drawing.Point(7, 164);
			this.PineappleButton.Name = "PineappleButton";
			this.PineappleButton.Size = new System.Drawing.Size(104, 24);
			this.PineappleButton.TabIndex = 4;
			this.PineappleButton.Text = "Pineapple";
			this.PineappleButton.UseVisualStyleBackColor = true;
			// 
			// VegetableButton
			// 
			this.VegetableButton.Location = new System.Drawing.Point(7, 133);
			this.VegetableButton.Name = "VegetableButton";
			this.VegetableButton.Size = new System.Drawing.Size(104, 24);
			this.VegetableButton.TabIndex = 3;
			this.VegetableButton.Text = "Vegetable";
			this.VegetableButton.UseVisualStyleBackColor = true;
			// 
			// HamButton
			// 
			this.HamButton.Location = new System.Drawing.Point(7, 102);
			this.HamButton.Name = "HamButton";
			this.HamButton.Size = new System.Drawing.Size(104, 24);
			this.HamButton.TabIndex = 2;
			this.HamButton.Text = "Ham";
			this.HamButton.UseVisualStyleBackColor = true;
			// 
			// AnchoviesButton
			// 
			this.AnchoviesButton.Location = new System.Drawing.Point(7, 71);
			this.AnchoviesButton.Name = "AnchoviesButton";
			this.AnchoviesButton.Size = new System.Drawing.Size(104, 24);
			this.AnchoviesButton.TabIndex = 1;
			this.AnchoviesButton.Text = "Anchovies";
			this.AnchoviesButton.UseVisualStyleBackColor = true;
			// 
			// CheeseButton
			// 
			this.CheeseButton.Location = new System.Drawing.Point(7, 40);
			this.CheeseButton.Name = "CheeseButton";
			this.CheeseButton.Size = new System.Drawing.Size(104, 24);
			this.CheeseButton.TabIndex = 0;
			this.CheeseButton.Text = "Cheese";
			this.CheeseButton.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(29, 370);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Quantity";
			// 
			// OrderButton
			// 
			this.OrderButton.Location = new System.Drawing.Point(190, 420);
			this.OrderButton.Name = "OrderButton";
			this.OrderButton.Size = new System.Drawing.Size(101, 34);
			this.OrderButton.TabIndex = 4;
			this.OrderButton.Text = "Order Now";
			this.OrderButton.UseVisualStyleBackColor = true;
			this.OrderButton.Click += new System.EventHandler(this.OrderButtonClick);
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(350, 420);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(101, 34);
			this.ExitButton.TabIndex = 5;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButtonClick);
			// 
			// AmountLabel
			// 
			this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AmountLabel.Location = new System.Drawing.Point(320, 341);
			this.AmountLabel.Name = "AmountLabel";
			this.AmountLabel.Size = new System.Drawing.Size(264, 65);
			this.AmountLabel.TabIndex = 6;
			this.AmountLabel.Text = " ";
			// 
			// Amount
			// 
			this.Amount.Location = new System.Drawing.Point(350, 310);
			this.Amount.Name = "Amount";
			this.Amount.Size = new System.Drawing.Size(100, 23);
			this.Amount.TabIndex = 7;
			this.Amount.Text = "Amount Due:";
			// 
			// QuantityText
			// 
			this.QuantityText.Location = new System.Drawing.Point(103, 370);
			this.QuantityText.Name = "QuantityText";
			this.QuantityText.Size = new System.Drawing.Size(100, 22);
			this.QuantityText.TabIndex = 8;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(659, 496);
			this.Controls.Add(this.QuantityText);
			this.Controls.Add(this.Amount);
			this.Controls.Add(this.AmountLabel);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.OrderButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ToppingsBox);
			this.Controls.Add(this.SizeBox);
			this.Controls.Add(this.CrustBox);
			this.Name = "MainForm";
			this.Text = "PizzaChart";
			this.CrustBox.ResumeLayout(false);
			this.SizeBox.ResumeLayout(false);
			this.ToppingsBox.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
