/*
 * Created by SharpDevelop.
 * User: Castronuevo
 * Date: 02/22/2020
 * Time: 1:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Let_s_Do_Math
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox num2TextBox;
		private System.Windows.Forms.TextBox num1TextBox;
		private System.Windows.Forms.Label num2label;
		private System.Windows.Forms.Label num1label;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton DivideradioButton4;
		private System.Windows.Forms.RadioButton SubtractradioButton3;
		private System.Windows.Forms.RadioButton MultiplyradioButton2;
		private System.Windows.Forms.RadioButton AddradioButton1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button ComputeButton;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.TextBox resultTextBox;
		
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
			this.num2TextBox = new System.Windows.Forms.TextBox();
			this.num1TextBox = new System.Windows.Forms.TextBox();
			this.num2label = new System.Windows.Forms.Label();
			this.num1label = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.DivideradioButton4 = new System.Windows.Forms.RadioButton();
			this.SubtractradioButton3 = new System.Windows.Forms.RadioButton();
			this.MultiplyradioButton2 = new System.Windows.Forms.RadioButton();
			this.AddradioButton1 = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.resultTextBox = new System.Windows.Forms.TextBox();
			this.ComputeButton = new System.Windows.Forms.Button();
			this.ClearButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.num2TextBox);
			this.groupBox1.Controls.Add(this.num1TextBox);
			this.groupBox1.Controls.Add(this.num2label);
			this.groupBox1.Controls.Add(this.num1label);
			this.groupBox1.Location = new System.Drawing.Point(17, 16);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(345, 110);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Data Input";
			// 
			// num2TextBox
			// 
			this.num2TextBox.Location = new System.Drawing.Point(169, 69);
			this.num2TextBox.Margin = new System.Windows.Forms.Padding(4);
			this.num2TextBox.Name = "num2TextBox";
			this.num2TextBox.Size = new System.Drawing.Size(137, 22);
			this.num2TextBox.TabIndex = 3;
			// 
			// num1TextBox
			// 
			this.num1TextBox.Location = new System.Drawing.Point(169, 39);
			this.num1TextBox.Margin = new System.Windows.Forms.Padding(4);
			this.num1TextBox.Name = "num1TextBox";
			this.num1TextBox.Size = new System.Drawing.Size(137, 22);
			this.num1TextBox.TabIndex = 2;
			// 
			// num2label
			// 
			this.num2label.Location = new System.Drawing.Point(9, 69);
			this.num2label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.num2label.Name = "num2label";
			this.num2label.Size = new System.Drawing.Size(133, 28);
			this.num2label.TabIndex = 1;
			this.num2label.Text = "Enter a Number:";
			// 
			// num1label
			// 
			this.num1label.Location = new System.Drawing.Point(9, 36);
			this.num1label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.num1label.Name = "num1label";
			this.num1label.Size = new System.Drawing.Size(133, 28);
			this.num1label.TabIndex = 0;
			this.num1label.Text = "Enter a Number:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.DivideradioButton4);
			this.groupBox2.Controls.Add(this.SubtractradioButton3);
			this.groupBox2.Controls.Add(this.MultiplyradioButton2);
			this.groupBox2.Controls.Add(this.AddradioButton1);
			this.groupBox2.Location = new System.Drawing.Point(17, 134);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(345, 101);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Actions";
			// 
			// DivideradioButton4
			// 
			this.DivideradioButton4.Location = new System.Drawing.Point(184, 62);
			this.DivideradioButton4.Margin = new System.Windows.Forms.Padding(4);
			this.DivideradioButton4.Name = "DivideradioButton4";
			this.DivideradioButton4.Size = new System.Drawing.Size(139, 30);
			this.DivideradioButton4.TabIndex = 3;
			this.DivideradioButton4.TabStop = true;
			this.DivideradioButton4.Text = "Divide";
			this.DivideradioButton4.UseVisualStyleBackColor = true;
			// 
			// SubtractradioButton3
			// 
			this.SubtractradioButton3.Location = new System.Drawing.Point(9, 62);
			this.SubtractradioButton3.Margin = new System.Windows.Forms.Padding(4);
			this.SubtractradioButton3.Name = "SubtractradioButton3";
			this.SubtractradioButton3.Size = new System.Drawing.Size(139, 30);
			this.SubtractradioButton3.TabIndex = 2;
			this.SubtractradioButton3.TabStop = true;
			this.SubtractradioButton3.Text = "Subtract";
			this.SubtractradioButton3.UseVisualStyleBackColor = true;
			// 
			// MultiplyradioButton2
			// 
			this.MultiplyradioButton2.Location = new System.Drawing.Point(184, 23);
			this.MultiplyradioButton2.Margin = new System.Windows.Forms.Padding(4);
			this.MultiplyradioButton2.Name = "MultiplyradioButton2";
			this.MultiplyradioButton2.Size = new System.Drawing.Size(139, 30);
			this.MultiplyradioButton2.TabIndex = 1;
			this.MultiplyradioButton2.TabStop = true;
			this.MultiplyradioButton2.Text = "Multiply";
			this.MultiplyradioButton2.UseVisualStyleBackColor = true;
			// 
			// AddradioButton1
			// 
			this.AddradioButton1.Location = new System.Drawing.Point(9, 25);
			this.AddradioButton1.Margin = new System.Windows.Forms.Padding(4);
			this.AddradioButton1.Name = "AddradioButton1";
			this.AddradioButton1.Size = new System.Drawing.Size(139, 30);
			this.AddradioButton1.TabIndex = 0;
			this.AddradioButton1.TabStop = true;
			this.AddradioButton1.Text = "Add";
			this.AddradioButton1.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.resultTextBox);
			this.groupBox3.Location = new System.Drawing.Point(17, 244);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox3.Size = new System.Drawing.Size(345, 58);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Result";
			// 
			// resultTextBox
			// 
			this.resultTextBox.Location = new System.Drawing.Point(9, 25);
			this.resultTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.resultTextBox.Name = "resultTextBox";
			this.resultTextBox.Size = new System.Drawing.Size(327, 22);
			this.resultTextBox.TabIndex = 0;
			// 
			// ComputeButton
			// 
			this.ComputeButton.Location = new System.Drawing.Point(17, 321);
			this.ComputeButton.Margin = new System.Windows.Forms.Padding(4);
			this.ComputeButton.Name = "ComputeButton";
			this.ComputeButton.Size = new System.Drawing.Size(100, 28);
			this.ComputeButton.TabIndex = 4;
			this.ComputeButton.Text = "Compute";
			this.ComputeButton.UseVisualStyleBackColor = true;
			this.ComputeButton.Click += new System.EventHandler(this.ComputeButtonClick);
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(141, 321);
			this.ClearButton.Margin = new System.Windows.Forms.Padding(4);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(100, 28);
			this.ClearButton.TabIndex = 5;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButtonClick);
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(263, 321);
			this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(100, 28);
			this.ExitButton.TabIndex = 6;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(379, 376);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.ComputeButton);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "Let\'s Do Math";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
