using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace  AosLibrary
{
	public static partial class Utilities
	{
		public static Dictionary<string, TValue> ParseDictionary<TValue>(string property, JObject obj)
		{
			Dictionary<string, TValue> dictionary = new Dictionary<string, TValue>();

			JToken? token = obj[property];
			if (!Utilities.IsNullOrEmpty(token) && token != null)
			{
				Dictionary<string, TValue>? possiblyNullDictionary = token.ToObject<Dictionary<string, TValue>>();
				if (possiblyNullDictionary != null)
					dictionary = possiblyNullDictionary;
			}
			return (dictionary);
		}
	}
}
