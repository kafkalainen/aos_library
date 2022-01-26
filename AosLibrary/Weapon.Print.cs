public partial class Weapon
{
	public void PrintWeapon()
	{
		Console.WriteLine("Name:", this.name);
		Console.WriteLine("Type: ", this.move);
		Console.WriteLine("Attacks: ", this.attacks);
		Console.WriteLine("To hit: ", this.toHit);
		Console.WriteLine("To wound: ", this.toWound);
		Console.WriteLine("Rend: ", this.rend);
		Console.WriteLine("Damage: ", this.damage);
	}
}
