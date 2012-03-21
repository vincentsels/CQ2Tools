using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CQ2Tools.Entities;

namespace CQ2Tools.Logic
{
	public static class BattleCalculator
	{
		/// <summary>
		/// Calculates a duel between <paramref name="you"/> and <paramref name="opponent"/> creatures and
		/// returns the the result as a <see cref="DuelResult"/>.
		/// </summary>
		public static DuelResult CalculateDuel(Creature you, Creature opponent)
		{
			return CalculateBattle(new List<Creature>() { you }, new List<Creature>() { opponent }).FirstOrDefault();
		}

		/// <summary>
		/// Calculates the battle between <paramref name="yourCreatures"/> and <paramref name="opponentsCreatures"/> and
		/// returns the the result as a <see cref="BattleResult"/>.
		/// </summary>
		public static BattleResult CalculateBattle(List<Creature> yourCreatures, List<Creature> opponentsCreatures)
		{
			if (opponentsCreatures.Count > yourCreatures.Count) 
				throw new ArgumentException("You do not have enough creatures!");

			BattleResult battleResult = new BattleResult();

			for (int duelIndex = 0; duelIndex < opponentsCreatures.Count; duelIndex++)
			{
				Creature opponent = new Creature(opponentsCreatures[duelIndex]);
				Creature you = new Creature(yourCreatures[duelIndex]);
				DuelResult duel = new DuelResult();

				AddEnchantmentEffects(you, opponent);
				AddEnchantmentEffects(opponent, you);

				AddItemEffectsBeforeBattle(you, opponent, yourCreatures, opponentsCreatures);
				AddItemEffectsBeforeBattle(opponent, you, opponentsCreatures, yourCreatures);

				while (you.Health > 0 && opponent.Health > 0)
				{
					int opponentDamage = GetDamage(opponent, you);
					int yourDamage = GetDamage(you, opponent);

					you.Health -= opponentDamage;
					opponent.Health -= yourDamage;

					AddItemEffectsBeforeTurn(you, opponent);
					AddItemEffectsBeforeTurn(opponent, you);

					if (you.Health < 0) you.Health = 0;
					if (opponent.Health < 0) opponent.Health = 0;

					duel.Result += String.Format(
						"Your {0} did {1} damage -> opponent's {2} has {3} health left." + Environment.NewLine +
						"Opponent's {2} did {4} damage -> your {0} has {5} health left." + Environment.NewLine,
						you.Name, yourDamage, opponent.Name, opponent.Health, opponentDamage, you.Health);
				}

				if (you.Health == 0 && opponent.Health == 0)
				{
					string outCome = String.Format("Your {0} killed your opponent's {1} but died in the process.", you.Name, opponent.Name);
					duel.Result += outCome;
					duel.ShortResult = outCome;
					duel.Outcome = DuelOutcome.Dip;
				}
				else if (you.Health > 0)
				{
					string outCome = String.Format("Your {0} killed your opponent's {1}.", you.Name, opponent.Name);
					duel.Result += outCome;
					duel.ShortResult = outCome;
					duel.Outcome = DuelOutcome.Won;
				}
				else
				{
					string outCome = String.Format("Your {0} got killed by your opponent's {1}.", you.Name, opponent.Name);
					duel.Result += outCome;
					duel.ShortResult = outCome;
					duel.Outcome = DuelOutcome.Lost;
				}

				battleResult.Add(duel);
			}

			return battleResult;
		}

		/// <summary>
		/// Returns the damage done by the <paramref name="attacker"/> to the <paramref name="defender"/>,
		/// based on the class of the <paramref name="attacker"/> and the defences of the <paramref name="defender"/>.
		/// </summary>
		private static int GetDamage(Creature attacker, Creature defender)
		{
			int damage = attacker.Damage;

			decimal multiplyer = 0M;
			if (attacker.CreatureClass == CreatureClass.Air) multiplyer = ((150M - (decimal)defender.AirDefence)) / 100M;
			if (attacker.CreatureClass == CreatureClass.Death) multiplyer = ((150M - (decimal)defender.DeathDefence)) / 100M;
			if (attacker.CreatureClass == CreatureClass.Earth) multiplyer = ((150M - (decimal)defender.EarthDefence)) / 100M;
			if (attacker.CreatureClass == CreatureClass.Forest) multiplyer = ((150M - (decimal)defender.ForestDefence)) / 100M;

			damage = Convert.ToInt32(damage * multiplyer);

			return Math.Max(damage, 1);
		}

