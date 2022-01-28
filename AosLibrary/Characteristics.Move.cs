using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AosLibrary
{
	public partial class Characteristics
	{
		public int Move(string key)
		{
			if (!_move.ContainsKey(key))
			{
				if (!_move.ContainsKey("unbracket"))
				{
					throw new ValueNotFoundException($"Error {key} was not in the list of values.");
				}
				else
				{
					key = "unbracket";
				}
			}
			if (_move[key].Min != _move[key].Max)
			{
				return (_move[key].Min + _move[key].Max / 2);
			}
			else
			{
				return (_move[key]).Min;
			}
		}
	}
}
