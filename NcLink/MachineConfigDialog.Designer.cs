/*
 * Created by SharpDevelop.
 * User: Adam
 * Date: 20/02/2014
 * Time: 00:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NcLink
{
	partial class MachineConfigDialog
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 17;
			this.listBox1.Items.AddRange(new object[] {
									"Serial port",
									"Folders",
									"Transmit",
									"Receive"});
			this.listBox1.Location = new System.Drawing.Point(0, 0);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(137, 391);
			this.listBox1.TabIndex = 0;
			// 
			// MachineConfigDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(719, 391);
			this.Controls.Add(this.listBox1);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "MachineConfigDialog";
			this.Text = "Machine configuration";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ListBox listBox1;
	}
}
