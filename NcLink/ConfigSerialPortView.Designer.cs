/*
 * Created by SharpDevelop.
 * User: Adam
 * Date: 20/02/2014
 * Time: 00:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NcLink
{
	partial class ConfigSerialPortView
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.comboBox6 = new NcLink.EnhancedComboBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.comboBox5 = new NcLink.EnhancedComboBox();
			this.comboBox4 = new NcLink.EnhancedComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox3 = new NcLink.EnhancedComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox2 = new NcLink.EnhancedComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new NcLink.EnhancedComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.comboBox5);
			this.groupBox1.Controls.Add(this.comboBox4);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.comboBox3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(442, 315);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Serial settings";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.checkBox2);
			this.groupBox2.Controls.Add(this.comboBox6);
			this.groupBox2.Controls.Add(this.checkBox1);
			this.groupBox2.Location = new System.Drawing.Point(6, 128);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(426, 80);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Flow";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(6, 21);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 21);
			this.label6.TabIndex = 0;
			this.label6.Text = "Flow type";
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(200, 50);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(96, 24);
			this.checkBox2.TabIndex = 3;
			this.checkBox2.Text = "Enable DTR";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// comboBox6
			// 
			this.comboBox6.DefaultIndex = 0;
			this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox6.FormattingEnabled = true;
			this.comboBox6.Items.AddRange(new object[] {
									"Hardware",
									"Software"});
			this.comboBox6.Location = new System.Drawing.Point(6, 45);
			this.comboBox6.Name = "comboBox6";
			this.comboBox6.Size = new System.Drawing.Size(177, 25);
			this.comboBox6.TabIndex = 1;
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(200, 18);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(96, 24);
			this.checkBox1.TabIndex = 3;
			this.checkBox1.Text = "Enable RTS";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(367, 97);
			this.textBox2.MaxLength = 3;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(65, 25);
			this.textBox2.TabIndex = 2;
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(294, 97);
			this.textBox1.MaxLength = 3;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(65, 25);
			this.textBox1.TabIndex = 2;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// comboBox5
			// 
			this.comboBox5.DefaultIndex = 0;
			this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox5.FormattingEnabled = true;
			this.comboBox5.Location = new System.Drawing.Point(6, 97);
			this.comboBox5.Name = "comboBox5";
			this.comboBox5.Size = new System.Drawing.Size(138, 25);
			this.comboBox5.TabIndex = 1;
			// 
			// comboBox4
			// 
			this.comboBox4.DefaultIndex = 0;
			this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(150, 97);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(138, 25);
			this.comboBox4.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(367, 73);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(65, 21);
			this.label8.TabIndex = 0;
			this.label8.Text = "XOff char";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(294, 73);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(62, 21);
			this.label7.TabIndex = 0;
			this.label7.Text = "XOn char";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 73);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 21);
			this.label5.TabIndex = 0;
			this.label5.Text = "Data bits";
			// 
			// comboBox3
			// 
			this.comboBox3.DefaultIndex = 0;
			this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(294, 45);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(138, 25);
			this.comboBox3.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(150, 73);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 21);
			this.label4.TabIndex = 0;
			this.label4.Text = "Parity";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(294, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 0;
			this.label3.Text = "Stop bits";
			// 
			// comboBox2
			// 
			this.comboBox2.DefaultIndex = 0;
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(150, 45);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(138, 25);
			this.comboBox2.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(150, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 21);
			this.label2.TabIndex = 0;
			this.label2.Text = "Baud rate";
			// 
			// comboBox1
			// 
			this.comboBox1.DefaultIndex = 0;
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(6, 45);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(138, 25);
			this.comboBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "COM port";
			// 
			// ConfigSerialPortView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "ConfigSerialPortView";
			this.Size = new System.Drawing.Size(451, 355);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private NcLink.EnhancedComboBox comboBox6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label5;
		private NcLink.EnhancedComboBox comboBox5;
		private System.Windows.Forms.Label label1;
		private NcLink.EnhancedComboBox comboBox1;
		private System.Windows.Forms.Label label2;
		private NcLink.EnhancedComboBox comboBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private NcLink.EnhancedComboBox comboBox3;
		private NcLink.EnhancedComboBox comboBox4;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
