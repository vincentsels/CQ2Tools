using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CQ2Tools.Entities;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace CQ2Tools.Logic
{
	public static class CreatureParser
	{
		#region Public Methods
		public static Creature ParseCreature(string text)
		{
			// Chrome keeps \t as tabs, replace those with spaces.
			text = text.Replace("\t", " ");
			// Remove uninteresting data.
			text = text.Replace("(cast curse)", "");
			text = text.Replace("(sacrifice, curse)", "");

			Creature creature = new Creature();

			// Brim Smith  Smith/earth, passive  L20  422/714  F20/D0/A70/E100 ItAm
			// Dark Brim Smith 	 Smith/earth (N), passive	L21	 1460/1995	 F20/D0/A70/E101	BlCrHa* (MaBe Fiend)

			// Split the text in parts
			var parts = text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList<String>();

			// Remove the initial number
			if (parts.First().Contains(".") && parts.First().Replace(".", "").IsNumber())
				parts.RemoveAt(0);

			// Retrieve the index of the Class/race section, as reference
			int idxClassRace = parts.IndexOf(parts.Where(s => s.Contains("/")).First());

			// Creature name
			var critName = parts.Where(s => parts.IndexOf(s) < idxClassRace); 
			foreach (var namePart in critName)
				creature.Name += namePart + " ";
			creature.Name = creature.Name.TrimEnd();

			// Nether or Itherian indication
			creature.IsNether = parts.Contains("(N),");
			creature.IsItherian = parts.Contains("(I),");

			// Creature class
			if (parts[idxClassRace].Contains("forest")) creature.CreatureClass = CreatureClass.Forest;
			else if (parts[idxClassRace].Contains("death")) creature.CreatureClass = CreatureClass.Death;
			else if (parts[idxClassRace].Contains("air")) creature.CreatureClass = CreatureClass.Air;
			else if (parts[idxClassRace].Contains("earth")) creature.CreatureClass = CreatureClass.Earth;

			// Creature race
			creature.Race = parts[idxClassRace].Substring(0, parts[idxClassRace].IndexOf("/"), true);

			// Creature level
			creature.Level = Convert.ToInt32(parts.Where(s => s.StartsWith("L") &&  s.Replace("L", "").IsNumber()).First().Replace("L", ""));

			// Creature stats
			string sStats = parts.Where(s => s.Contains("/")).ElementAt(1);
			creature.Damage = Convert.ToInt32(sStats.Substring(0, sStats.IndexOf("/"), true));
			creature.Health = Convert.ToInt32(sStats.Substring(sStats.IndexOf("/") + 1, 10, true));

			// Creature defences
			string sDefences = parts.Where(s => Regex.Matches(s, "[FDAE][0-9]+").Count == 4).First();
			var defences = sDefences.Split('/').ToList();
			creature.ForestDefence = Convert.ToInt32(defences.Where(s => s.Contains("F")).First().Replace("F", ""));
			creature.DeathDefence = Convert.ToInt32(defences.Where(s => s.Contains("D")).First().Replace("D", ""));
			creature.AirDefence = Convert.ToInt32(defences.Where(s => s.Contains("A")).First().Replace("A", ""));
			creature.EarthDefence = Convert.ToInt32(defences.Where(s => s.Contains("E")).First().Replace("E", ""));

			// Black Crystal Smith Smith/earth, passive	L20	 422/1454	 F20/D0/A70/E100	Dark Brim Hammer* (MaIm Diabolic Horde)	
			// Black Crystal Smith Smith/earth, passive	L20	 422/1454	 F20/D0/A70/E100	DaBrHa* (MaIm Diabolic Horde)	

			// Creature item
			if (parts.Count > parts.IndexOf(sDefences) + 1)
			{
				var itemParts = parts.Skip(parts.IndexOf(sDefences) + 1);

				string itemName = string.Empty;
				foreach (string s in itemParts.TakeWhile(s => !s.StartsWith("(")))
					itemName += s + " ";
				creature.Item = ParseItem(itemName.Replace("*", "").Trim());

				// Parse enchantmentment
				var enchantment = itemParts.Where(s => s.StartsWith("(")).FirstOrDefault();
				if (enchantment != null) creature.ItemEnchantment = enchantment.Replace("(", "");

				var enchantedAgainst = itemParts.Where(s => s.EndsWith(")")).FirstOrDefault();
				if (enchantedAgainst != null) creature.ItemEnchantedAgainst = enchantedAgainst.Replace(")", "");
			}

			return creature;
		}

		public static CreatureList ParseCreatureList(string text)
		{
			// Remove redundant text
			text = text.Replace("unequip item.", "");
			text = text.Replace("equip new item.", "");

			List<string> creatures = text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
			creatures.RemoveAll(s => s.Replace(" ", "").Length < 10); // Remove dummy lines

			CreatureList creatureList = new CreatureList();
			foreach (string creature in creatures)
			{
				try
				{
					creatureList.Add(ParseCreature(creature));
				}
				catch
				{
					// Ignore parsing errors
				}
			}

			return creatureList;
		}

		public static Item ParseItem(string text)
		{
			XDocument items = XDocument.Parse(Properties.Resources.Items);
			XNamespace cq2 = "cq2tools.items";
			return (from item in items.Root.Descendants(cq2 + "Item")
					where (item.Element(cq2 + "LongName").Value == text || GetShortItemName(item.Element(cq2 + "LongName").Value) == text)
					select new Item(
						item.Element(cq2 + "LongName").Value,
						GetShortItemName(item.Element(cq2 + "LongName").Value),
						item.Element(cq2 + "PrimaryDamage") == null ? string.Empty : item.Element(cq2 + "PrimaryDamage").Value,
						item.Element(cq2 + "SecondaryDamage") == null ? string.Empty : item.Element(cq2 + "SecondaryDamage").Value,
						item.Element(cq2 + "PrimaryHealth") == null ? string.Empty : item.Element(cq2 + "PrimaryHealth").Value,
						item.Element(cq2 + "SecondaryHealth") == null ? string.Empty : item.Element(cq2 + "SecondaryHealth").Value,
						item.Element(cq2 + "PrimaryDefence") == null ? string.Empty : item.Element(cq2 + "PrimaryDefence").Value,
						item.Element(cq2 + "SecondaryDefence") == null ? string.Empty : item.Element(cq2 + "SecondaryDefence").Value,
						item.Element(cq2 + "CreatureClass") == null ? string.Empty : item.Element(cq2 + "CreatureClass").Value)).FirstOrDefault();
		}

		public static string CleanTravelCreatureList(string text)
		{
			if (text.Contains("page."))
				return text.Substring(text.LastIndexOf("page.")+5, text.Length, true);
			else 
				return text;
		}

		public static string CleanInput(string input)
		{
			return input.Substring(input.IndexOf('.') + 1, input.Length, true).Trim();
		}

		public static bool ContainsCreatureInfo(string input)
		{
			return input.Contains("/") && input.Contains("A") && input.Contains("L");
		}
		#endregion

		#region Private Methods
		private static string GetShortItemName(string longItemName)
		{
			var parts = longItemName.Split(' ');
			string shortName = string.Empty;

			foreach (var part in parts)
				shortName += part.Substring(0, 2, true);

			return shortName;
		}
		#endregion
	}
}
