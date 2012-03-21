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
	public partial class UcSimpleCalc : UserControl
	{
		Creature _you;
		Creature _opponent;

		#region Constructor
		public UcSimpleCalc()
		{
			InitializeComponent();
		}
		#endregion

		#region Public Methods
		public void SetText(string text)
		{
			if (ActiveControl == txtYou && txtYou.Text.Trim() == string.Empty)
				txtYou.Text = text;
			else
				txtOpponent.Text = text;
		}
		#endregion

		#region Eventhandlers
		private void txtYou_TextChanged(object sender, EventArgs e)
		{
			string input = txtYou.Text;
			string formattedInput = CreatureParser.CleanInput(input);

			if (input != formattedInput)
			{
				txtYou.Text = formattedInput;
				return;
			}

			try
			{
				_you = CreatureParser.ParseCreature(txtYou.Text);
			}
			catch
			{
				// Ignore parsing errors
				txtResult.Clear();
			}

			CalculateAndSetResult();
		}

		private void txtOpponent_TextChanged(object sender, EventArgs e)
		{
			string input = txtOpponent.Text;
			string formattedInput = CreatureParser.CleanInput(input);

			if (input != formattedInput)
			{
				txtOpponent.Text = formattedInput;
				return;
			}

			try
			{
				_opponent = CreatureParser.ParseCreature(txtOpponent.Text);
			}
			catch
			{
				// Ignore parsing errors
				txtResult.Clear();
			}

			CalculateAndSetResult();
		}
		#endregion

		#region Provate Methods
		private void CalculateAndSetResult()
		{
			if (txtYou.Text == string.Empty || txtOpponent.Text == string.Empty) return;

			DuelResult result = BattleCalculator.CalculateDuel(_you, _opponent);
			txtResult.Text = result.Result;
			grpResult.ForeColor = (result.Outcome == DuelOutcome.Won ? Constants.COLOR_WIN :
				(result.Outcome == DuelOutcome.Dip ? Constants.COLOR_DIP : Constants.COLOR_LOSE));
		}
		#endregion
	}
}
