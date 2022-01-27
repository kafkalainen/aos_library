using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AosLibrary
{
	public partial class Characteristics
	{
		private Dictionary<int, int> _move;
		public int Wounds { get; private set; }
		public int Save { get; private set; }
		public int Bravery { get; private set; }

		public Characteristics(string? json)
		{
			if (json != null)
			{
				dynamic? jsonObject = JsonConvert.DeserializeObject(json);
				string movementJson = JsonConvert.SerializeObject(jsonObject.Characteristics.Movement);
				this._move = JsonConvert.DeserializeObject<Dictionary<int, int>>(movementJson);
				this.Wounds = jsonObject.Characteristics.Wounds;
				this.Save = jsonObject.Characteristics.Save;
				this.Bravery = jsonObject.Characteristics.Bravery;
			}
		}
		public int Move(int key)
		{
			if (!_move.ContainsKey(key))
			{
				throw new ValueNotFoundException($"Error {key} was not in the list of values.");
			}
			return (_move[key]);
		}
	}
}
