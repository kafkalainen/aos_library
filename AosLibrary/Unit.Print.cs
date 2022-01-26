using System;

namespace AosLibrary
{
	public partial class Unit
	{
		public void PrintUnitInformation()
		{
			Console.WriteLine("Id: {0}", this.Id);
			Console.WriteLine("Name: {0}", this.Name);
			this.Characteristics.PrintCharacteristics();
		}
	}
}