		private static void AddItemEffectsBeforeBattle(Creature attacker, Creature defender,
			List<Creature> alliedCreatures, List<Creature> opposingCreatures)
		{
			#region Cleric Items
			if (attacker.Race == CreatureRaces.Cleric && attacker.Item != null)
			{
				attacker.Damage += alliedCreatures.Take(opposingCreatures.Count).Where(c => c.Race == CreatureRaces.Cleric).Count() * Convert.ToInt32(attacker.Item.PrimaryDamage);
				attacker.Damage -= alliedCreatures.Take(opposingCreatures.Count).Where(c => c.Race != CreatureRaces.Cleric).Count() * Convert.ToInt32(attacker.Item.SecondaryDamage);
			}
			#endregion

			#region Diabolic Items
			if (attacker.Race == CreatureRaces.Horde && attacker.Item != null)
			{
				attacker.Damage += alliedCreatures.Take(opposingCreatures.Count).Where(c => c.Race == CreatureRaces.Horde).Count() * Convert.ToInt32(attacker.Item.PrimaryDamage);
			}
			#endregion

			#region Smith Items
			if (attacker.Race == CreatureRaces.Smith && attacker.Item != null)
			{
				if (defender.CreatureClass == attacker.Item.Class)
				{
					attacker.Damage += attacker.Item.PrimaryDamage;
					attacker.Health += attacker.Item.PrimaryHealth;
				}
				else
				{
					attacker.Damage += attacker.Item.SecondaryDamage;
					attacker.Health += attacker.Item.SecondaryHealth;
				}
			}
			#endregion

			#region Lich Items
			if (attacker.Race == CreatureRaces.Lich && attacker.Item != null)
			{
				if (defender.AirDefence > attacker.Item.PrimaryDefence) defender.AirDefence -= attacker.Item.PrimaryDefence;
				else defender.AirDefence = 0;
				if (defender.DeathDefence > attacker.Item.PrimaryDefence) defender.DeathDefence -= attacker.Item.PrimaryDefence;
				else defender.DeathDefence = 0;
				if (defender.EarthDefence > attacker.Item.PrimaryDefence) defender.EarthDefence -= attacker.Item.PrimaryDefence;
				else defender.EarthDefence = 0;
				if (defender.ForestDefence > attacker.Item.PrimaryDefence) defender.ForestDefence -= attacker.Item.PrimaryDefence;
				else defender.ForestDefence = 0;
			}
			#endregion
		}

		private static void AddItemEffectsBeforeTurn(Creature attacker, Creature defender)
		{
			#region Imling Items
			if (attacker.Race == CreatureRaces.Imling && attacker.Item != null)
			{
				attacker.Health += attacker.Item.PrimaryHealth;
				defender.Health -= attacker.Item.PrimaryHealth;
				if (defender.Health < 0) defender.Health = 0;
			}
			#endregion
		}

		private static void AddEnchantmentEffects(Creature attacker, Creature defender)
		{
			if (attacker.ItemEnchantment == null || attacker.ItemEnchantedAgainst != defender.Race) return;

			if (attacker.ItemEnchantment == Enchantments.MajorImmunity)
			{
				attacker.AirDefence = 100;
				attacker.DeathDefence = 100;
				attacker.EarthDefence = 100;
				attacker.ForestDefence = 100;
			}
			else if (attacker.ItemEnchantment == Enchantments.MajorBerserk)
			{
				attacker.Damage = Convert.ToInt32(attacker.Damage * 2.1);
			}
		}
	}
}
