namespace Basics.Examples;

/// <summary>
/// The index-from-end operator (^) counts backward from the end of a collection. A range (start..end) selects elements from the inclusive start up to, but not including, the end.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators#range-operator-
/// </remarks>
public static class RangesAndIndices
{
    public static void Run()
    {
        // Walkthrough: The index-from-end operator (^) counts backward from the end of a collection. A range (start..end) selects elements from the inclusive start up to, but not including, the end.
        string[] cities = { "Alex", "Cairo", "KFS", "Nasr City" };

        Console.WriteLine($"Last city: {cities[^1]}");
        Console.WriteLine($"Third city from the end: {cities[^3]}");

        Console.WriteLine("All cities:");
        foreach (string city in cities[..])
            Console.WriteLine(city);

        Console.WriteLine("Selected range:");
        // The start index is included; the end index is excluded, so this selects elements 1 and 2.
        string[] visitedCities = cities[1..3];
        foreach (string city in visitedCities)
            Console.WriteLine(city);

        Range cityRange = 0..4;
        Console.WriteLine($"Range type: {cityRange.GetType().Name}");
        Console.WriteLine($"Start: {cityRange.Start}, End: {cityRange.End}");
    }
}
