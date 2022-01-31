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
			double woundsToHit = attacks.Average() * ((6 - toHit) / 6.0);
			double woundsToSave = 0.0;
			if (this._special.ToHitsInAddition)
			{
				woundsToHit += attacks.Average() * ((6 - (this._special.ToHitWoundsOn - 1)) / 6.0)
				* this._special.ToHitWoundsRange.Average();
			}
			if (this._special.ToHitsEnds)
			{
				woundsToHit -= attacks.Average() * ((6 - (this._special.ToHitWoundsOn - 1)) / 6.0);
				woundsToSave += attacks.Average() * ((6 - (this._special.ToHitWoundsOn - 1)) / 6.0)
				* this._special.ToHitWoundsRange.Average();
			}
			if (this._special.ToHitMortalsEnds)
			{
				woundsToHit -= attacks.Average() * ((6 - (this._special.ToHitMortalsOn - 1)) / 6.0);
			}
			woundsToSave += woundsToHit * ((6 - toWound) / 6.0);
			if (this._special.ToWoundInAddition)
			{
				woundsToSave += woundsToHit * ((6 - (this._special.ToWoundWoundsOn - 1)) / 6.0)
				* this._special.ToWoundWoundsRange.Average();
			}
			if (this._special.ToWoundEnds) // If attack scores multiple wounds if unchanged roll is 6 etc.
			{
				woundsToSave -= woundsToHit * ((6 - (this._special.ToWoundWoundsOn - 1)) / 6.0);
				woundsToSave += woundsToHit * ((6 - (this._special.ToWoundWoundsOn - 1)) / 6.0)
				* this._special.ToWoundWoundsRange.Average();
			}
			if (this._special.ToWoundMortalsEnds) //If we score mortals on unchanged dice roll, we subtract that from original roll.
			{
				woundsToSave -= woundsToHit * (6 - (this._special.ToWoundMortalsOn - 1) / 6.0)
				* this._special.ToWoundMortalsRange.Average();
			}
			return (woundsToSave);
		}
	}
}
