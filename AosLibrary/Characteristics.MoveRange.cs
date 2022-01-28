using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AosLibrary
{
	public partial class Characteristics
	{
		public Range MoveRange(string key)
		{
			return (Utilities.RetrieveRange(key, this._move));
		}
	}
}
