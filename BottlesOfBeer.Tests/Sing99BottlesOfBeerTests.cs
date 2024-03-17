using FluentAssertions;

namespace BottlesOfBeer.Tests;

public class Sing99BottlesOfBeerTests
{
    readonly BottlesOfBeer bottlesOfBeer;

    public Sing99BottlesOfBeerTests() => bottlesOfBeer = new BottlesOfBeer();

    [Fact]
    public void ZeroBottles()
    {
        var result = bottlesOfBeer.Sing(0);

        result.Length.Should().Be(2);
        result[0].Should().Be("No more bottles of beer on the wall, no more bottles of beer.");
        result[1].Should().Be("Go to the store and buy some more, 99 bottles of beer on the wall.");
    }

    [Fact]
    public void OneBottle()
    {
        var result = bottlesOfBeer.Sing(1);

        result.Length.Should().Be(4);
        result[0].Should().Be("1 bottle of beer on the wall, 1 bottle of beer.");
        result[1].Should().Be("Take one down and pass it around, no more bottles of beer on the wall.");
    }

    [Fact]
    public void TwoBottles()
    {
        var result = bottlesOfBeer.Sing(2);

        result.Length.Should().Be(6);
        result[0].Should().Be("2 bottles of beer on the wall, 2 bottles of beer.");
        result[1].Should().Be("Take one down and pass it around, 1 bottle of beer on the wall.");
    }

    [Fact]
    public void ThreeBottles()
    {
        var result = bottlesOfBeer.Sing(3);

        result.Length.Should().Be(8);
        result[0].Should().Be("3 bottles of beer on the wall, 3 bottles of beer.");
        result[1].Should().Be("Take one down and pass it around, 2 bottles of beer on the wall.");
    }

    [Fact]
    public void NinetyNineBottles()
    {
        var result = bottlesOfBeer.Sing();

        result.Length.Should().Be(200);
        result[0].Should().Be("99 bottles of beer on the wall, 99 bottles of beer.");
        result[1].Should().Be("Take one down and pass it around, 98 bottles of beer on the wall.");
        result[44].Should().Be("77 bottles of beer on the wall, 77 bottles of beer.");
        result[45].Should().Be("Take one down and pass it around, 76 bottles of beer on the wall.");
    }
}