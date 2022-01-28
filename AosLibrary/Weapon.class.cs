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
		Dictionary<string, int> _toHit = new Dictionary<string, int>();
		Dictionary<string, int> _toWound = new Dictionary<string, int>();
		Dictionary<string, int> _rend = new Dictionary<string, int>();
		Dictionary<string, Range> _damage = new Dictionary<string, Range>();

		bool _toHitMortalEnds;
		bool _toHitMortalInAddition;
		bool _toWoundMortalEnds;

		bool _toWoundMortalsInAddition;

		public Weapon(string json)
		{
			JObject jsonObj = JObject.Parse(json);
			this.Name = Utilities.ParseString("Name", jsonObj);
			this.Type = Utilities.ParseWeaponType("Type", jsonObj);
			this._attacks = Utilities.ParseDictionary<Range>("Attacks", jsonObj);
			this._toHit = Utilities.ParseDictionary<int>("ToHit", jsonObj);
			this._toWound = Utilities.ParseDictionary<int>("ToWound", jsonObj);
			this._rend = Utilities.ParseDictionary<int>("Rend", jsonObj);
			this._damage = Utilities.ParseDictionary<Range>("Damage", jsonObj);
		}
	}
}
