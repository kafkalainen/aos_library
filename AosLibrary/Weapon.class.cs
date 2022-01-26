using System;

public class Weapon
{
	int	id { get; }
	string name { get; }
	WeaponType type { get; }
	Dictionary<int, Range> attacks { get; }
	Dictionary<int, int> toHit { get; }
	Dictionary<int, int> toWound { get; }
	Dictionary<int, int> rend { get; }
	Dictionary<int, Range> damage { get; }

	Weapon(int id, string csv)
	{
		string[] values = csv.Split(',');
		Parser parser = new Parser();

		this.id = id;
		this.name = values[0];
		this.type = (WeaponType)Enum.Parse(typeof(WeaponType), values[1]);
		this.attacks = parser.ParseInt(ref values[2]);
		this.toHit = parser.ParseInt(ref values[3]);
		this.toWound = parser.ParseInt(ref values[4]);
		this.rend = parser.ParseInt(ref values[5]);
		this.damage = parser.ParseInt(ref values[6]);
	}
}
