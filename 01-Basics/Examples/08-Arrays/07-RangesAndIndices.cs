namespace Basics.Examples;

/// <summary>
/// An Index selects one position; a Range selects a portion of a collection.
/// </summary>
public static class RangesAndIndices
{
    public static void Run()
    {
        string[] cities = { "Alex", "Cairo", "KFS", "Nasr City" };

        Console.WriteLine($"Last city: {cities[^1]}");
        Console.WriteLine($"Third city from the end: {cities[^3]}");

        Console.WriteLine("All cities:");
        foreach (string city in cities[..])
            Console.WriteLine(city);

        Console.WriteLine("Selected range:");
        string[] visitedCities = cities[1..3];
        foreach (string city in visitedCities)
            Console.WriteLine(city);

        Range cityRange = 0..4;
        Console.WriteLine($"Range type: {cityRange.GetType().Name}");
        Console.WriteLine($"Start: {cityRange.Start}, End: {cityRange.End}");
    }
}
