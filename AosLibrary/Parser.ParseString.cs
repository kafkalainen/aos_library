using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace  AosLibrary
{
	public partial class Parser
	{
		public string ParseString(string property, JObject obj)
		{
			string str;

			str = string.Empty;
			if (obj == null)
			{
				return (str);
			}
			JToken? token = obj[property];
			if (!IsNullOrEmpty(token) && token != null)
			{
				string? tested = token.ToObject<string>();
				if (tested != null)
				{
					str = tested;
				}
			}
			return (str);
		}
	}
}
