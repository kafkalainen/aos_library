using Xunit;
using AosLibrary;

namespace AosTests;

public class UnitTest2
{
	Unit _marshal;

	public UnitTest2()
	{
		FileReader file = new FileReader("../../../../Data/angry_trees.json");
		_marshal = new Unit(file.dataBuffer);
	}

    [Fact]
    public void UnitTakesDamage()
    {
		_marshal.GetDamage(2);
		Assert.Equal(2, _marshal.CurrentWounds);
    }

	[Fact]
    public void UnitTakesNegativeDamage()
    {
		_marshal.GetDamage(-2);
		Assert.Equal(0, _marshal.CurrentWounds);
    }

	[Fact]
    public void UnitTakesMoreDamage()
    {
		_marshal.GetDamage(8);
		Assert.Equal(8, _marshal.CurrentWounds);
		_marshal.GetDamage(4);
		Assert.Equal(10, _marshal.CurrentWounds);
		_marshal.GetDamage(4);
		Assert.Equal(10, _marshal.CurrentWounds);
    }
}
