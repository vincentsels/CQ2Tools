using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQ2Tools.Entities
{
	/// <summary>
	/// The different sorts of classes a mage or creature can be.
	/// </summary>
	public enum CreatureClass
	{
		Forest = 'F',
		Death = 'D',
		Air = 'A',
		Earth = 'E'
	}

	/// <summary>
	/// The outcome of a battle.
	/// </summary>
	public enum DuelOutcome
	{
		Lost,
		Dip,
		Won
	}

	/// <summary>
	/// The different types of enchantments an item can have.
	/// </summary>
	public static class Enchantments
	{
		public const string MajorImmunity = "MaIm";
		public const string MajorBerserk = "MaBe";
	}

	/// <summary>
	/// The different races of creature can be.
	/// </summary>
	public static class CreatureRaces
	{
		public const string Remnant = "Remnant";
		public const string Angel = "Angel";
		public const string Balrog = "Balrog";
		public const string Bat = "Bat";
		public const string Dragon = "Dragon";
		public const string Gargoyle = "Gargoyle";
		public const string Wraith = "Wraith";
		public const string Dancer = "Dancer";
		public const string Spirit = "Spirit";
		public const string Storm = "Storm";
		public const string Apocalypse = "Apocalypse";
		public const string Banshee = "Banshee";
		public const string Carnage = "Carnage";
		public const string Devil = "Devil";
		public const string Horde = "Horde";
		public const string Doomguard = "Doomguard";
		public const string Lich = "Lich";
		public const string Worm = "Worm";
		public const string Reaper = "Reaper";
		public const string Undead = "Undead";
		public const string Fiend = "Fiend";
		public const string Giant = "Giant";
		public const string Golem = "Golem";
		public const string Imler = "Imler";
		public const string Imling = "Imling";
		public const string Rat = "Rat";
		public const string Smith = "Smith";
		public const string Tempest = "Tempest";
		public const string Tremor = "Tremor";
		public const string Cleric = "Cleric";
		public const string Ent = "Ent";
		public const string Hound = "Hound";
		public const string Hunter = "Hunter";
		public const string Imp = "Imp";
		public const string Monk = "Monk";
		public const string Priest = "Priest";
		public const string Seraph = "Seraph";
		public const string Wolf = "Wolf";
	}
}
