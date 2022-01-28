using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace  AosLibrary
{
	public partial class Parser
	{
		public Dictionary<string, TValue> ParseDictionary<TValue>(string property, JObject obj)
		{
			Dictionary<string, TValue> dictionary = new Dictionary<string, TValue>();

			JToken? token = obj[property];
			if (!IsNullOrEmpty(token) && token != null)
			{
				Dictionary<string, TValue>? possiblyNullDictionary = token.ToObject<Dictionary<string, TValue>>();
				if (possiblyNullDictionary != null)
					dictionary = possiblyNullDictionary;
			}
			return (dictionary);
		}
	}
}
