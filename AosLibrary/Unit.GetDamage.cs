namespace AosLibrary
{
	public partial class Unit
	{
		public void GetDamage(int damage)
		{
			if (damage > 0 && CurrentWounds <= this.Characteristics.Wounds)
			{
				CurrentWounds += damage;
				if (CurrentWounds > this.Characteristics.Wounds)
				{
					CurrentWounds = this.Characteristics.Wounds;
				}
			}
		}
	}
}
