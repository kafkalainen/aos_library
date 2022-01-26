using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AosLibrary
{
	public partial class Characteristics
	{
		public Dictionary<int, int> Move { get; private set; }
		public int Wounds { get; private set; }
		public int Save { get; private set; }
		public int Bravery { get; private set; }

		public Characteristics(string? json)
		{
			if (json != null)
			{
				dynamic? jsonObject = JsonConvert.DeserializeObject(json);
				string movementJson = JsonConvert.SerializeObject(jsonObject.Characteristics.Movement);
				this.Move = JsonConvert.DeserializeObject<Dictionary<int, int>>(movementJson);
				this.Wounds = jsonObject.Characteristics.Wounds;
				this.Save = jsonObject.Characteristics.Save;
				this.Bravery = jsonObject.Characteristics.Bravery;
			}
		}
	}
}
