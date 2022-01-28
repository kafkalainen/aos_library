using System;

namespace AosLibrary
{
	public partial class Weapon
	{
		public void PrintWeapon()
		{
			Console.WriteLine($"Name: {this.Name}");
			Console.WriteLine($"Type: {this.Type}");
			this.PrintDictionary("Attacks", this._attacks);
			this.PrintDictionary("To hit", this._toHit);
			this.PrintDictionary("To wound", this._toWound);
			this.PrintDictionary("Rend", this._rend);
			this.PrintDictionary("Damage", this._damage);
		}
	}
}
