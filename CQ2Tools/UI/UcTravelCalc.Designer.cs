namespace CQ2Tools.UI
{
	partial class UcTravelCalc
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
			this.components = new System.ComponentModel.Container();
			this.lblYourCreatures = new System.Windows.Forms.Label();
			this.txtYourCreatures = new System.Windows.Forms.TextBox();
			this.txtTravelCreatures = new System.Windows.Forms.TextBox();
			this.lblTravelCreatures = new System.Windows.Forms.Label();
			this.txtYourCritCount = new System.Windows.Forms.TextBox();
			this.txtTravelCritCount = new System.Windows.Forms.TextBox();
			this.pnlTravelCalc = new System.Windows.Forms.Panel();
			this.txtTravelResult = new System.Windows.Forms.TextBox();
			this.grpResources = new System.Windows.Forms.GroupBox();
			this.dtpCurrentTime = new System.Windows.Forms.DateTimePicker();
			this.txtCurrentResources = new System.Windows.Forms.TextBox();
			this.lblCurrent = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
			this.txtStartingResources = new System.Windows.Forms.TextBox();
			this.lblStarting = new System.Windows.Forms.Label();
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
			this.toolTipYourCreatures = new System.Windows.Forms.ToolTip(this.components);
			this.toolTipTravelEncounter = new System.Windows.Forms.ToolTip(this.components);
			this.toolTipBattleResult = new System.Windows.Forms.ToolTip(this.components);
			this.pnlTravelCalc.SuspendLayout();
			this.grpResources.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblYourCreatures
			// 
			this.lblYourCreatures.AutoSize = true;
			this.lblYourCreatures.Location = new System.Drawing.Point(4, 8);
			this.lblYourCreatures.Name = "lblYourCreatures";
			this.lblYourCreatures.Size = new System.Drawing.Size(76, 13);
			this.lblYourCreatures.TabIndex = 0;
			this.lblYourCreatures.Text = "Your creatures";
			// 
			// txtYourCreatures
			// 
			this.txtYourCreatures.Location = new System.Drawing.Point(98, 5);
			this.txtYourCreatures.Multiline = true;
			this.txtYourCreatures.Name = "txtYourCreatures";
			this.txtYourCreatures.Size = new System.Drawing.Size(66, 20);
			this.txtYourCreatures.TabIndex = 1;
			this.txtYourCreatures.Click += new System.EventHandler(this.txtTextBox_Click);
			this.txtYourCreatures.TextChanged += new System.EventHandler(this.txtYourCreatures_TextChanged);
			// 
			// txtTravelCreatures
			// 
			this.txtTravelCreatures.Location = new System.Drawing.Point(98, 26);
			this.txtTravelCreatures.Multiline = true;
			this.txtTravelCreatures.Name = "txtTravelCreatures";
			this.txtTravelCreatures.Size = new System.Drawing.Size(66, 20);
			this.txtTravelCreatures.TabIndex = 2;
			this.txtTravelCreatures.Click += new System.EventHandler(this.txtTextBox_Click);
			this.txtTravelCreatures.TextChanged += new System.EventHandler(this.txtTravelCreatures_TextChanged);
			// 
			// lblTravelCreatures
			// 
			this.lblTravelCreatures.AutoSize = true;
			this.lblTravelCreatures.Location = new System.Drawing.Point(4, 29);
			this.lblTravelCreatures.Name = "lblTravelCreatures";
			this.lblTravelCreatures.Size = new System.Drawing.Size(88, 13);
			this.lblTravelCreatures.TabIndex = 3;
			this.lblTravelCreatures.Text = "Travel encounter";
			// 
			// txtYourCritCount
			// 
			this.txtYourCritCount.Location = new System.Drawing.Point(170, 5);
			this.txtYourCritCount.Multiline = true;
			this.txtYourCritCount.Name = "txtYourCritCount";
			this.txtYourCritCount.ReadOnly = true;
			this.txtYourCritCount.Size = new System.Drawing.Size(28, 20);
			this.txtYourCritCount.TabIndex = 4;
			// 
			// txtTravelCritCount
			// 
			this.txtTravelCritCount.Location = new System.Drawing.Point(170, 26);
			this.txtTravelCritCount.Multiline = true;
			this.txtTravelCritCount.Name = "txtTravelCritCount";
			this.txtTravelCritCount.ReadOnly = true;
			this.txtTravelCritCount.Size = new System.Drawing.Size(28, 20);
			this.txtTravelCritCount.TabIndex = 5;
			// 
			// pnlTravelCalc
			// 
			this.pnlTravelCalc.Controls.Add(this.txtTravelResult);
			this.pnlTravelCalc.Controls.Add(this.txtYourCreatures);
			this.pnlTravelCalc.Controls.Add(this.txtTravelCritCount);
			this.pnlTravelCalc.Controls.Add(this.lblYourCreatures);
			this.pnlTravelCalc.Controls.Add(this.txtYourCritCount);
			this.pnlTravelCalc.Controls.Add(this.txtTravelCreatures);
			this.pnlTravelCalc.Controls.Add(this.lblTravelCreatures);
			this.pnlTravelCalc.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTravelCalc.Location = new System.Drawing.Point(0, 0);
			this.pnlTravelCalc.Name = "pnlTravelCalc";
			this.pnlTravelCalc.Size = new System.Drawing.Size(204, 69);
			this.pnlTravelCalc.TabIndex = 6;
			// 
			// txtTravelResult
			// 
			this.txtTravelResult.Location = new System.Drawing.Point(7, 47);
			this.txtTravelResult.Multiline = true;
			this.txtTravelResult.Name = "txtTravelResult";
			this.txtTravelResult.Size = new System.Drawing.Size(191, 20);
			this.txtTravelResult.TabIndex = 6;
			// 
			// grpResources
			// 
			this.grpResources.Controls.Add(this.dtpCurrentTime);
			this.grpResources.Controls.Add(this.txtCurrentResources);
			this.grpResources.Controls.Add(this.lblCurrent);
			this.grpResources.Controls.Add(this.btnReset);
			this.grpResources.Controls.Add(this.dtpStartTime);
			this.grpResources.Controls.Add(this.txtStartingResources);
			this.grpResources.Controls.Add(this.lblStarting);
			this.grpResources.Controls.Add(this.lblWithoutRudolph);
			this.grpResources.Controls.Add(this.txtTotalResPerHourWithoutRudolph);
			this.grpResources.Controls.Add(this.lblPowerPerHour);
			this.grpResources.Controls.Add(this.txtPowerPerHour);
			this.grpResources.Controls.Add(this.lblTotalResPerHour);
			this.grpResources.Controls.Add(this.txtTotalResPerHour);
			this.grpResources.Controls.Add(this.lblTotalRes);
			this.grpResources.Controls.Add(this.txtTotalRes);
			this.grpResources.Controls.Add(this.lblPowerGained);
			this.grpResources.Controls.Add(this.txtPower);
			this.grpResources.Controls.Add(this.lblGranGained);
			this.grpResources.Controls.Add(this.txtGran);
			this.grpResources.Controls.Add(this.lblEssGained);
			this.grpResources.Controls.Add(this.lblCrysGained);
			this.grpResources.Controls.Add(this.lblBrimGained);
			this.grpResources.Controls.Add(this.txtEss);
			this.grpResources.Controls.Add(this.txtCrys);
			this.grpResources.Controls.Add(this.txtBrim);
			this.grpResources.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grpResources.Location = new System.Drawing.Point(0, 69);
			this.grpResources.Name = "grpResources";
			this.grpResources.Size = new System.Drawing.Size(204, 179);
			this.grpResources.TabIndex = 12;
			this.grpResources.TabStop = false;
			this.grpResources.Text = "Resources";
			// 
			// dtpCurrentTime
			// 
			this.dtpCurrentTime.Enabled = false;
			this.dtpCurrentTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtpCurrentTime.Location = new System.Drawing.Point(100, 41);
			this.dtpCurrentTime.Name = "dtpCurrentTime";
			this.dtpCurrentTime.Size = new System.Drawing.Size(64, 20);
			this.dtpCurrentTime.TabIndex = 30;
			// 
			// txtCurrentResources
			// 
			this.txtCurrentResources.Location = new System.Drawing.Point(53, 41);
			this.txtCurrentResources.Multiline = true;
			this.txtCurrentResources.Name = "txtCurrentResources";
			this.txtCurrentResources.Size = new System.Drawing.Size(39, 20);
			this.txtCurrentResources.TabIndex = 29;
			this.txtCurrentResources.Click += new System.EventHandler(this.txtTextBox_Click);
			this.txtCurrentResources.TextChanged += new System.EventHandler(this.txtCurrentResources_TextChanged);
			// 
			// lblCurrent
			// 
			this.lblCurrent.AutoSize = true;
			this.lblCurrent.Location = new System.Drawing.Point(4, 44);
			this.lblCurrent.Name = "lblCurrent";
			this.lblCurrent.Size = new System.Drawing.Size(41, 13);
			this.lblCurrent.TabIndex = 28;
			this.lblCurrent.Text = "Current";
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(170, 17);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(28, 23);
			this.btnReset.TabIndex = 27;
			this.btnReset.Text = "R";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// dtpStartTime
			// 
			this.dtpStartTime.Enabled = false;
			this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtpStartTime.Location = new System.Drawing.Point(100, 19);
			this.dtpStartTime.Name = "dtpStartTime";
			this.dtpStartTime.Size = new System.Drawing.Size(64, 20);
			this.dtpStartTime.TabIndex = 26;
			// 
			// txtStartingResources
			// 
			this.txtStartingResources.Location = new System.Drawing.Point(53, 19);
			this.txtStartingResources.Multiline = true;
			this.txtStartingResources.Name = "txtStartingResources";
			this.txtStartingResources.Size = new System.Drawing.Size(39, 20);
			this.txtStartingResources.TabIndex = 25;
			this.txtStartingResources.Click += new System.EventHandler(this.txtTextBox_Click);
			this.txtStartingResources.TextChanged += new System.EventHandler(this.txtStartingResources_TextChanged);
			// 
			// lblStarting
			// 
			this.lblStarting.AutoSize = true;
			this.lblStarting.Location = new System.Drawing.Point(4, 22);
			this.lblStarting.Name = "lblStarting";
			this.lblStarting.Size = new System.Drawing.Size(43, 13);
			this.lblStarting.TabIndex = 24;
			this.lblStarting.Text = "Starting";
			// 
			// lblWithoutRudolph
			// 
			this.lblWithoutRudolph.AutoSize = true;
			this.lblWithoutRudolph.Location = new System.Drawing.Point(95, 114);
			this.lblWithoutRudolph.Name = "lblWithoutRudolph";
			this.lblWithoutRudolph.Size = new System.Drawing.Size(43, 13);
			this.lblWithoutRudolph.TabIndex = 23;
			this.lblWithoutRudolph.Text = "+Power";
			// 
			// txtTotalResPerHourWithoutRudolph
			// 
			this.txtTotalResPerHourWithoutRudolph.Location = new System.Drawing.Point(144, 111);
			this.txtTotalResPerHourWithoutRudolph.Name = "txtTotalResPerHourWithoutRudolph";
			this.txtTotalResPerHourWithoutRudolph.ReadOnly = true;
			this.txtTotalResPerHourWithoutRudolph.Size = new System.Drawing.Size(54, 20);
			this.txtTotalResPerHourWithoutRudolph.TabIndex = 22;
			// 
			// lblPowerPerHour
			// 
			this.lblPowerPerHour.AutoSize = true;
			this.lblPowerPerHour.Location = new System.Drawing.Point(95, 158);
			this.lblPowerPerHour.Name = "lblPowerPerHour";
			this.lblPowerPerHour.Size = new System.Drawing.Size(38, 13);
			this.lblPowerPerHour.TabIndex = 21;
			this.lblPowerPerHour.Text = "/ Hour";
			// 
			// txtPowerPerHour
			// 
			this.txtPowerPerHour.Location = new System.Drawing.Point(144, 153);
			this.txtPowerPerHour.Name = "txtPowerPerHour";
			this.txtPowerPerHour.ReadOnly = true;
			this.txtPowerPerHour.Size = new System.Drawing.Size(54, 20);
			this.txtPowerPerHour.TabIndex = 20;
			// 
			// lblTotalResPerHour
			// 
			this.lblTotalResPerHour.AutoSize = true;
			this.lblTotalResPerHour.Location = new System.Drawing.Point(93, 92);
			this.lblTotalResPerHour.Name = "lblTotalResPerHour";
			this.lblTotalResPerHour.Size = new System.Drawing.Size(38, 13);
			this.lblTotalResPerHour.TabIndex = 19;
			this.lblTotalResPerHour.Text = "/ Hour";
			// 
			// txtTotalResPerHour
			// 
			this.txtTotalResPerHour.Location = new System.Drawing.Point(144, 89);
			this.txtTotalResPerHour.Name = "txtTotalResPerHour";
			this.txtTotalResPerHour.ReadOnly = true;
			this.txtTotalResPerHour.Size = new System.Drawing.Size(54, 20);
			this.txtTotalResPerHour.TabIndex = 18;
			// 
			// lblTotalRes
			// 
			this.lblTotalRes.AutoSize = true;
			this.lblTotalRes.Location = new System.Drawing.Point(93, 70);
			this.lblTotalRes.Name = "lblTotalRes";
			this.lblTotalRes.Size = new System.Drawing.Size(31, 13);
			this.lblTotalRes.TabIndex = 17;
			this.lblTotalRes.Text = "Total";
			// 
			// txtTotalRes
			// 
			this.txtTotalRes.Location = new System.Drawing.Point(144, 67);
			this.txtTotalRes.Name = "txtTotalRes";
			this.txtTotalRes.ReadOnly = true;
			this.txtTotalRes.Size = new System.Drawing.Size(54, 20);
			this.txtTotalRes.TabIndex = 16;
			// 
			// lblPowerGained
			// 
			this.lblPowerGained.AutoSize = true;
			this.lblPowerGained.Location = new System.Drawing.Point(6, 158);
			this.lblPowerGained.Name = "lblPowerGained";
			this.lblPowerGained.Size = new System.Drawing.Size(14, 13);
			this.lblPowerGained.TabIndex = 15;
			this.lblPowerGained.Text = "P";
			// 
			// txtPower
			// 
			this.txtPower.Location = new System.Drawing.Point(26, 155);
			this.txtPower.Name = "txtPower";
			this.txtPower.ReadOnly = true;
			this.txtPower.Size = new System.Drawing.Size(54, 20);
			this.txtPower.TabIndex = 14;
			// 
			// lblGranGained
			// 
			this.lblGranGained.AutoSize = true;
			this.lblGranGained.Location = new System.Drawing.Point(6, 136);
			this.lblGranGained.Name = "lblGranGained";
			this.lblGranGained.Size = new System.Drawing.Size(15, 13);
			this.lblGranGained.TabIndex = 13;
			this.lblGranGained.Text = "G";
			// 
			// txtGran
			// 
			this.txtGran.Location = new System.Drawing.Point(26, 133);
			this.txtGran.Name = "txtGran";
			this.txtGran.ReadOnly = true;
			this.txtGran.Size = new System.Drawing.Size(54, 20);
			this.txtGran.TabIndex = 12;
			// 
			// lblEssGained
			// 
			this.lblEssGained.AutoSize = true;
			this.lblEssGained.Location = new System.Drawing.Point(6, 114);
			this.lblEssGained.Name = "lblEssGained";
			this.lblEssGained.Size = new System.Drawing.Size(14, 13);
			this.lblEssGained.TabIndex = 11;
			this.lblEssGained.Text = "E";
			// 
			// lblCrysGained
			// 
			this.lblCrysGained.AutoSize = true;
			this.lblCrysGained.Location = new System.Drawing.Point(6, 92);
			this.lblCrysGained.Name = "lblCrysGained";
			this.lblCrysGained.Size = new System.Drawing.Size(14, 13);
			this.lblCrysGained.TabIndex = 10;
			this.lblCrysGained.Text = "C";
			// 
			// lblBrimGained
			// 
			this.lblBrimGained.AutoSize = true;
			this.lblBrimGained.Location = new System.Drawing.Point(6, 70);
			this.lblBrimGained.Name = "lblBrimGained";
			this.lblBrimGained.Size = new System.Drawing.Size(14, 13);
			this.lblBrimGained.TabIndex = 9;
			this.lblBrimGained.Text = "B";
			// 
			// txtEss
			// 
			this.txtEss.Location = new System.Drawing.Point(26, 111);
			this.txtEss.Name = "txtEss";
			this.txtEss.ReadOnly = true;
			this.txtEss.Size = new System.Drawing.Size(54, 20);
			this.txtEss.TabIndex = 8;
			// 
			// txtCrys
			// 
			this.txtCrys.Location = new System.Drawing.Point(26, 89);
			this.txtCrys.Name = "txtCrys";
			this.txtCrys.ReadOnly = true;
			this.txtCrys.Size = new System.Drawing.Size(54, 20);
			this.txtCrys.TabIndex = 7;
			// 
			// txtBrim
			// 
			this.txtBrim.Location = new System.Drawing.Point(26, 67);
			this.txtBrim.Name = "txtBrim";
			this.txtBrim.ReadOnly = true;
			this.txtBrim.Size = new System.Drawing.Size(54, 20);
			this.txtBrim.TabIndex = 6;
			// 
			// toolTipYourCreatures
			// 
			this.toolTipYourCreatures.AutomaticDelay = 200;
			this.toolTipYourCreatures.AutoPopDelay = 1000000;
			this.toolTipYourCreatures.InitialDelay = 200;
			this.toolTipYourCreatures.IsBalloon = true;
			this.toolTipYourCreatures.ReshowDelay = 200;
			this.toolTipYourCreatures.ShowAlways = true;
			this.toolTipYourCreatures.ToolTipTitle = "Your creatures";
			// 
			// toolTipTravelEncounter
			// 
			this.toolTipTravelEncounter.AutomaticDelay = 200;
			this.toolTipTravelEncounter.AutoPopDelay = 1000000;
			this.toolTipTravelEncounter.InitialDelay = 200;
			this.toolTipTravelEncounter.IsBalloon = true;
			this.toolTipTravelEncounter.ReshowDelay = 200;
			this.toolTipTravelEncounter.ShowAlways = true;
			this.toolTipTravelEncounter.ToolTipTitle = "Travel encounter";
			// 
			// toolTipBattleResult
			// 
			this.toolTipBattleResult.AutomaticDelay = 200;
			this.toolTipBattleResult.AutoPopDelay = 1000000;
			this.toolTipBattleResult.InitialDelay = 200;
			this.toolTipBattleResult.IsBalloon = true;
			this.toolTipBattleResult.ReshowDelay = 200;
			this.toolTipBattleResult.ShowAlways = true;
			this.toolTipBattleResult.ToolTipTitle = "Battle Result";
			// 
			// UcTravelCalc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.grpResources);
			this.Controls.Add(this.pnlTravelCalc);
			this.MaximumSize = new System.Drawing.Size(204, 248);
			this.MinimumSize = new System.Drawing.Size(204, 248);
			this.Name = "UcTravelCalc";
			this.Size = new System.Drawing.Size(204, 248);
			this.pnlTravelCalc.ResumeLayout(false);
			this.pnlTravelCalc.PerformLayout();
			this.grpResources.ResumeLayout(false);
			this.grpResources.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblYourCreatures;
		private System.Windows.Forms.TextBox txtYourCreatures;
		private System.Windows.Forms.TextBox txtTravelCreatures;
		private System.Windows.Forms.Label lblTravelCreatures;
		private System.Windows.Forms.TextBox txtYourCritCount;
		private System.Windows.Forms.TextBox txtTravelCritCount;
		private System.Windows.Forms.Panel pnlTravelCalc;
		private System.Windows.Forms.GroupBox grpResources;
		private System.Windows.Forms.Label lblWithoutRudolph;
		private System.Windows.Forms.TextBox txtTotalResPerHourWithoutRudolph;
		private System.Windows.Forms.Label lblPowerPerHour;
		private System.Windows.Forms.TextBox txtPowerPerHour;
		private System.Windows.Forms.Label lblTotalResPerHour;
		private System.Windows.Forms.TextBox txtTotalResPerHour;
		private System.Windows.Forms.Label lblTotalRes;
		private System.Windows.Forms.TextBox txtTotalRes;
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
		private System.Windows.Forms.TextBox txtStartingResources;
		private System.Windows.Forms.Label lblStarting;
		private System.Windows.Forms.DateTimePicker dtpStartTime;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.DateTimePicker dtpCurrentTime;
		private System.Windows.Forms.TextBox txtCurrentResources;
		private System.Windows.Forms.Label lblCurrent;
		private System.Windows.Forms.TextBox txtTravelResult;
		private System.Windows.Forms.ToolTip toolTipYourCreatures;
		private System.Windows.Forms.ToolTip toolTipTravelEncounter;
		private System.Windows.Forms.ToolTip toolTipBattleResult;
	}
}
