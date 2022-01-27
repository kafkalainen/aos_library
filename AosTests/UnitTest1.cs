using Xunit;
using AosLibrary;

namespace AosTests;

public class UnitTest1
{
    [Fact]
    public void TestValidInput()
    {
        FileReader file = new FileReader("../../../../Data/angry_trees.json");
        Unit marshal = new Unit(file.dataBuffer);
        Assert.Equal(8, marshal.Characteristics.Bravery);
        Assert.Equal(9, marshal.Characteristics.Move(9));
        Assert.Equal(10, marshal.Characteristics.Wounds);
    }
}
