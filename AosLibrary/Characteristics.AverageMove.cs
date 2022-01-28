using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AosLibrary
{
	public partial class Characteristics
	{
		public double AverageMove(string key)
		{
			Range move = this.MoveRange(key);
			return (move.Min + move.Max / 2.0);
		}
	}
}
