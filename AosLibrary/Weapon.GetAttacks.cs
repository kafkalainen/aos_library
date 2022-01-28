using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// namespace AosLibrary
// {
// 	public partial class Weapon
// 	{
// 		public string Name { get; private set; }
// 		public WeaponType Type { get; private set; }
// 		Dictionary<string, Range> _attacks;
// 		// public Dictionary<int, int> toHit { get; }
// 		// public Dictionary<int, int> toWound { get; }
// 		// public Dictionary<int, int> rend { get; }
// 		// public Dictionary<int, Range> damage { get; }

// 		public Weapon(string json)
// 		{
// 			JObject jsonObj = JObject.Parse(json);
// 			this.Name = jsonObj["Name"].ToObject<string>();
// 			this.Type = jsonObj["Type"].ToObject<WeaponType>();
// 			this._attacks = jsonObj["Attacks"].ToObject<Dictionary<string, Range>>();
// 			Console.WriteLine(this.Name);
// 			Console.WriteLine(this.Type);
// 		}
// 	}
// }
