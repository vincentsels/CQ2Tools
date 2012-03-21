using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CQ2Tools.Logic;

namespace CQ2Tools.Entities
{
	/// <summary>
	/// Represents a CQ2 creature. Use the constructor that accepts another creature to clone it,
	/// for instance to keep a copy for calculations while leaving the actual creature unchanged.
	/// </summary>
	public class Creature
	{
		public Creature()
		{

		}

		/// <summary>
		/// Clone a creature.
		/// </summary>
		public Creature(Creature copyFrom)
		{
			CreatureClass = copyFrom.CreatureClass;
			Race = copyFrom.Race;
			Name = copyFrom.Name;
			Level = copyFrom.Level;
			IsNether = copyFrom.IsNether;
			IsItherian = copyFrom.IsItherian;

			Damage = copyFrom.Damage;
			Health = copyFrom.Health;

			ForestDefence = copyFrom.ForestDefence;
			DeathDefence = copyFrom.DeathDefence;
			AirDefence = copyFrom.AirDefence;
			EarthDefence = copyFrom.EarthDefence;

			Item = copyFrom.Item;
			ItemEnchantment = copyFrom.ItemEnchantment;
			ItemEnchantedAgainst = copyFrom.ItemEnchantedAgainst;
		}

		public CreatureClass CreatureClass { get; set; }
		public string Race { get; set; }
		public string Name { get; set; }
		public int Level { get; set; }
		public bool IsNether { get; set; }
		public bool IsItherian { get; set; }

		public int Damage { get; set; }
		public int Health { get; set; }

		public int ForestDefence { get; set; }
		public int DeathDefence { get; set; }
		public int AirDefence { get; set; }
		public int EarthDefence { get; set; }

		public Item Item { get; set; }
		public string ItemEnchantment { get; set; }
		public string ItemEnchantedAgainst { get; set; }

		public override string ToString()
		{
			string concatString = " - ";

			return Utils.ConcatWith(concatString, true,
				Name, Race + "/" + CreatureClass, IsNether ? ("(N)") : IsItherian ? "(I)" : "", Damage + "/" + Health,
				"F" + ForestDefence + "/D" + DeathDefence + "/A" + AirDefence + "/E" + EarthDefence,
				Item == null ? "" : Item.FullName, 
				String.IsNullOrEmpty(ItemEnchantment) ? "" : "(" + ItemEnchantment + " " + ItemEnchantedAgainst + ")").Trim();
		}
	}

	public class CreatureList : List<Creature>
	{
		/// <summary>
		/// Enumerates all the creatures in the creaturelist by calling their ToString method.
		/// </summary>
		public override string ToString()
		{
			string result = string.Empty;
			foreach (Creature c in this)
				result += c.ToString() + (this.IndexOf(c) == this.Count ? "" : Environment.NewLine);
			return result;
		}
	}
}
