using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace  AosLibrary
{
	public static partial class Utilities
	{
		public static bool IsNullOrEmpty(JToken? token)
		{
			return (token == null) ||
				(token.Type == JTokenType.Array && !token.HasValues) ||
				(token.Type == JTokenType.Object && !token.HasValues) ||
				(token.Type == JTokenType.String && token.ToString() == String.Empty) ||
				(token.Type == JTokenType.Null);
		}
	}
}
