namespace AosLibrary
{
	public struct Range
	{
		private int min { get; }
		private int max { get; }

		public Range(int min, int max)
		{
			this.min = min;
			this.max = max;
		}
	}
}
