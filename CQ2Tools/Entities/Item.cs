using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CQ2Tools.Logic;

namespace CQ2Tools.Entities
{
	public class Item
	{
		/// <summary>
		/// Constructor that takes all strings, useful for parsing from XML input.
		/// </summary>
		public Item(string fullName, string shortName,
			string primaryDamage, string secondaryDamage,
			string primaryHealth, string secondaryHealth,
			string creatureClass, string primaryDefence,
			string secondaryDefence)
		{
			FullName = fullName;
			ShortName = shortName;
			PrimaryDamage = (primaryDamage == string.Empty ? 0 : Convert.ToInt32(primaryDamage));
			SecondaryDamage = (secondaryDamage == string.Empty ? 0 : Convert.ToInt32(secondaryDamage));
			PrimaryHealth = (primaryHealth == string.Empty ? 0 : Convert.ToInt32(primaryHealth));
			SecondaryHealth = (secondaryHealth == string.Empty ? 0 : Convert.ToInt32(secondaryHealth));
			PrimaryDefence = (primaryDefence == string.Empty ? 0 : Convert.ToInt32(primaryDefence));
			SecondaryDefence = (secondaryDefence == string.Empty ? 0 : Convert.ToInt32(secondaryDefence));
			Class = (creatureClass == string.Empty ? CreatureClass.Air : Utils.StringToEnum<CreatureClass>(creatureClass));
		}

		public string FullName { private set; get; }
		public string ShortName { private set; get; }

		public int PrimaryDamage { private set; get; }
		public int SecondaryDamage { private set; get; }
		public int PrimaryHealth { private set; get; }
		public int SecondaryHealth { private set; get; }
		public int PrimaryDefence { private set; get; }
		public int SecondaryDefence { private set; get; }

		public CreatureClass Class { private set; get; }
	}
}
