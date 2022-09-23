/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 2/1/2020
 * Time: 10:28 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CurrencyConverter
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button DollarButton;
		private System.Windows.Forms.Button EuroButton;
		private System.Windows.Forms.Button YenButton;
		private System.Windows.Forms.Button RiyalButton;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Label label3;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.EuroButton = new System.Windows.Forms.Button();
			this.YenButton = new System.Windows.Forms.Button();
			this.RiyalButton = new System.Windows.Forms.Button();
			this.ClearButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.DollarButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(48, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(259, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter amount to be converted in Peso";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(48, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(196, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Converted Amount";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(328, 58);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 2;
			// 
			// EuroButton
			// 
			this.EuroButton.Location = new System.Drawing.Point(175, 173);
			this.EuroButton.Name = "EuroButton";
			this.EuroButton.Size = new System.Drawing.Size(75, 23);
			this.EuroButton.TabIndex = 5;
			this.EuroButton.Text = "Euro";
			this.EuroButton.UseVisualStyleBackColor = true;
			this.EuroButton.Click += new System.EventHandler(this.EuroButtonClick);
			// 
			// YenButton
			// 
			this.YenButton.Location = new System.Drawing.Point(313, 173);
			this.YenButton.Name = "YenButton";
			this.YenButton.Size = new System.Drawing.Size(75, 23);
			this.YenButton.TabIndex = 6;
			this.YenButton.Text = "Yen";
			this.YenButton.UseVisualStyleBackColor = true;
			this.YenButton.Click += new System.EventHandler(this.YenButtonClick);
			// 
			// RiyalButton
			// 
			this.RiyalButton.Location = new System.Drawing.Point(452, 173);
			this.RiyalButton.Name = "RiyalButton";
			this.RiyalButton.Size = new System.Drawing.Size(75, 23);
			this.RiyalButton.TabIndex = 7;
			this.RiyalButton.Text = "Riyal";
			this.RiyalButton.UseVisualStyleBackColor = true;
			this.RiyalButton.Click += new System.EventHandler(this.RiyalButtonClick);
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(176, 256);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(75, 23);
			this.ClearButton.TabIndex = 8;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButtonClick);
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(314, 256);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(75, 23);
			this.ExitButton.TabIndex = 9;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButtonClick);
			// 
			// DollarButton
			// 
			this.DollarButton.Location = new System.Drawing.Point(48, 173);
			this.DollarButton.Name = "DollarButton";
			this.DollarButton.Size = new System.Drawing.Size(87, 23);
			this.DollarButton.TabIndex = 10;
			this.DollarButton.Text = "US Dollar";
			this.DollarButton.UseVisualStyleBackColor = true;
			this.DollarButton.Click += new System.EventHandler(this.DollarButtonClick);
			// 
			// label3
			// 
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Location = new System.Drawing.Point(327, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 11;
			this.label3.Text = " ";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(585, 305);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.DollarButton);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.RiyalButton);
			this.Controls.Add(this.YenButton);
			this.Controls.Add(this.EuroButton);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "CurrencyConverter";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
