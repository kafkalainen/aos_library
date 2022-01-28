namespace AosLibrary
{
	public partial class Unit
	{
		public void AverageWoundsToSave()
		{
			foreach (KeyValuePair<string, Weapon> weapon in this._weapons)
			{
				Console.WriteLine(weapon.Value.AverageWoundsToSave(this.CurrentWounds.ToString()));
			}
		}
	}
}
