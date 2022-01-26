using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AosLibrary
{
	public partial class Unit
	{
		public int Id { get; private set;}
		public string Name { get; private set;} = string.Empty;
		public Characteristics Characteristics { get; private set; }
		// public Weapon Weapon { get; set; }

		public Unit(string json)
		{
			dynamic jsonObject = JsonConvert.DeserializeObject(json);
			this.Id = jsonObject.Id;
			this.Name = jsonObject.Name;
			this.Characteristics = new Characteristics(json);
		}
	}
}
