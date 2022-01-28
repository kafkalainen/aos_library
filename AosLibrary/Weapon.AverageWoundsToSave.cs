namespace AosLibrary
{
	public partial class Weapon
	{
		public double AverageWoundsToSave(string woundRating)
		{
			Range attacks = Utilities.RetrieveRange(woundRating, this._attacks);
			int toHit = Utilities.RetrieveValue(woundRating, this._toHit) - 1;
			int toWound = Utilities.RetrieveValue(woundRating, this._toWound) - 1;
			int rend = Utilities.RetrieveValue(woundRating, this._rend);
			Range damage = Utilities.RetrieveRange(woundRating, this._damage);
			Console.WriteLine(this.Name);
			Console.WriteLine(attacks.Min);
			Console.WriteLine(attacks.Max);
			Console.WriteLine(toHit);
			Console.WriteLine(toWound);
			double woundsToSave = ((attacks.Min + attacks.Max) / 2.0) * ((6 - toHit) / 6.0) * ((6 - toWound) / 6.0);
			return (woundsToSave);
		}
	}
}
