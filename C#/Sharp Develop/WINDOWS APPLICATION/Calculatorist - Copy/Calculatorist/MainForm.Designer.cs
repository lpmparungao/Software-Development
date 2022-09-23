/*
 * Created by SharpDevelop.
 * User: Calvin
 * Date: 3/11/2020
 * Time: 2:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Calculatorist
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label answer;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Button compute;
		private System.Windows.Forms.Button clearist;
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.answer = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.compute = new System.Windows.Forms.Button();
			this.clearist = new System.Windows.Forms.Button();
			this.Exit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter a Number:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(106, 13);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 1;
			
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 30);
			this.label2.TabIndex = 2;
			this.label2.Text = "Enter another Number:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(106, 49);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 3;
			
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Items.AddRange(new object[] {
			"Addition",
			"Subtraction",
			"Multiplication",
			"Division"});
			this.listBox1.Location = new System.Drawing.Point(13, 109);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(86, 56);
			this.listBox1.TabIndex = 4;
		
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Operation to be used:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(143, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Result:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// answer
			// 
			this.answer.Location = new System.Drawing.Point(133, 132);
			this.answer.Name = "answer";
			this.answer.Size = new System.Drawing.Size(100, 23);
			this.answer.TabIndex = 7;
			
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(13, 172);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 19);
			this.label5.TabIndex = 8;
			this.label5.Text = "History";
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.Location = new System.Drawing.Point(13, 195);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(120, 95);
			this.listBox2.TabIndex = 9;
			
			// 
			// compute
			// 
			this.compute.Location = new System.Drawing.Point(158, 195);
			this.compute.Name = "compute";
			this.compute.Size = new System.Drawing.Size(75, 23);
			this.compute.TabIndex = 10;
			this.compute.Text = "Compute";
			this.compute.UseVisualStyleBackColor = true;
			this.compute.Click += new System.EventHandler(this.ComputeClick);
			// 
			// clearist
			// 
			this.clearist.Location = new System.Drawing.Point(158, 224);
			this.clearist.Name = "clearist";
			this.clearist.Size = new System.Drawing.Size(75, 23);
			this.clearist.TabIndex = 11;
			this.clearist.Text = "Clear";
			this.clearist.UseVisualStyleBackColor = true;
			this.clearist.Click += new System.EventHandler(this.ClearistClick);
			// 
			// Exit
			// 
			this.Exit.Location = new System.Drawing.Point(158, 253);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(75, 23);
			this.Exit.TabIndex = 12;
			this.Exit.Text = "Exit";
			this.Exit.UseVisualStyleBackColor = true;
			this.Exit.Click += new System.EventHandler(this.ExitClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 306);
			this.Controls.Add(this.Exit);
			this.Controls.Add(this.clearist);
			this.Controls.Add(this.compute);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.answer);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Calculatorist";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
