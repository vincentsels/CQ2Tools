using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CQ2Tools.Entities;
using CQ2Tools.Logic;

namespace CQ2Tools.UI
{
	public partial class UcTravelIncomeCalculator : UserControl
	{
		Resources _startingRes;
		Resources _currentRes;

		#region Constructor
		public UcTravelIncomeCalculator()
		{
			InitializeComponent();
		}
		#endregion

		#region Public Methods
		public void SetText(string text)
		{
			if (ActiveControl == txtStartingResources && txtStartingResources.Text.Trim() == string.Empty)
				txtStartingResources.Text = text;
			else
				txtCurrentResources.Text = text;
		}
		#endregion

		#region Eventhandlers
		private void txtStartingResources_TextChanged(object sender, EventArgs e)
		{
			string input = txtStartingResources.Text;
			string formattedInput = ResourceParser.CleanInput(input);

			if (input != formattedInput)
			{
				txtStartingResources.Text = formattedInput;
				return;
			}

			try
			{
				_startingRes = ResourceParser.ParseResources(txtStartingResources.Text);
				dtpStartTime.Value = DateTime.Now;
				txtStartingResources.ReadOnly = true;
			}
			catch
			{
				// Ignore parsing errors
			}
		}

		private void txtCurrentResources_TextChanged(object sender, EventArgs e)
		{
			string input = txtCurrentResources.Text;
			string formattedInput = ResourceParser.CleanInput(input);

			if (input != formattedInput)
			{
				txtCurrentResources.Text = formattedInput;
				return;
			}

			try
			{
				_currentRes = ResourceParser.ParseResources(txtCurrentResources.Text);
				dtpCurrentTime.Value = DateTime.Now;
			}
			catch
			{
				// Ignore parsing errors
			}

			CalculateResourcesGained();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			txtStartingResources.Clear();
			txtStartingResources.ReadOnly = false;
			dtpStartTime.Value = DateTime.Now;
		}

		private void txtCurrentResources_Click(object sender, EventArgs e)
		{
			txtCurrentResources.SelectAll();
		}
		#endregion

		#region Private Methods
		private void CalculateResourcesGained()
		{
			if (_startingRes == null || _currentRes == null) return;

			Resources gained = _currentRes - _startingRes;
			txtBrim.Text = gained.Brimstone.ToString();
			txtCrys.Text = gained.Crystal.ToString();
			txtEss.Text = gained.Essence.ToString();
			txtGran.Text = gained.Granite.ToString();
			txtPower.Text = gained.Power.ToString();
			txtTotalRes.Text = gained.TotalResWithoutPower.ToString();

			TimeSpan ts = dtpCurrentTime.Value - dtpStartTime.Value;
			if (ts.TotalSeconds == 0) return;

			int totalResPerHour = Convert.ToInt32((decimal)gained.TotalResWithoutPower / (decimal)ts.TotalSeconds * (60M * 60M));
			int totalPowerPerHour = Convert.ToInt32((decimal)gained.Power / (decimal)ts.TotalSeconds * (60M * 60M));

			txtTotalResPerHour.Text = totalResPerHour.ToString();
			txtPowerPerHour.Text = totalPowerPerHour.ToString();
			txtTotalResPerHourWithoutRudolph.Text = (totalResPerHour + (totalPowerPerHour * 2)).ToString();
		}
		#endregion
	}
}
