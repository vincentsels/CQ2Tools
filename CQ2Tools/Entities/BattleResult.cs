using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQ2Tools.Entities
{
	/// <summary>
	/// The result of a battle between two creatures.
	/// </summary>
	public class DuelResult
	{
		/// <summary>
		/// The outcome of the battle.
		/// </summary>
		public DuelOutcome Outcome { get; set; }

		/// <summary>
		/// The detailed result of the battle.
		/// </summary>
		public string Result { get; set; }

		/// <summary>
		/// Returns only the outcome result of the battle.
		/// </summary>
		public string ShortResult { get; set; }

		/// <summary>
		/// Displays the detailed result of the battle.
		/// </summary>
		public override string ToString()
		{
			return Result;
		}
	}

	public class BattleResult : List<DuelResult>
	{
		public int Wins
		{
			get { return this.Where(d => d.Outcome == DuelOutcome.Won).Count(); }
		}

		public int Dips
		{
			get { return this.Where(d => d.Outcome == DuelOutcome.Dip).Count(); }
		}

		public int Losses
		{
			get { return this.Where(d => d.Outcome == DuelOutcome.Lost).Count(); }
		}

		/// <summary>
		/// Lists the battle result by enumerating the outcome of each duel.
		/// </summary>
		public override string ToString()
		{
			string result = string.Empty;
			foreach (DuelResult d in this)
				result += d.ShortResult + (this.IndexOf(d) == this.Count ? "" : Environment.NewLine);
			return result;
		}
	}
}
