using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AosLibrary
{
	public partial class Characteristics
	{
		private Dictionary<string, Range> _move = new Dictionary<string, Range>();
		public int Wounds { get; private set; }
		public int Save { get; private set; }
		public int Bravery { get; private set; }

		public Characteristics(string? json)
		{
			if (json != null)
			{
				JObject jsonObj = JObject.Parse(json);
				JToken? characteristicsJson = jsonObj["Characteristics"];
				if (!Utilities.IsNullOrEmpty(characteristicsJson) && characteristicsJson != null)
				{
					JToken? moveJson = characteristicsJson["Move"];
					if (!Utilities.IsNullOrEmpty(moveJson) && moveJson != null)
					{
						Dictionary<string, Range>? testDictionary = moveJson.ToObject<Dictionary<string, Range>>();
						if (testDictionary != null)
							this._move = testDictionary;
					}
					this.Wounds = Utilities.ParseInt("Wounds", characteristicsJson);
					this.Save = Utilities.ParseInt("Save", characteristicsJson);
					this.Bravery = Utilities.ParseInt("Bravery", characteristicsJson);
				}
			}
		}

		public Characteristics()
		{
			this.Wounds = 0;
			this.Bravery = 0;
			this.Save = 0;
		}
	}
}
