namespace BottlesOfBeer;

public class BottlesOfBeer
{
    public string[] Sing(int numberOfBootles = 99)
    {
        var lyrics = new List<string>();

        for (var i = numberOfBootles; i > 2; i--)
        {
            lyrics.Add($"{i} bottles of beer on the wall, {i} bottles of beer.");
            lyrics.Add($"Take one down and pass it around, {i - 1} bottles of beer on the wall.");
        }

        if (numberOfBootles >= 2)
        {
            lyrics.Add($"2 bottles of beer on the wall, 2 bottles of beer.");
            lyrics.Add($"Take one down and pass it around, 1 bottle of beer on the wall.");
        }

        if (numberOfBootles >= 1)
        {
            lyrics.Add("1 bottle of beer on the wall, 1 bottle of beer.");
            lyrics.Add("Take one down and pass it around, no more bottles of beer on the wall.");
        }

        if (numberOfBootles >= 0)
        {
            lyrics.Add("No more bottles of beer on the wall, no more bottles of beer.");
            lyrics.Add("Go to the store and buy some more, 99 bottles of beer on the wall.");
        }

        return lyrics.ToArray();
    }
}
