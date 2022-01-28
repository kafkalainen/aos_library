using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace  AosLibrary
{
	public partial class Parser
	{
		public WeaponType ParseWeaponType(string property, JObject obj)
		{
			WeaponType type;

			type = WeaponType.notset;
			if (obj == null)
			{
				return (type);
			}
			JToken? token = obj[property];
			if (!IsNullOrEmpty(token) && token != null)
			{
				type = token.ToObject<WeaponType>();
			}
			return (type);
		}
	}
}
