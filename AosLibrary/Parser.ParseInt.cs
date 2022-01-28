
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AosLibrary
{
	public static partial class Utilities
	{
		public static int ParseInt(string property, JObject? obj)
		{
			int nb;

			nb = -1;
			if (obj == null)
			{
				return (nb);
			}
			JToken? token = obj[property];
			if (!Utilities.IsNullOrEmpty(token) && token != null)
			{
				nb = token.ToObject<int>();
			}
			else
			{
				throw new InvalidDataException("Property not found, data is malformed");
			}
			return (nb);
		}

		public static int ParseInt(string property, JToken? token)
		{
			int nb;

			nb = -1;
			if (!Utilities.IsNullOrEmpty(token) && token != null)
			{
				JToken? child = token[property];
				if (!Utilities.IsNullOrEmpty(child) && child != null)
				{
					nb = child.ToObject<int>();
				}
				else
				{
					throw new InvalidDataException("Property not found, data is malformed");
				}
			}
			else
			{
				throw new InvalidDataException("Property not found, data is malformed");
			}
			return (nb);
		}
	}
}
