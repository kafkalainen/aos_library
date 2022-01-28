
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AosLibrary
{
	public partial class Parser
	{
		public int ParseInt(string property, JObject? obj)
		{
			int nb;

			nb = -1;
			if (obj == null)
			{
				return (nb);
			}
			JToken? token = obj[property];
			if (!IsNullOrEmpty(token) && token != null)
			{
				nb = token.ToObject<int>();
			}
			return (nb);
		}

		public int ParseInt(string property, JToken? token)
		{
			int nb;

			nb = -1;
			if (!IsNullOrEmpty(token) && token != null)
			{
				JToken? child = token[property];
				if (!IsNullOrEmpty(child) && child != null)
				{
					nb = child.ToObject<int>();
				}
			}
			return (nb);
		}
	}
}
