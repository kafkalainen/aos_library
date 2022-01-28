namespace AosLibrary
{
	public class Range
	{
		public int Min { get; private set;}
		public int Max { get; private set;}

		public Range(int min, int max)
		{
			this.Min = min;
			this.Max = max;
		}
	}
}
