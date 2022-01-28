using System;

namespace AosLibrary
{
	public partial class Weapon
	{
		public void PrintWeapon()
		{
			Console.WriteLine("Name:", this.Name);
			Console.WriteLine("Type: ", this.Type);
			// Console.WriteLine("Attacks: ", this.attacks);
			// Console.WriteLine("To hit: ", this.toHit);
			// Console.WriteLine("To wound: ", this.toWound);
			// Console.WriteLine("Rend: ", this.rend);
			// Console.WriteLine("Damage: ", this.damage);
		}
	}
}
