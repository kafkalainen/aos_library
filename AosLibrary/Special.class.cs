using Newtonsoft.Json.Linq;

namespace AosLibrary
{
	public partial class Special
	{
		bool _toHitsEnds = false;
		bool _toHitsInAddition = false;

		int _toHitWoundsOn = -1;

		Range _toHitWoundsRange = new Range(-1, -1);

		bool _toWoundEnds = false;
		bool _toWoundInAddition = false;

		int _toWoundWoundsOn = -1;

		Range _toWoundWoundsRange = new Range(-1, -1);
		bool _toHitMortalsInAddition = false;
		bool _toHitMortalsEnds = false;
		int _toHitMortalsOn = -1;
		Range _toHitMortalsRange = new Range(-1, -1);
		bool _toWoundMortalsEnds = false;

		bool _toWoundMortalsInAddition = false;

		int _toWoundMortalsOn = -1;
		Range _toWoundMortalsRange = new Range(-1, -1);

		public Special(string json)
		{
			JObject jsonObj = JObject.Parse(json);
			this._toHitsInAddition = Utilities.ParseBoolean("ToHitsInAddition", jsonObj);
			this._toHitsEnds = Utilities.ParseBoolean("ToHitsEnds", jsonObj);
			this._toHitWoundsOn = Utilities.ParseInt("ToHitWoundsOn", jsonObj);
			this._toHitWoundsRange = Utilities.ParseRange("ToHitWoundsRange", jsonObj);
			this._toWoundInAddition = Utilities.ParseBoolean("ToWoundInAddition", jsonObj);
			this._toWoundEnds = Utilities.ParseBoolean("ToWoundEnds", jsonObj);
			this._toWoundWoundsOn = Utilities.ParseInt("ToWoundWoundsOn", jsonObj);
			this._toWoundWoundsRange = Utilities.ParseRange("ToWoundWoundsRange", jsonObj);
			this._toHitMortalsInAddition = Utilities.ParseBoolean("ToHitMortalsInAddition", jsonObj);
			this._toHitMortalsEnds = Utilities.ParseBoolean("ToHitMortalsInAddition", jsonObj);
			this._toHitMortalsOn = Utilities.ParseInt("ToHitMortalsOn", jsonObj);
			this._toHitMortalsRange = Utilities.ParseRange("ToHitMortalsRange", jsonObj);
			this._toWoundMortalsInAddition = Utilities.ParseBoolean("ToWoundMortalsInAddition", jsonObj);
			this._toWoundMortalsEnds = Utilities.ParseBoolean("ToWoundMortalsInAddition", jsonObj);
			this._toWoundMortalsOn = Utilities.ParseInt("ToWoundMortalsOn", jsonObj);
			this._toWoundMortalsRange = Utilities.ParseRange("ToWoundMortalsRange", jsonObj);
		}
	}
}
