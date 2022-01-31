using Newtonsoft.Json.Linq;

namespace AosLibrary
{
	public partial class Special
	{
		public bool ToHitsEnds {get; private set;}  = false;
		public bool ToHitsInAddition {get; private set;} = false;

		public int ToHitWoundsOn {get; private set;} = -1;

		public Range ToHitWoundsRange {get; private set;} = new Range(-1, -1);

		public bool ToWoundEnds {get; private set;} = false;
		public bool ToWoundInAddition {get; private set;} = false;

		public int ToWoundWoundsOn {get; private set;} = -1;

		public Range ToWoundWoundsRange {get; private set;} = new Range(-1, -1);
		public bool ToHitMortalsInAddition {get; private set;} = false;
		public bool ToHitMortalsEnds {get; private set;} = false;
		public int ToHitMortalsOn {get; private set;} = -1;
		public Range ToHitMortalsRange {get; private set;} = new Range(-1, -1);
		public bool ToWoundMortalsEnds {get; private set;} = false;

		public bool ToWoundMortalsInAddition {get; private set;} = false;

		public int ToWoundMortalsOn {get; private set;} = -1;
		public Range ToWoundMortalsRange {get; private set;} = new Range(-1, -1);

		public Special(string json)
		{
			JObject jsonObj = JObject.Parse(json);
			this.ToHitsInAddition = Utilities.ParseBoolean("ToHitsInAddition", jsonObj);
			this.ToHitsEnds = Utilities.ParseBoolean("ToHitsEnds", jsonObj);
			this.ToHitWoundsOn = Utilities.ParseInt("ToHitWoundsOn", jsonObj);
			this.ToHitWoundsRange = Utilities.ParseRange("ToHitWoundsRange", jsonObj);
			this.ToWoundInAddition = Utilities.ParseBoolean("ToWoundInAddition", jsonObj);
			this.ToWoundEnds = Utilities.ParseBoolean("ToWoundEnds", jsonObj);
			this.ToWoundWoundsOn = Utilities.ParseInt("ToWoundWoundsOn", jsonObj);
			this.ToWoundWoundsRange = Utilities.ParseRange("ToWoundWoundsRange", jsonObj);
			this.ToHitMortalsInAddition = Utilities.ParseBoolean("ToHitMortalsInAddition", jsonObj);
			this.ToHitMortalsEnds = Utilities.ParseBoolean("ToHitMortalsEnds", jsonObj);
			this.ToHitMortalsOn = Utilities.ParseInt("ToHitMortalsOn", jsonObj);
			this.ToHitMortalsRange = Utilities.ParseRange("ToHitMortalsRange", jsonObj);
			this.ToWoundMortalsInAddition = Utilities.ParseBoolean("ToWoundMortalsInAddition", jsonObj);
			this.ToWoundMortalsEnds = Utilities.ParseBoolean("ToWoundMortalsEnds", jsonObj);
			this.ToWoundMortalsOn = Utilities.ParseInt("ToWoundMortalsOn", jsonObj);
			this.ToWoundMortalsRange = Utilities.ParseRange("ToWoundMortalsRange", jsonObj);
		}
	}
}
