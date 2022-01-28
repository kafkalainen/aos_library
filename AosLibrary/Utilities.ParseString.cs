using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace  AosLibrary
{
	public static partial class Utilities
	{
		public static string ParseString(string property, JObject obj)
		{
			string str;

			str = string.Empty;
			JToken? token = obj[property];
			if (!Utilities.IsNullOrEmpty(token) && token != null)
			{
				string? tested = token.ToObject<string>();
				if (tested != null)
				{
					str = tested;
				}
				else
				{
					throw new InvalidDataException("Couldn't convert to non-nullable string.");
				}
			}
			else
			{
				throw new InvalidDataException("Property not found, data is malformed.");
			}
			return (str);
		}
	}
}
