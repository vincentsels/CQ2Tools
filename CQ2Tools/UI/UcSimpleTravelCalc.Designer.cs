namespace CQ2Tools.UI
{
	partial class UcSimpleTravelCalc
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.grpResult = new System.Windows.Forms.GroupBox();
			this.grpTravelCreatures = new System.Windows.Forms.GroupBox();
			this.txtTravelCreatures = new System.Windows.Forms.TextBox();
			this.grpYourCreatures = new System.Windows.Forms.GroupBox();
			this.txtYourCreatures = new System.Windows.Forms.TextBox();
			this.txtWins = new System.Windows.Forms.TextBox();
			this.txtDips = new System.Windows.Forms.TextBox();
			this.txtLosses = new System.Windows.Forms.TextBox();
			this.lblWins = new System.Windows.Forms.Label();
			this.lblDips = new System.Windows.Forms.Label();
			this.lblLosses = new System.Windows.Forms.Label();
			this.lblNotEnoughCreatures = new System.Windows.Forms.Label();
			this.grpResult.SuspendLayout();
			this.grpTravelCreatures.SuspendLayout();
			this.grpYourCreatures.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpResult
			// 
			this.grpResult.Controls.Add(this.lblNotEnoughCreatures);
			this.grpResult.Controls.Add(this.lblLosses);
			this.grpResult.Controls.Add(this.lblDips);
			this.grpResult.Controls.Add(this.lblWins);
			this.grpResult.Controls.Add(this.txtLosses);
			this.grpResult.Controls.Add(this.txtDips);
			this.grpResult.Controls.Add(this.txtWins);
			this.grpResult.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.grpResult.Location = new System.Drawing.Point(0, 208);
			this.grpResult.Name = "grpResult";
			this.grpResult.Size = new System.Drawing.Size(857, 100);
			this.grpResult.TabIndex = 8;
			this.grpResult.TabStop = false;
			this.grpResult.Text = "Result";
			// 
			// grpTravelCreatures
			// 
			this.grpTravelCreatures.Controls.Add(this.txtTravelCreatures);
			this.grpTravelCreatures.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grpTravelCreatures.Location = new System.Drawing.Point(460, 0);
			this.grpTravelCreatures.Name = "grpTravelCreatures";
			this.grpTravelCreatures.Size = new System.Drawing.Size(397, 208);
			this.grpTravelCreatures.TabIndex = 7;
			this.grpTravelCreatures.TabStop = false;
			this.grpTravelCreatures.Text = "Travel creatures";
			// 
			// txtTravelCreatures
			// 
			this.txtTravelCreatures.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtTravelCreatures.Location = new System.Drawing.Point(3, 16);
			this.txtTravelCreatures.Multiline = true;
			this.txtTravelCreatures.Name = "txtTravelCreatures";
			this.txtTravelCreatures.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtTravelCreatures.Size = new System.Drawing.Size(391, 189);
			this.txtTravelCreatures.TabIndex = 0;
			this.txtTravelCreatures.Click += new System.EventHandler(this.txtTravelCreatures_Click);
			this.txtTravelCreatures.TextChanged += new System.EventHandler(this.txtTravelCreatures_TextChanged);
			// 
			// grpYourCreatures
			// 
			this.grpYourCreatures.Controls.Add(this.txtYourCreatures);
			this.grpYourCreatures.Dock = System.Windows.Forms.DockStyle.Left;
			this.grpYourCreatures.Location = new System.Drawing.Point(0, 0);
			this.grpYourCreatures.Name = "grpYourCreatures";
			this.grpYourCreatures.Size = new System.Drawing.Size(460, 208);
			this.grpYourCreatures.TabIndex = 6;
			this.grpYourCreatures.TabStop = false;
			this.grpYourCreatures.Text = "Your creatures";
			// 
			// txtYourCreatures
			// 
			this.txtYourCreatures.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtYourCreatures.Location = new System.Drawing.Point(3, 16);
			this.txtYourCreatures.Multiline = true;
			this.txtYourCreatures.Name = "txtYourCreatures";
			this.txtYourCreatures.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtYourCreatures.Size = new System.Drawing.Size(454, 189);
			this.txtYourCreatures.TabIndex = 0;
			this.txtYourCreatures.TextChanged += new System.EventHandler(this.txtYourCreatures_TextChanged);
			// 
			// txtWins
			// 
			this.txtWins.Location = new System.Drawing.Point(52, 19);
			this.txtWins.Name = "txtWins";
			this.txtWins.ReadOnly = true;
			this.txtWins.Size = new System.Drawing.Size(45, 20);
			this.txtWins.TabIndex = 0;
			// 
			// txtDips
			// 
			this.txtDips.Location = new System.Drawing.Point(52, 45);
			this.txtDips.Name = "txtDips";
			this.txtDips.ReadOnly = true;
			this.txtDips.Size = new System.Drawing.Size(45, 20);
			this.txtDips.TabIndex = 1;
			// 
			// txtLosses
			// 
			this.txtLosses.Location = new System.Drawing.Point(52, 71);
			this.txtLosses.Name = "txtLosses";
			this.txtLosses.ReadOnly = true;
			this.txtLosses.Size = new System.Drawing.Size(45, 20);
			this.txtLosses.TabIndex = 2;
			// 
			// lblWins
			// 
			this.lblWins.AutoSize = true;
			this.lblWins.Location = new System.Drawing.Point(6, 22);
			this.lblWins.Name = "lblWins";
			this.lblWins.Size = new System.Drawing.Size(31, 13);
			this.lblWins.TabIndex = 3;
			this.lblWins.Text = "Wins";
			// 
			// lblDips
			// 
			this.lblDips.AutoSize = true;
			this.lblDips.Location = new System.Drawing.Point(6, 48);
			this.lblDips.Name = "lblDips";
			this.lblDips.Size = new System.Drawing.Size(28, 13);
			this.lblDips.TabIndex = 4;
			this.lblDips.Text = "Dips";
			// 
			// lblLosses
			// 
			this.lblLosses.AutoSize = true;
			this.lblLosses.Location = new System.Drawing.Point(6, 74);
			this.lblLosses.Name = "lblLosses";
			this.lblLosses.Size = new System.Drawing.Size(40, 13);
			this.lblLosses.TabIndex = 5;
			this.lblLosses.Text = "Losses";
			// 
			// lblNotEnoughCreatures
			// 
			this.lblNotEnoughCreatures.AutoSize = true;
			this.lblNotEnoughCreatures.Location = new System.Drawing.Point(103, 22);
			this.lblNotEnoughCreatures.Name = "lblNotEnoughCreatures";
			this.lblNotEnoughCreatures.Size = new System.Drawing.Size(175, 13);
			this.lblNotEnoughCreatures.TabIndex = 6;
			this.lblNotEnoughCreatures.Text = "You do not have enough creatures.";
			this.lblNotEnoughCreatures.Visible = false;
			// 
			// UcSimpleTravelCalc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.grpTravelCreatures);
			this.Controls.Add(this.grpYourCreatures);
			this.Controls.Add(this.grpResult);
			this.Name = "UcSimpleTravelCalc";
			this.Size = new System.Drawing.Size(857, 308);
			this.grpResult.ResumeLayout(false);
			this.grpResult.PerformLayout();
			this.grpTravelCreatures.ResumeLayout(false);
			this.grpTravelCreatures.PerformLayout();
			this.grpYourCreatures.ResumeLayout(false);
			this.grpYourCreatures.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpResult;
		private System.Windows.Forms.GroupBox grpTravelCreatures;
		private System.Windows.Forms.TextBox txtTravelCreatures;
		private System.Windows.Forms.GroupBox grpYourCreatures;
		private System.Windows.Forms.TextBox txtYourCreatures;
		private System.Windows.Forms.TextBox txtLosses;
		private System.Windows.Forms.TextBox txtDips;
		private System.Windows.Forms.TextBox txtWins;
		private System.Windows.Forms.Label lblLosses;
		private System.Windows.Forms.Label lblDips;
		private System.Windows.Forms.Label lblWins;
		private System.Windows.Forms.Label lblNotEnoughCreatures;
	}
}
