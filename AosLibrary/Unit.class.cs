using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AosLibrary
{
	public partial class Unit
	{
		public int Id { get; private set;}
		public string Name { get; private set;} = string.Empty;
		public int CurrentWounds { get; private set; }
		public Characteristics Characteristics { get; private set; } = new Characteristics();
		private Dictionary<string, Weapon> _weapons = new Dictionary<string, Weapon>();
		public Unit(string json)
		{
			Parser parser = new Parser();
			JObject jsonObj = JObject.Parse(json);
			this.Id = parser.ParseInt("Id", jsonObj);
			this.Name = parser.ParseString("String", jsonObj);
			this._weapons = new Dictionary<string, Weapon>();
			this.Characteristics = new Characteristics(json);
			JToken? weaponsArray = jsonObj["Weapons"];
			if (!parser.IsNullOrEmpty(weaponsArray) && weaponsArray != null)
			foreach (JObject item in weaponsArray)
			{
				this._weapons.Add(parser.ParseString("Name", item), new Weapon(item.ToString()));
			}
			this.CurrentWounds = 0;
		}
	}
}
