namespace CQ2Tools.UI
{
	partial class UcSimpleCalc
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
			this.txtResult = new System.Windows.Forms.TextBox();
			this.grpOpponent = new System.Windows.Forms.GroupBox();
			this.txtOpponent = new System.Windows.Forms.TextBox();
			this.grpYou = new System.Windows.Forms.GroupBox();
			this.txtYou = new System.Windows.Forms.TextBox();
			this.grpResult.SuspendLayout();
			this.grpOpponent.SuspendLayout();
			this.grpYou.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpResult
			// 
			this.grpResult.Controls.Add(this.txtResult);
			this.grpResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grpResult.Location = new System.Drawing.Point(0, 118);
			this.grpResult.Name = "grpResult";
			this.grpResult.Size = new System.Drawing.Size(1059, 208);
			this.grpResult.TabIndex = 5;
			this.grpResult.TabStop = false;
			this.grpResult.Text = "Result";
			// 
			// txtResult
			// 
			this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtResult.Location = new System.Drawing.Point(3, 16);
			this.txtResult.Multiline = true;
			this.txtResult.Name = "txtResult";
			this.txtResult.ReadOnly = true;
			this.txtResult.Size = new System.Drawing.Size(1053, 189);
			this.txtResult.TabIndex = 0;
			// 
			// grpOpponent
			// 
			this.grpOpponent.Controls.Add(this.txtOpponent);
			this.grpOpponent.Dock = System.Windows.Forms.DockStyle.Top;
			this.grpOpponent.Location = new System.Drawing.Point(0, 59);
			this.grpOpponent.Name = "grpOpponent";
			this.grpOpponent.Size = new System.Drawing.Size(1059, 59);
			this.grpOpponent.TabIndex = 4;
			this.grpOpponent.TabStop = false;
			this.grpOpponent.Text = "Opponent\'s creature";
			// 
			// txtOpponent
			// 
			this.txtOpponent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtOpponent.Location = new System.Drawing.Point(3, 16);
			this.txtOpponent.Multiline = true;
			this.txtOpponent.Name = "txtOpponent";
			this.txtOpponent.Size = new System.Drawing.Size(1053, 40);
			this.txtOpponent.TabIndex = 0;
			this.txtOpponent.TextChanged += new System.EventHandler(this.txtOpponent_TextChanged);
			// 
			// grpYou
			// 
			this.grpYou.Controls.Add(this.txtYou);
			this.grpYou.Dock = System.Windows.Forms.DockStyle.Top;
			this.grpYou.Location = new System.Drawing.Point(0, 0);
			this.grpYou.Name = "grpYou";
			this.grpYou.Size = new System.Drawing.Size(1059, 59);
			this.grpYou.TabIndex = 3;
			this.grpYou.TabStop = false;
			this.grpYou.Text = "Your creature";
			// 
			// txtYou
			// 
			this.txtYou.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtYou.Location = new System.Drawing.Point(3, 16);
			this.txtYou.Multiline = true;
			this.txtYou.Name = "txtYou";
			this.txtYou.Size = new System.Drawing.Size(1053, 40);
			this.txtYou.TabIndex = 0;
			this.txtYou.TextChanged += new System.EventHandler(this.txtYou_TextChanged);
			// 
			// UcSimpleCalc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.grpResult);
			this.Controls.Add(this.grpOpponent);
			this.Controls.Add(this.grpYou);
			this.Name = "UcSimpleCalc";
			this.Size = new System.Drawing.Size(1059, 326);
			this.grpResult.ResumeLayout(false);
			this.grpResult.PerformLayout();
			this.grpOpponent.ResumeLayout(false);
			this.grpOpponent.PerformLayout();
			this.grpYou.ResumeLayout(false);
			this.grpYou.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpResult;
		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.GroupBox grpOpponent;
		private System.Windows.Forms.TextBox txtOpponent;
		private System.Windows.Forms.GroupBox grpYou;
		private System.Windows.Forms.TextBox txtYou;
	}
}
