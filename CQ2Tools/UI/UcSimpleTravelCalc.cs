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
	public partial class UcSimpleTravelCalc : UserControl
	{
		List<Creature> _yourCreatures;
		List<Creature> _travelEncounter;

		#region Constructor
		public UcSimpleTravelCalc()
		{
			InitializeComponent();

			_yourCreatures = new List<Creature>();
			_travelEncounter = new List<Creature>();

			lblNotEnoughCreatures.ForeColor = Constants.COLOR_LOSE;
		}
		#endregion

		#region Public Methods
		public void SetText(string text)
		{
			if (ActiveControl == txtYourCreatures && txtYourCreatures.Text.Trim() == string.Empty)
				txtYourCreatures.Text = text;
			else
				txtTravelCreatures.Text = text;
		}
		#endregion

		#region Eventhandlers
		private void txtYourCreatures_TextChanged(object sender, EventArgs e)
		{
			try
			{
				_yourCreatures = CreatureParser.ParseCreatureList(txtYourCreatures.Text);
			}
			catch
			{
				// Ignore parsing errors.
				ClearAll();
			}

			CalculateAndSetResult();
		}

		private void txtTravelCreatures_TextChanged(object sender, EventArgs e)
		{
			try
			{
				_travelEncounter = CreatureParser.ParseCreatureList(txtTravelCreatures.Text);
			}
			catch
			{
				// Ignore parsing errors.
				ClearAll();
			}

			CalculateAndSetResult();
		}

		private void txtTravelCreatures_Click(object sender, EventArgs e)
		{
			txtTravelCreatures.SelectAll();
		}
		#endregion

		#region Private Methods
		private void CalculateAndSetResult()
		{
			ClearAll();

			if (txtYourCreatures.Text == string.Empty || txtTravelCreatures.Text == string.Empty || _travelEncounter.Count == 0) return;
			if (_travelEncounter.Count > _yourCreatures.Count)
			{
				lblNotEnoughCreatures.Visible = true;
				grpResult.ForeColor = Constants.COLOR_LOSE;
			}
			else
			{
				int wins = 0;
				int dips = 0;
				int losses = 0;

				for (int i = 0; i < _travelEncounter.Count; i++)
				{
					DuelResult result = BattleCalculator.CalculateDuel(_yourCreatures[i], _travelEncounter[i]);
					if (result.Outcome == DuelOutcome.Dip) dips++;
					else if (result.Outcome == DuelOutcome.Lost) losses++;
					else if (result.Outcome == DuelOutcome.Won) wins++;
				}

				if (dips == 0 && losses == 0) grpResult.ForeColor = Constants.COLOR_WIN;
				else if (losses > 0) grpResult.ForeColor = Constants.COLOR_LOSE;
				else grpResult.ForeColor = Constants.COLOR_DIP;

				txtWins.Text = wins.ToString();
				txtDips.Text = dips.ToString();
				txtLosses.Text = losses.ToString();
			}
		}

		private void ClearAll()
		{
			txtWins.Clear();
			txtDips.Clear();
			txtLosses.Clear();
			lblNotEnoughCreatures.Visible = false;
		}
		#endregion
	}
}
