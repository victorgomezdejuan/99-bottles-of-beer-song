namespace BottlesOfBeer;

public class BottlesOfBeer
{
    public string[] Sing(int numberOfBootles = 99)
    {
        var lyrics = new List<string>();

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
