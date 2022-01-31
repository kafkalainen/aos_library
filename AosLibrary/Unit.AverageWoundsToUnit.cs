namespace AosLibrary
{
	public partial class Unit
	{
		public void AverageWoundsToUnit(WeaponType type)
		{

			foreach (KeyValuePair<string, Weapon> weapon in this._weapons)
			{
				if (type == weapon.Value.Type)
				{
					double averageWounds = weapon.Value.AverageWoundsToSave(this.CurrentWounds.ToString());
					double averageMortals = weapon.Value.AverageMortals(this.CurrentWounds.ToString());
					Console.WriteLine($"Average wounds to save: {averageWounds}");
					Console.WriteLine($"Average mortals: {averageMortals}");
				}
			}
		}
	}
}
