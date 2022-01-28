namespace AosLibrary
{
	public partial class Unit
	{
		public Range MoveRange()
		{
			return (this.Characteristics.MoveRange(this.CurrentWounds.ToString()));
		}
	}
}
