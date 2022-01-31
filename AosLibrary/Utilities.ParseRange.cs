
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AosLibrary
{
	public static partial class Utilities
	{
		public static Range ParseRange(string property, JObject? obj)
		{
			Range? val;

			val = new Range(-1, -1);
			if (obj == null)
			{
				throw new InvalidDataException("Invalid dataobject passed to parser.");
			}
			JToken? token = obj[property];
			if (!Utilities.IsNullOrEmpty(token) && token != null)
			{
				Range? testVal = token.ToObject<Range>();
				if (testVal != null)
				{
					val = testVal;
				}
			}
			else
			{
				throw new InvalidDataException("Property not found, data is malformed");
			}
			return (val);
		}
	}
}
