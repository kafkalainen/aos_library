namespace AosLibrary
{
	public partial class Weapon
	{
		public double AverageMortals(string woundRating)
		{
			Range attacks = Utilities.RetrieveRange(woundRating, this._attacks);
			int toHit = Utilities.RetrieveValue(woundRating, this._toHit) - 1;
			int toWound = Utilities.RetrieveValue(woundRating, this._toWound) - 1;
			Range damage = Utilities.RetrieveRange(woundRating, this._damage);
			double woundsToHit = attacks.Average() * ((6 - toHit) / 6.0);
			double mortals = 0.0;
			if (this._special.ToHitMortalsEnds)
			{
				mortals += attacks.Average() * ((6 - (this._special.ToHitMortalsOn - 1)) / 6.0)
				* this._special.ToHitMortalsRange.Average();
			}
			if (this._special.ToHitMortalsInAddition)
			{
				mortals += attacks.Average() * ((6 - (this._special.ToHitMortalsOn - 1)) / 6.0)
				* this._special.ToHitMortalsRange.Average();
			}
			if (this._special.ToWoundMortalsEnds)
			{
				mortals += woundsToHit * (6 - (this._special.ToWoundMortalsOn - 1) / 6.0)
				* this._special.ToWoundMortalsRange.Average();
			}
			if (this._special.ToWoundMortalsInAddition)
			{
				mortals += woundsToHit * (6 - (this._special.ToWoundMortalsOn - 1) / 6.0)
				* this._special.ToWoundMortalsRange.Average();
			}
			return (mortals);
		}
	}
}
