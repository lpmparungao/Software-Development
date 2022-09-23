/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 2/29/2020
 * Time: 8:36 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Practical_1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton yellowradio1;
		private System.Windows.Forms.RadioButton blueradio1;
		private System.Windows.Forms.RadioButton redradio1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton yellowradio2;
		private System.Windows.Forms.RadioButton blueradio2;
		private System.Windows.Forms.RadioButton redradio2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		
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
			this.yellowradio1 = new System.Windows.Forms.RadioButton();
			this.blueradio1 = new System.Windows.Forms.RadioButton();
			this.redradio1 = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.yellowradio2 = new System.Windows.Forms.RadioButton();
			this.blueradio2 = new System.Windows.Forms.RadioButton();
			this.redradio2 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.yellowradio1);
			this.groupBox1.Controls.Add(this.blueradio1);
			this.groupBox1.Controls.Add(this.redradio1);
			this.groupBox1.Location = new System.Drawing.Point(64, 98);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(219, 167);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Select the First Color";
			// 
			// yellowradio1
			// 
			this.yellowradio1.Location = new System.Drawing.Point(7, 99);
			this.yellowradio1.Name = "yellowradio1";
			this.yellowradio1.Size = new System.Drawing.Size(104, 24);
			this.yellowradio1.TabIndex = 2;
			this.yellowradio1.TabStop = true;
			this.yellowradio1.Text = "Yellow";
			this.yellowradio1.UseVisualStyleBackColor = true;
			// 
			// blueradio1
			// 
			this.blueradio1.Location = new System.Drawing.Point(7, 69);
			this.blueradio1.Name = "blueradio1";
			this.blueradio1.Size = new System.Drawing.Size(104, 24);
			this.blueradio1.TabIndex = 1;
			this.blueradio1.TabStop = true;
			this.blueradio1.Text = "Blue";
			this.blueradio1.UseVisualStyleBackColor = true;
			// 
			// redradio1
			// 
			this.redradio1.Location = new System.Drawing.Point(6, 39);
			this.redradio1.Name = "redradio1";
			this.redradio1.Size = new System.Drawing.Size(104, 24);
			this.redradio1.TabIndex = 0;
			this.redradio1.TabStop = true;
			this.redradio1.Text = "Red";
			this.redradio1.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.yellowradio2);
			this.groupBox2.Controls.Add(this.blueradio2);
			this.groupBox2.Controls.Add(this.redradio2);
			this.groupBox2.Location = new System.Drawing.Point(355, 98);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(227, 167);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Select the Second Color";
			// 
			// yellowradio2
			// 
			this.yellowradio2.Location = new System.Drawing.Point(7, 99);
			this.yellowradio2.Name = "yellowradio2";
			this.yellowradio2.Size = new System.Drawing.Size(104, 24);
			this.yellowradio2.TabIndex = 2;
			this.yellowradio2.TabStop = true;
			this.yellowradio2.Text = "Yellow";
			this.yellowradio2.UseVisualStyleBackColor = true;
			// 
			// blueradio2
			// 
			this.blueradio2.Location = new System.Drawing.Point(7, 70);
			this.blueradio2.Name = "blueradio2";
			this.blueradio2.Size = new System.Drawing.Size(104, 24);
			this.blueradio2.TabIndex = 1;
			this.blueradio2.TabStop = true;
			this.blueradio2.Text = "Blue";
			this.blueradio2.UseVisualStyleBackColor = true;
			// 
			// redradio2
			// 
			this.redradio2.Location = new System.Drawing.Point(7, 39);
			this.redradio2.Name = "redradio2";
			this.redradio2.Size = new System.Drawing.Size(104, 24);
			this.redradio2.TabIndex = 0;
			this.redradio2.TabStop = true;
			this.redradio2.Text = "Red";
			this.redradio2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(222, 298);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Mix";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(338, 298);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Exit";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(641, 431);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "Practical 1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
