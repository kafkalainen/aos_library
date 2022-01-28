namespace AosLibrary
{
	public partial class Weapon
	{
		public void PrintDictionary(string property, Dictionary<string, int> list)
		{
			Console.WriteLine($"{property}: ");
			foreach (KeyValuePair<string, int> item in list)
			{
				if (item.Key == "unbracket")
				{
					Console.WriteLine(item.Value);
				}
				else
				{
					Console.WriteLine($"At {item.Key} has {item.Value}");
				}
			}
		}

		public void PrintDictionary(string property, Dictionary<string, Range> list)
		{
			Console.WriteLine($"{property}: ");
			foreach (KeyValuePair<string, Range> item in list)
			{
				if (item.Key == "unbracket")
				{
					if (item.Value.Min == item.Value.Max)
					{
						Console.WriteLine(item.Value.Min);
					}
					else
					{
						Console.WriteLine($"{item.Value.Min} .. {item.Value.Max}");
					}
				}
				else
				{
					if (item.Value.Min == item.Value.Max)
					{
						Console.WriteLine($"At {item.Key} has {item.Value.Min}");
					}
					else
					{
						Console.WriteLine($"At {item.Key} has range {item.Value.Min} .. {item.Value.Max}");
					}
				}
			}
		}
	}
}

