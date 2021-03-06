using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace  AosLibrary
{
	public static partial class Utilities
	{
		public static WeaponType ParseWeaponType(string property, JObject obj)
		{
			WeaponType type;

			type = WeaponType.notset;
			if (obj == null)
			{
				throw new InvalidDataException("Invalid dataobject passed to parser.");
			}
			JToken? token = obj[property];
			if (!Utilities.IsNullOrEmpty(token) && token != null)
			{
				type = token.ToObject<WeaponType>();
			}
			return (type);
		}
	}
}
