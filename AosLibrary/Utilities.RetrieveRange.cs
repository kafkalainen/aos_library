namespace AosLibrary
{
	public static partial class Utilities
	{
		public static Range RetrieveRange(string key, Dictionary<string, Range> dictionary)
		{
			Range? currentRange;
			if (!dictionary.TryGetValue(key, out currentRange))
			{
			 	if (dictionary.TryGetValue("unbracket", out currentRange) && currentRange != null)
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
