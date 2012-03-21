using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQ2Tools.Entities
{
	/// <summary>
	/// Represents a collection of CQ2 resources.
	/// </summary>
	public class Resources
	{
		public Resources()
		{
		}

		public Resources(Resources resourcesToCopy)
		{
			Brimstone = resourcesToCopy.Brimstone;
			Crystal = resourcesToCopy.Crystal;
			Essence = resourcesToCopy.Essence;
			Granite = resourcesToCopy.Granite;
			Power = resourcesToCopy.Power;
		}

		public int Brimstone { get; set; }
		public int Crystal { get; set; }
		public int Essence { get; set; }
		public int Granite { get; set; }
		public int Power { get; set; }

		public int TotalResWithoutPower
		{
			get { return Brimstone + Crystal + Essence + Granite; }
		}

		public static Resources operator -(Resources left, Resources right)
		{
			Resources result = new Resources(left);

			result.Brimstone -= right.Brimstone;
			result.Crystal -= right.Crystal;
			result.Essence -= right.Essence;
			result.Granite -= right.Granite;
			result.Power -= right.Power;

			return result;
		}
	}
}
