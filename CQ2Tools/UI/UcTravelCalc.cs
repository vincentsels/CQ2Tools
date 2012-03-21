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
	public partial class UcTravelCalc : UserControl
	{
		CreatureList _yourCreatures;
		CreatureList _travelEncounter;
		Resources _startingRes;
		Resources _currentRes;


		public UcTravelCalc()
		{
			InitializeComponent();
		}

		public void SetCreatureText(string text)
		{
			if (txtYourCreatures.Text.Trim() == string.Empty)
				txtYourCreatures.Text = text;
			else
				txtTravelCreatures.Text = text;
		}

		public void SetResourcesText(string text)
		{
			if (txtStartingResources.Text.Trim() == string.Empty)
				txtStartingResources.Text = text;
			else
				txtCurrentResources.Text = text;
		}

		#region Eventhandlers
		private void txtYourCreatures_TextChanged(object sender, EventArgs e)
		{
			try
			{
				_yourCreatures = CreatureParser.ParseCreatureList(txtYourCreatures.Text);
				txtYourCritCount.Text = _yourCreatures.Count.ToString();

				toolTipYourCreatures.SetToolTip(lblYourCreatures, _yourCreatures.ToString());
				toolTipYourCreatures.SetToolTip(txtYourCreatures, _yourCreatures.ToString());
			}
			catch
			{
				// Ignore parsing errors.
			}

			CalculateAndSetResult();
		}

		private void txtTravelCreatures_TextChanged(object sender, EventArgs e)
		{
			try
			{
				_travelEncounter = CreatureParser.ParseCreatureList(txtTravelCreatures.Text);
				txtTravelCritCount.Text = _travelEncounter.Count.ToString();

				toolTipTravelEncounter.SetToolTip(lblTravelCreatures, _travelEncounter.ToString());
				toolTipTravelEncounter.SetToolTip(txtTravelCreatures, _travelEncounter.ToString());
			}
			catch
			{
				// Ignore parsing errors.
			}

			CalculateAndSetResult();
		}

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

		private void txtTextBox_Click(object sender, EventArgs e)
		{
			(sender as TextBox).SelectAll();
		}
		#endregion

		#region Private Methods
		private void CalculateAndSetResult()
		{
			if (txtYourCreatures.Text == string.Empty || txtTravelCreatures.Text == string.Empty || _travelEncounter.Count == 0) return;

			toolTipBattleResult.RemoveAll();

			if (_travelEncounter.Count > _yourCreatures.Count)
			{
				txtTravelResult.BackColor = Constants.COLOR_LOSE_BACK; ;
				txtTravelResult.Text = "Not enough creatures";
			}
			else
			{
				BattleResult result = BattleCalculator.CalculateBattle(_yourCreatures, _travelEncounter);

				Color color;
				if (result.Dips == 0 && result.Losses == 0) color = Constants.COLOR_WIN_BACK;
				else if (result.Losses > 0) color = Constants.COLOR_LOSE_BACK;
				else color = Constants.COLOR_DIP_BACK;

				txtTravelResult.BackColor = color;
				txtTravelResult.Text = String.Format(
					"Won: {0:0} - Dips: {1:0} - Lost: {2:0}", 
					result.Wins, result.Dips, result.Losses);

				toolTipBattleResult.SetToolTip(txtTravelResult, result.ToString());
			}
		}

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
