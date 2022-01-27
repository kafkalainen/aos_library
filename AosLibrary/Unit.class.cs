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
		public Characteristics Characteristics { get; private set; }
		private Dictionary<int, Weapon> _weapons;
		public Unit(string json)
		{
			dynamic? jsonObject = JsonConvert.DeserializeObject(json);
			this.Id = jsonObject.Id;
			this.Name = jsonObject.Name;
			this.Characteristics = new Characteristics(json);
			JObject jsonObj = JObject.Parse(json);
			Console.WriteLine(jsonObj["Weapons"].ToString());
			// foreach (dynamic weapon in jsonObject.Weapons)
			// {
			// 	Console.WriteLine(weapon);
			// }
			// this._weapons = jsonObject.
			this.CurrentWounds = 0;
		}
	}
}
