namespace Basics.Examples;

/// <summary>
/// String methods search, extract, or produce modified text. A string is immutable, so methods such as Replace, ToUpper, and Remove return new strings rather than changing the original string.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/strings/
/// </remarks>
public static class StringManipulation
{
    public static void Run()
    {
        // Walkthrough: String methods search, extract, or produce modified text. A string is immutable, so methods such as Replace, ToUpper, and Remove return new strings rather than changing the original string.
        string movieName = "LORD oF the RINGs";

        Console.WriteLine(movieName);
        Console.WriteLine($"Length: {movieName.Length}");
        Console.WriteLine($"Trim: {movieName.Trim()}");
        Console.WriteLine($"Character at index 5: {movieName[5]}");
        Console.WriteLine($"Upper: {movieName.ToUpper()}");
        Console.WriteLine($"Lower: {movieName.ToLower()}");
        // String operations return new strings; movieName itself is unchanged because strings are immutable.
        Console.WriteLine($"Replace: {movieName.Replace("LORD", "Lord")}");
        Console.WriteLine($"IndexOf: {movieName.IndexOf("o")}");
        Console.WriteLine($"LastIndexOf: {movieName.LastIndexOf("o")}");
        Console.WriteLine($"Substring: {movieName.Substring(4, 10)}");
        Console.WriteLine($"Remove: {movieName.Remove(10)}");
        Console.WriteLine($"Insert: {movieName.Insert(0, "The ")}");
        Console.WriteLine($"Contains LORD: {movieName.Contains("LORD")}");
    }
}
