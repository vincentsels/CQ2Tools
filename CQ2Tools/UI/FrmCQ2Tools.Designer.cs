namespace CQ2Tools.UI
{
	partial class FrmCQ2Tools
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCQ2Tools));
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabSimpleCalc = new System.Windows.Forms.TabPage();
			this.clipboardMonitor1 = new CQ2Tools.Controls.ClipboardMonitor();
			this.ucSimpleCalc1 = new CQ2Tools.UI.UcSimpleCalc();
			this.tabSimpleTravelCalc = new System.Windows.Forms.TabPage();
			this.ucSimpleTravelCalc1 = new CQ2Tools.UI.UcSimpleTravelCalc();
			this.tabTravelIncomeCalculator = new System.Windows.Forms.TabPage();
			this.ucTravelIncomeCalculator1 = new CQ2Tools.UI.UcTravelIncomeCalculator();
			this.grpOptions = new System.Windows.Forms.GroupBox();
			this.chkSetFocusAfterCopy = new System.Windows.Forms.CheckBox();
			this.chkInterpretClipboard = new System.Windows.Forms.CheckBox();
			this.chkAutoReadClipboard = new System.Windows.Forms.CheckBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.optionsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.travelmodeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toggleTravelmodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.travelModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ucTravelMode1 = new CQ2Tools.UI.UcTravelMode();
			this.tabControl.SuspendLayout();
			this.tabSimpleCalc.SuspendLayout();
			this.tabSimpleTravelCalc.SuspendLayout();
			this.tabTravelIncomeCalculator.SuspendLayout();
			this.grpOptions.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabSimpleCalc);
			this.tabControl.Controls.Add(this.tabSimpleTravelCalc);
			this.tabControl.Controls.Add(this.tabTravelIncomeCalculator);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 24);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(889, 333);
			this.tabControl.TabIndex = 0;
			// 
			// tabSimpleCalc
			// 
			this.tabSimpleCalc.Controls.Add(this.clipboardMonitor1);
			this.tabSimpleCalc.Controls.Add(this.ucSimpleCalc1);
			this.tabSimpleCalc.Location = new System.Drawing.Point(4, 22);
			this.tabSimpleCalc.Name = "tabSimpleCalc";
			this.tabSimpleCalc.Padding = new System.Windows.Forms.Padding(3);
			this.tabSimpleCalc.Size = new System.Drawing.Size(881, 307);
			this.tabSimpleCalc.TabIndex = 0;
			this.tabSimpleCalc.Text = "Simple calc";
			this.tabSimpleCalc.UseVisualStyleBackColor = true;
			// 
			// clipboardMonitor1
			// 
			this.clipboardMonitor1.BackColor = System.Drawing.Color.Red;
			this.clipboardMonitor1.Location = new System.Drawing.Point(378, 189);
			this.clipboardMonitor1.Name = "clipboardMonitor1";
			this.clipboardMonitor1.Size = new System.Drawing.Size(75, 23);
			this.clipboardMonitor1.TabIndex = 1;
			this.clipboardMonitor1.Text = "clipboardMonitor1";
			this.clipboardMonitor1.Visible = false;
			this.clipboardMonitor1.ClipboardChanged += new System.EventHandler<CQ2Tools.Controls.ClipboardChangedEventArgs>(this.clipboardMonitor1_ClipboardChanged);
			// 
			// ucSimpleCalc1
			// 
			this.ucSimpleCalc1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucSimpleCalc1.Location = new System.Drawing.Point(3, 3);
			this.ucSimpleCalc1.Name = "ucSimpleCalc1";
			this.ucSimpleCalc1.Size = new System.Drawing.Size(875, 301);
			this.ucSimpleCalc1.TabIndex = 0;
			// 
			// tabSimpleTravelCalc
			// 
			this.tabSimpleTravelCalc.Controls.Add(this.ucSimpleTravelCalc1);
			this.tabSimpleTravelCalc.Location = new System.Drawing.Point(4, 22);
			this.tabSimpleTravelCalc.Name = "tabSimpleTravelCalc";
			this.tabSimpleTravelCalc.Padding = new System.Windows.Forms.Padding(3);
			this.tabSimpleTravelCalc.Size = new System.Drawing.Size(881, 307);
			this.tabSimpleTravelCalc.TabIndex = 1;
			this.tabSimpleTravelCalc.Text = "Simple travel calc";
			this.tabSimpleTravelCalc.UseVisualStyleBackColor = true;
			// 
			// ucSimpleTravelCalc1
			// 
			this.ucSimpleTravelCalc1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucSimpleTravelCalc1.Location = new System.Drawing.Point(3, 3);
			this.ucSimpleTravelCalc1.Name = "ucSimpleTravelCalc1";
			this.ucSimpleTravelCalc1.Size = new System.Drawing.Size(875, 301);
			this.ucSimpleTravelCalc1.TabIndex = 0;
			// 
			// tabTravelIncomeCalculator
			// 
			this.tabTravelIncomeCalculator.Controls.Add(this.ucTravelIncomeCalculator1);
			this.tabTravelIncomeCalculator.Location = new System.Drawing.Point(4, 22);
			this.tabTravelIncomeCalculator.Name = "tabTravelIncomeCalculator";
			this.tabTravelIncomeCalculator.Padding = new System.Windows.Forms.Padding(3);
			this.tabTravelIncomeCalculator.Size = new System.Drawing.Size(881, 307);
			this.tabTravelIncomeCalculator.TabIndex = 2;
			this.tabTravelIncomeCalculator.Text = "Travel income calc";
			this.tabTravelIncomeCalculator.UseVisualStyleBackColor = true;
			// 
			// ucTravelIncomeCalculator1
			// 
			this.ucTravelIncomeCalculator1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucTravelIncomeCalculator1.Location = new System.Drawing.Point(3, 3);
			this.ucTravelIncomeCalculator1.Name = "ucTravelIncomeCalculator1";
			this.ucTravelIncomeCalculator1.Size = new System.Drawing.Size(875, 301);
			this.ucTravelIncomeCalculator1.TabIndex = 0;
			// 
			// grpOptions
			// 
			this.grpOptions.Controls.Add(this.chkSetFocusAfterCopy);
			this.grpOptions.Controls.Add(this.chkInterpretClipboard);
			this.grpOptions.Controls.Add(this.chkAutoReadClipboard);
			this.grpOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.grpOptions.Location = new System.Drawing.Point(0, 357);
			this.grpOptions.Name = "grpOptions";
			this.grpOptions.Size = new System.Drawing.Size(889, 68);
			this.grpOptions.TabIndex = 1;
			this.grpOptions.TabStop = false;
			this.grpOptions.Text = "Options";
			this.grpOptions.Visible = false;
			// 
			// chkSetFocusAfterCopy
			// 
			this.chkSetFocusAfterCopy.AutoSize = true;
			this.chkSetFocusAfterCopy.Checked = true;
			this.chkSetFocusAfterCopy.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkSetFocusAfterCopy.Location = new System.Drawing.Point(329, 42);
			this.chkSetFocusAfterCopy.Name = "chkSetFocusAfterCopy";
			this.chkSetFocusAfterCopy.Size = new System.Drawing.Size(343, 17);
			this.chkSetFocusAfterCopy.TabIndex = 2;
			this.chkSetFocusAfterCopy.Text = "Bring CQ2Tools to front when CQ2 content was copied to clipboard";
			this.chkSetFocusAfterCopy.UseVisualStyleBackColor = true;
			// 
			// chkInterpretClipboard
			// 
			this.chkInterpretClipboard.AutoSize = true;
			this.chkInterpretClipboard.Checked = true;
			this.chkInterpretClipboard.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkInterpretClipboard.Location = new System.Drawing.Point(12, 42);
			this.chkInterpretClipboard.Name = "chkInterpretClipboard";
			this.chkInterpretClipboard.Size = new System.Drawing.Size(311, 17);
			this.chkInterpretClipboard.TabIndex = 1;
			this.chkInterpretClipboard.Text = "Automatically interpret clipboard content to select correct tab";
			this.chkInterpretClipboard.UseVisualStyleBackColor = true;
			// 
			// chkAutoReadClipboard
			// 
			this.chkAutoReadClipboard.AutoSize = true;
			this.chkAutoReadClipboard.Checked = true;
			this.chkAutoReadClipboard.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkAutoReadClipboard.Location = new System.Drawing.Point(12, 19);
			this.chkAutoReadClipboard.Name = "chkAutoReadClipboard";
			this.chkAutoReadClipboard.Size = new System.Drawing.Size(181, 17);
			this.chkAutoReadClipboard.TabIndex = 0;
			this.chkAutoReadClipboard.Text = "Automatically read from clipboard";
			this.chkAutoReadClipboard.UseVisualStyleBackColor = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem2,
            this.travelmodeToolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(889, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// optionsToolStripMenuItem2
			// 
			this.optionsToolStripMenuItem2.Name = "optionsToolStripMenuItem2";
			this.optionsToolStripMenuItem2.Size = new System.Drawing.Size(61, 20);
			this.optionsToolStripMenuItem2.Text = "Options";
			this.optionsToolStripMenuItem2.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
			// 
			// travelmodeToolStripMenuItem1
			// 
			this.travelmodeToolStripMenuItem1.Name = "travelmodeToolStripMenuItem1";
			this.travelmodeToolStripMenuItem1.Size = new System.Drawing.Size(87, 20);
			this.travelmodeToolStripMenuItem1.Text = "Travel-mode";
			this.travelmodeToolStripMenuItem1.Click += new System.EventHandler(this.toggleTravelmodeToolStripMenuItem_Click);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.optionsToolStripMenuItem.Text = "Options";
			this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
			// 
			// toggleTravelmodeToolStripMenuItem
			// 
			this.toggleTravelmodeToolStripMenuItem.Name = "toggleTravelmodeToolStripMenuItem";
			this.toggleTravelmodeToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
			this.toggleTravelmodeToolStripMenuItem.Text = "Travel-mode";
			this.toggleTravelmodeToolStripMenuItem.Click += new System.EventHandler(this.toggleTravelmodeToolStripMenuItem_Click);
			// 
			// optionsToolStripMenuItem1
			// 
			this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
			this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
			this.optionsToolStripMenuItem1.Text = "Options";
			this.optionsToolStripMenuItem1.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
			// 
			// travelModeToolStripMenuItem
			// 
			this.travelModeToolStripMenuItem.Name = "travelModeToolStripMenuItem";
			this.travelModeToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
			this.travelModeToolStripMenuItem.Text = "Travel mode";
			this.travelModeToolStripMenuItem.Click += new System.EventHandler(this.toggleTravelmodeToolStripMenuItem_Click);
			// 
			// ucTravelMode1
			// 
			this.ucTravelMode1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucTravelMode1.Location = new System.Drawing.Point(0, 24);
			this.ucTravelMode1.MaximumSize = new System.Drawing.Size(204, 248);
			this.ucTravelMode1.MinimumSize = new System.Drawing.Size(204, 248);
			this.ucTravelMode1.Name = "ucTravelMode1";
			this.ucTravelMode1.Size = new System.Drawing.Size(204, 248);
			this.ucTravelMode1.TabIndex = 3;
			this.ucTravelMode1.Visible = false;
			// 
			// FrmCQ2Tools
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(889, 425);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.grpOptions);
			this.Controls.Add(this.ucTravelMode1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FrmCQ2Tools";
			this.Text = "CQ2Tools 1.6";
			this.tabControl.ResumeLayout(false);
			this.tabSimpleCalc.ResumeLayout(false);
			this.tabSimpleTravelCalc.ResumeLayout(false);
			this.tabTravelIncomeCalculator.ResumeLayout(false);
			this.grpOptions.ResumeLayout(false);
			this.grpOptions.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabSimpleCalc;
		private UcSimpleCalc ucSimpleCalc1;
		private System.Windows.Forms.TabPage tabSimpleTravelCalc;
		private UcSimpleTravelCalc ucSimpleTravelCalc1;
		private System.Windows.Forms.TabPage tabTravelIncomeCalculator;
		private UcTravelIncomeCalculator ucTravelIncomeCalculator1;
		private Controls.ClipboardMonitor clipboardMonitor1;
		private System.Windows.Forms.GroupBox grpOptions;
		private System.Windows.Forms.CheckBox chkInterpretClipboard;
		private System.Windows.Forms.CheckBox chkAutoReadClipboard;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.CheckBox chkSetFocusAfterCopy;
		private System.Windows.Forms.ToolStripMenuItem toggleTravelmodeToolStripMenuItem;
		private UcTravelMode ucTravelMode1;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem travelModeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem travelmodeToolStripMenuItem1;
	}
}

