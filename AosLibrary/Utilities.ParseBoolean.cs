
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AosLibrary
{
	public static partial class Utilities
	{
		public static bool ParseBoolean(string property, JObject? obj)
		{
			bool val;

			val = false;
			if (obj == null)
			{
				throw new InvalidDataException("Invalid dataobject passed to parser.");
			}
			JToken? token = obj[property];
			if (!Utilities.IsNullOrEmpty(token) && token != null)
			{
				val = token.ToObject<bool>();
			}
			else
			{
				throw new InvalidDataException("Property not found, data is malformed");
			}
			return (val);
		}
	}
}
