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
}