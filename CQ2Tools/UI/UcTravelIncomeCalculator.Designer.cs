namespace CQ2Tools.UI
{
	partial class UcTravelIncomeCalculator
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
			this.grpCurrentResources = new System.Windows.Forms.GroupBox();
			this.txtCurrentResources = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dtpCurrentTime = new System.Windows.Forms.DateTimePicker();
			this.grpStartingResources = new System.Windows.Forms.GroupBox();
			this.txtStartingResources = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnReset = new System.Windows.Forms.Button();
			this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
			this.grpResourcesGained = new System.Windows.Forms.GroupBox();
			this.lblWithoutRudolph = new System.Windows.Forms.Label();
			this.txtTotalResPerHourWithoutRudolph = new System.Windows.Forms.TextBox();
			this.lblPowerPerHour = new System.Windows.Forms.Label();
			this.txtPowerPerHour = new System.Windows.Forms.TextBox();
			this.lblTotalResPerHour = new System.Windows.Forms.Label();
			this.txtTotalResPerHour = new System.Windows.Forms.TextBox();
			this.lblTotalRes = new System.Windows.Forms.Label();
			this.txtTotalRes = new System.Windows.Forms.TextBox();
			this.lblPowerGained = new System.Windows.Forms.Label();
			this.txtPower = new System.Windows.Forms.TextBox();
			this.lblGranGained = new System.Windows.Forms.Label();
			this.txtGran = new System.Windows.Forms.TextBox();
			this.lblEssGained = new System.Windows.Forms.Label();
			this.lblCrysGained = new System.Windows.Forms.Label();
			this.lblBrimGained = new System.Windows.Forms.Label();
			this.txtEss = new System.Windows.Forms.TextBox();
			this.txtCrys = new System.Windows.Forms.TextBox();
			this.txtBrim = new System.Windows.Forms.TextBox();
			this.grpCurrentResources.SuspendLayout();
			this.panel2.SuspendLayout();
			this.grpStartingResources.SuspendLayout();
			this.panel1.SuspendLayout();
			this.grpResourcesGained.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpCurrentResources
			// 
			this.grpCurrentResources.Controls.Add(this.txtCurrentResources);
			this.grpCurrentResources.Controls.Add(this.panel2);
			this.grpCurrentResources.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grpCurrentResources.Location = new System.Drawing.Point(342, 0);
			this.grpCurrentResources.Name = "grpCurrentResources";
			this.grpCurrentResources.Size = new System.Drawing.Size(347, 137);
			this.grpCurrentResources.TabIndex = 10;
			this.grpCurrentResources.TabStop = false;
			this.grpCurrentResources.Text = "Current resources";
			// 
			// txtCurrentResources
			// 
			this.txtCurrentResources.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtCurrentResources.Location = new System.Drawing.Point(3, 16);
			this.txtCurrentResources.Multiline = true;
			this.txtCurrentResources.Name = "txtCurrentResources";
			this.txtCurrentResources.Size = new System.Drawing.Size(341, 87);
			this.txtCurrentResources.TabIndex = 2;
			this.txtCurrentResources.Click += new System.EventHandler(this.txtCurrentResources_Click);
			this.txtCurrentResources.TextChanged += new System.EventHandler(this.txtCurrentResources_TextChanged);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dtpCurrentTime);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(3, 103);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(341, 31);
			this.panel2.TabIndex = 3;
			// 
			// dtpCurrentTime
			// 
			this.dtpCurrentTime.Enabled = false;
			this.dtpCurrentTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtpCurrentTime.Location = new System.Drawing.Point(3, 6);
			this.dtpCurrentTime.Name = "dtpCurrentTime";
			this.dtpCurrentTime.Size = new System.Drawing.Size(86, 20);
			this.dtpCurrentTime.TabIndex = 0;
			// 
			// grpStartingResources
			// 
			this.grpStartingResources.Controls.Add(this.txtStartingResources);
			this.grpStartingResources.Controls.Add(this.panel1);
			this.grpStartingResources.Dock = System.Windows.Forms.DockStyle.Left;
			this.grpStartingResources.Location = new System.Drawing.Point(0, 0);
			this.grpStartingResources.Name = "grpStartingResources";
			this.grpStartingResources.Size = new System.Drawing.Size(342, 137);
			this.grpStartingResources.TabIndex = 9;
			this.grpStartingResources.TabStop = false;
			this.grpStartingResources.Text = "Starting resources";
			// 
			// txtStartingResources
			// 
			this.txtStartingResources.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtStartingResources.Location = new System.Drawing.Point(3, 16);
			this.txtStartingResources.Multiline = true;
			this.txtStartingResources.Name = "txtStartingResources";
			this.txtStartingResources.Size = new System.Drawing.Size(336, 87);
			this.txtStartingResources.TabIndex = 0;
			this.txtStartingResources.TextChanged += new System.EventHandler(this.txtStartingResources_TextChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnReset);
			this.panel1.Controls.Add(this.dtpStartTime);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(3, 103);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(336, 31);
			this.panel1.TabIndex = 1;
			// 
			// btnReset
			// 
			this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.btnReset.Location = new System.Drawing.Point(95, 5);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(238, 23);
			this.btnReset.TabIndex = 1;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// dtpStartTime
			// 
			this.dtpStartTime.Enabled = false;
			this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtpStartTime.Location = new System.Drawing.Point(3, 6);
			this.dtpStartTime.Name = "dtpStartTime";
			this.dtpStartTime.Size = new System.Drawing.Size(86, 20);
			this.dtpStartTime.TabIndex = 0;
			// 
			// grpResourcesGained
			// 
			this.grpResourcesGained.Controls.Add(this.lblWithoutRudolph);
			this.grpResourcesGained.Controls.Add(this.txtTotalResPerHourWithoutRudolph);
			this.grpResourcesGained.Controls.Add(this.lblPowerPerHour);
			this.grpResourcesGained.Controls.Add(this.txtPowerPerHour);
			this.grpResourcesGained.Controls.Add(this.lblTotalResPerHour);
			this.grpResourcesGained.Controls.Add(this.txtTotalResPerHour);
			this.grpResourcesGained.Controls.Add(this.lblTotalRes);
			this.grpResourcesGained.Controls.Add(this.txtTotalRes);
			this.grpResourcesGained.Controls.Add(this.lblPowerGained);
			this.grpResourcesGained.Controls.Add(this.txtPower);
			this.grpResourcesGained.Controls.Add(this.lblGranGained);
			this.grpResourcesGained.Controls.Add(this.txtGran);
			this.grpResourcesGained.Controls.Add(this.lblEssGained);
			this.grpResourcesGained.Controls.Add(this.lblCrysGained);
			this.grpResourcesGained.Controls.Add(this.lblBrimGained);
			this.grpResourcesGained.Controls.Add(this.txtEss);
			this.grpResourcesGained.Controls.Add(this.txtCrys);
			this.grpResourcesGained.Controls.Add(this.txtBrim);
			this.grpResourcesGained.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.grpResourcesGained.Location = new System.Drawing.Point(0, 137);
			this.grpResourcesGained.Name = "grpResourcesGained";
			this.grpResourcesGained.Size = new System.Drawing.Size(689, 151);
			this.grpResourcesGained.TabIndex = 11;
			this.grpResourcesGained.TabStop = false;
			this.grpResourcesGained.Text = "Resources gained";
			// 
			// lblWithoutRudolph
			// 
			this.lblWithoutRudolph.AutoSize = true;
			this.lblWithoutRudolph.Location = new System.Drawing.Point(187, 74);
			this.lblWithoutRudolph.Name = "lblWithoutRudolph";
			this.lblWithoutRudolph.Size = new System.Drawing.Size(103, 13);
			this.lblWithoutRudolph.TabIndex = 23;
			this.lblWithoutRudolph.Text = "Without power trade";
			// 
			// txtTotalResPerHourWithoutRudolph
			// 
			this.txtTotalResPerHourWithoutRudolph.Location = new System.Drawing.Point(315, 71);
			this.txtTotalResPerHourWithoutRudolph.Name = "txtTotalResPerHourWithoutRudolph";
			this.txtTotalResPerHourWithoutRudolph.ReadOnly = true;
			this.txtTotalResPerHourWithoutRudolph.Size = new System.Drawing.Size(87, 20);
			this.txtTotalResPerHourWithoutRudolph.TabIndex = 22;
			// 
			// lblPowerPerHour
			// 
			this.lblPowerPerHour.AutoSize = true;
			this.lblPowerPerHour.Location = new System.Drawing.Point(187, 126);
			this.lblPowerPerHour.Name = "lblPowerPerHour";
			this.lblPowerPerHour.Size = new System.Drawing.Size(79, 13);
			this.lblPowerPerHour.TabIndex = 21;
			this.lblPowerPerHour.Text = "Power per hour";
			// 
			// txtPowerPerHour
			// 
			this.txtPowerPerHour.Location = new System.Drawing.Point(315, 123);
			this.txtPowerPerHour.Name = "txtPowerPerHour";
			this.txtPowerPerHour.ReadOnly = true;
			this.txtPowerPerHour.Size = new System.Drawing.Size(87, 20);
			this.txtPowerPerHour.TabIndex = 20;
			// 
			// lblTotalResPerHour
			// 
			this.lblTotalResPerHour.AutoSize = true;
			this.lblTotalResPerHour.Location = new System.Drawing.Point(187, 48);
			this.lblTotalResPerHour.Name = "lblTotalResPerHour";
			this.lblTotalResPerHour.Size = new System.Drawing.Size(122, 13);
			this.lblTotalResPerHour.TabIndex = 19;
			this.lblTotalResPerHour.Text = "Total resources per hour";
			// 
			// txtTotalResPerHour
			// 
			this.txtTotalResPerHour.Location = new System.Drawing.Point(315, 45);
			this.txtTotalResPerHour.Name = "txtTotalResPerHour";
			this.txtTotalResPerHour.ReadOnly = true;
			this.txtTotalResPerHour.Size = new System.Drawing.Size(87, 20);
			this.txtTotalResPerHour.TabIndex = 18;
			// 
			// lblTotalRes
			// 
			this.lblTotalRes.AutoSize = true;
			this.lblTotalRes.Location = new System.Drawing.Point(187, 22);
			this.lblTotalRes.Name = "lblTotalRes";
			this.lblTotalRes.Size = new System.Drawing.Size(80, 13);
			this.lblTotalRes.TabIndex = 17;
			this.lblTotalRes.Text = "Total resources";
			// 
			// txtTotalRes
			// 
			this.txtTotalRes.Location = new System.Drawing.Point(315, 19);
			this.txtTotalRes.Name = "txtTotalRes";
			this.txtTotalRes.ReadOnly = true;
			this.txtTotalRes.Size = new System.Drawing.Size(87, 20);
			this.txtTotalRes.TabIndex = 16;
			// 
			// lblPowerGained
			// 
			this.lblPowerGained.AutoSize = true;
			this.lblPowerGained.Location = new System.Drawing.Point(6, 126);
			this.lblPowerGained.Name = "lblPowerGained";
			this.lblPowerGained.Size = new System.Drawing.Size(37, 13);
			this.lblPowerGained.TabIndex = 15;
			this.lblPowerGained.Text = "Power";
			// 
			// txtPower
			// 
			this.txtPower.Location = new System.Drawing.Point(78, 123);
			this.txtPower.Name = "txtPower";
			this.txtPower.ReadOnly = true;
			this.txtPower.Size = new System.Drawing.Size(87, 20);
			this.txtPower.TabIndex = 14;
			// 
			// lblGranGained
			// 
			this.lblGranGained.AutoSize = true;
			this.lblGranGained.Location = new System.Drawing.Point(6, 100);
			this.lblGranGained.Name = "lblGranGained";
			this.lblGranGained.Size = new System.Drawing.Size(41, 13);
			this.lblGranGained.TabIndex = 13;
			this.lblGranGained.Text = "Granite";
			// 
			// txtGran
			// 
			this.txtGran.Location = new System.Drawing.Point(78, 97);
			this.txtGran.Name = "txtGran";
			this.txtGran.ReadOnly = true;
			this.txtGran.Size = new System.Drawing.Size(87, 20);
			this.txtGran.TabIndex = 12;
			// 
			// lblEssGained
			// 
			this.lblEssGained.AutoSize = true;
			this.lblEssGained.Location = new System.Drawing.Point(6, 74);
			this.lblEssGained.Name = "lblEssGained";
			this.lblEssGained.Size = new System.Drawing.Size(48, 13);
			this.lblEssGained.TabIndex = 11;
			this.lblEssGained.Text = "Essence";
			// 
			// lblCrysGained
			// 
			this.lblCrysGained.AutoSize = true;
			this.lblCrysGained.Location = new System.Drawing.Point(6, 48);
			this.lblCrysGained.Name = "lblCrysGained";
			this.lblCrysGained.Size = new System.Drawing.Size(38, 13);
			this.lblCrysGained.TabIndex = 10;
			this.lblCrysGained.Text = "Crystal";
			// 
			// lblBrimGained
			// 
			this.lblBrimGained.AutoSize = true;
			this.lblBrimGained.Location = new System.Drawing.Point(6, 22);
			this.lblBrimGained.Name = "lblBrimGained";
			this.lblBrimGained.Size = new System.Drawing.Size(53, 13);
			this.lblBrimGained.TabIndex = 9;
			this.lblBrimGained.Text = "Brimstone";
			// 
			// txtEss
			// 
			this.txtEss.Location = new System.Drawing.Point(78, 71);
			this.txtEss.Name = "txtEss";
			this.txtEss.ReadOnly = true;
			this.txtEss.Size = new System.Drawing.Size(87, 20);
			this.txtEss.TabIndex = 8;
			// 
			// txtCrys
			// 
			this.txtCrys.Location = new System.Drawing.Point(78, 45);
			this.txtCrys.Name = "txtCrys";
			this.txtCrys.ReadOnly = true;
			this.txtCrys.Size = new System.Drawing.Size(87, 20);
			this.txtCrys.TabIndex = 7;
			// 
			// txtBrim
			// 
			this.txtBrim.Location = new System.Drawing.Point(78, 19);
			this.txtBrim.Name = "txtBrim";
			this.txtBrim.ReadOnly = true;
			this.txtBrim.Size = new System.Drawing.Size(87, 20);
			this.txtBrim.TabIndex = 6;
			// 
			// UcTravelIncomeCalculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.grpCurrentResources);
			this.Controls.Add(this.grpStartingResources);
			this.Controls.Add(this.grpResourcesGained);
			this.Name = "UcTravelIncomeCalculator";
			this.Size = new System.Drawing.Size(689, 288);
			this.grpCurrentResources.ResumeLayout(false);
			this.grpCurrentResources.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.grpStartingResources.ResumeLayout(false);
			this.grpStartingResources.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.grpResourcesGained.ResumeLayout(false);
			this.grpResourcesGained.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpCurrentResources;
		private System.Windows.Forms.GroupBox grpStartingResources;
		private System.Windows.Forms.TextBox txtStartingResources;
		private System.Windows.Forms.GroupBox grpResourcesGained;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.DateTimePicker dtpStartTime;
		private System.Windows.Forms.TextBox txtCurrentResources;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DateTimePicker dtpCurrentTime;
		private System.Windows.Forms.Label lblPowerGained;
		private System.Windows.Forms.TextBox txtPower;
		private System.Windows.Forms.Label lblGranGained;
		private System.Windows.Forms.TextBox txtGran;
		private System.Windows.Forms.Label lblEssGained;
		private System.Windows.Forms.Label lblCrysGained;
		private System.Windows.Forms.Label lblBrimGained;
		private System.Windows.Forms.TextBox txtEss;
		private System.Windows.Forms.TextBox txtCrys;
		private System.Windows.Forms.TextBox txtBrim;
		private System.Windows.Forms.Label lblTotalRes;
		private System.Windows.Forms.TextBox txtTotalRes;
		private System.Windows.Forms.Label lblTotalResPerHour;
		private System.Windows.Forms.TextBox txtTotalResPerHour;
		private System.Windows.Forms.Label lblWithoutRudolph;
		private System.Windows.Forms.TextBox txtTotalResPerHourWithoutRudolph;
		private System.Windows.Forms.Label lblPowerPerHour;
		private System.Windows.Forms.TextBox txtPowerPerHour;
	}
}
