using System;
using System.Collections.Generic;

namespace AosLibrary
{
	public partial class Weapon
	{
		public int	id { get; set; }
		public string name { get; set; }
		public WeaponType type { get; set; }
		public Dictionary<int, Range> attacks { get; set; }
		public Dictionary<int, int> toHit { get; }
		public Dictionary<int, int> toWound { get; }
		public Dictionary<int, int> rend { get; }
		public Dictionary<int, Range> damage { get; }
	}
}
