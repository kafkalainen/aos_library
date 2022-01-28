namespace AosLibrary
{
	public static partial class Utilities
	{
		public static int RetrieveValue(string key, Dictionary<string, int> dictionary)
		{
			int currentValue = -1;
			if (!dictionary.TryGetValue(key, out currentValue))
			{
			 	if (dictionary.TryGetValue("unbracket", out currentValue) && currentValue != -1)
				{
					return (dictionary["unbracket"]);
				}
				else
				{
					throw new ValueNotFoundException($"Error {key} was not in the list of values.");
				}
			}
			return (dictionary[key]);
		}
	}
}
