using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AosLibrary
{
	public partial class Weapon
	{
		public string Name { get; private set; } = string.Empty;
		public WeaponType Type { get; private set; } = WeaponType.notset;
		Dictionary<string, Range> _attacks = new Dictionary<string, Range>();
		// public Dictionary<int, int> toHit { get; }
		// public Dictionary<int, int> toWound { get; }
		// public Dictionary<int, int> rend { get; }
		// public Dictionary<int, Range> damage { get; }

		public Weapon(string json)
		{
			JObject jsonObj = JObject.Parse(json);
			Parser parser = new Parser();
			this.Name = parser.ParseString("Name", jsonObj);
			this.Type = parser.ParseWeaponType("Type", jsonObj);
			this._attacks = parser.ParseDictionary<Range>("Attacks", jsonObj);
			Console.WriteLine(this.Name);
			Console.WriteLine(this.Type);
		}
	}
}
