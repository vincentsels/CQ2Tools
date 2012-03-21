using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CQ2Tools.Entities;

namespace CQ2Tools.Logic
{
	public static class ResourceParser
	{
		public static Resources ParseResources(string text)
		{
			Resources res = new Resources();

			/*
			   Resources  ?  
			   Brimstone: 8793
			   Crystal: 8101
			   Essence: 1410
			   Granite: 16767
			   Power: 5381
			*/

			List<string> lines = text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();

			if (lines.Where(s => s.Trim().StartsWith("Brimstone:")).Any())
				res.Brimstone = Convert.ToInt32(lines.Where(s => s.Trim().StartsWith("Brimstone: ")).First().Replace("Brimstone: ", ""));
			if (lines.Where(s => s.Trim().StartsWith("Crystal:")).Any())
				res.Crystal = Convert.ToInt32(lines.Where(s => s.Trim().StartsWith("Crystal: ")).First().Replace("Crystal: ", ""));
			if (lines.Where(s => s.Trim().StartsWith("Essence:")).Any())
				res.Essence = Convert.ToInt32(lines.Where(s => s.Trim().StartsWith("Essence: ")).First().Replace("Essence: ", ""));
			if (lines.Where(s => s.Trim().StartsWith("Granite:")).Any())
				res.Granite = Convert.ToInt32(lines.Where(s => s.Trim().StartsWith("Granite: ")).First().Replace("Granite: ", ""));
			if (lines.Where(s => s.Trim().StartsWith("Power:")).Any())
				res.Power = Convert.ToInt32(lines.Where(s => s.Trim().StartsWith("Power: ")).First().Replace("Power: ", ""));

			return res;
		}

		public static string CleanInput(string input)
		{
			return input.Replace("Resources", "").Replace("?", "").Trim();
		}

		public static bool ContainsResourceInfo(string input)
		{
			return input.Contains("Brimstone: ") || input.Contains("Crystal: ") || input.Contains("Essence: ") ||
				input.Contains("Granite: ") || input.Contains("Power: ");
		}
	}
}
