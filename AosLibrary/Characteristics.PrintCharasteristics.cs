using System;
using System.Collections.Generic;

namespace AosLibrary
{
	public partial class Characteristics
	{
		public void PrintCharacteristics()
		{
			foreach (KeyValuePair<int,int> item in this._move)
			{
				Console.WriteLine("Move: Bracket {0}, Value {1}", item.Key, item.Value);
			}
			Console.WriteLine("Wounds: {0}", this.Wounds);
			Console.WriteLine("Save: {0}", this.Save);
			Console.WriteLine("Bravery: {0}", this.Bravery);
		}
	}
}
