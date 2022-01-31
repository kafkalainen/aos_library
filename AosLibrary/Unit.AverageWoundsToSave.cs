namespace AosLibrary
{
	public partial class Unit
	{
		public void AverageWoundsToSave()
		{
			foreach (KeyValuePair<string, Weapon> weapon in this._weapons)
			{
				double averageWounds = weapon.Value.AverageWoundsToSave(this.CurrentWounds.ToString());
				double averageMortals = weapon.Value.AverageMortals(this.CurrentWounds.ToString());
				Console.WriteLine($"Average wounds to save: {averageWounds}");
				Console.WriteLine($"Average mortals: {averageMortals}");
				Console.WriteLine($"Total: {averageMortals + averageWounds}");
			}
		}
	}
}
