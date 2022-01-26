using System;

public partial class Characteristics
{
	private Dictionary<int, int> move { get; set; }
	private int wounds { get; set; }
	private int save { get; set; }
	private int bravery { get; set; }

	public Characteristics(string csv)
	{
		Parser parser = new Parser();
		string[] values = csv.Split(',');

		move = parser.ParseInt(ref values[0]);
		wounds = parser.ParseInt(ref values[1]);
		save = parser.ParseInt(ref values[2]);
		bravery = parser.ParseInt(ref values[3]);
	}
}
