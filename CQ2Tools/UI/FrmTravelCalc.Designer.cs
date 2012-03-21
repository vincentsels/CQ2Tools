namespace CQ2Tools.UI
{
	partial class FrmTravelCalc
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTravelCalc));
			this.clipboardMonitor1 = new CQ2Tools.Controls.ClipboardMonitor();
			this.ucTravelMode1 = new CQ2Tools.UI.UcTravelCalc();
			this.SuspendLayout();
			// 
			// clipboardMonitor1
			// 
			this.clipboardMonitor1.BackColor = System.Drawing.Color.Red;
			this.clipboardMonitor1.Location = new System.Drawing.Point(12, 22);
			this.clipboardMonitor1.Name = "clipboardMonitor1";
			this.clipboardMonitor1.Size = new System.Drawing.Size(25, 23);
			this.clipboardMonitor1.TabIndex = 1;
			this.clipboardMonitor1.Text = "clipboardMonitor1";
			this.clipboardMonitor1.Visible = false;
			// 
			// ucTravelMode1
			// 
			this.ucTravelMode1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucTravelMode1.Location = new System.Drawing.Point(0, 0);
			this.ucTravelMode1.MaximumSize = new System.Drawing.Size(204, 248);
			this.ucTravelMode1.MinimumSize = new System.Drawing.Size(204, 248);
			this.ucTravelMode1.Name = "ucTravelMode1";
			this.ucTravelMode1.Size = new System.Drawing.Size(204, 248);
			this.ucTravelMode1.TabIndex = 0;
			// 
			// FrmTravelCalc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(204, 246);
			this.Controls.Add(this.clipboardMonitor1);
			this.Controls.Add(this.ucTravelMode1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(220, 282);
			this.Name = "FrmTravelCalc";
			this.Text = "WCS Calc 2.2";
			this.ResumeLayout(false);

		}

		#endregion

		private UcTravelCalc ucTravelMode1;
		private Controls.ClipboardMonitor clipboardMonitor1;
	}
}