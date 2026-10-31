namespace Basics.Examples;

/// <summary>
/// Strings provide methods for searching, trimming, changing, and extracting text.
/// </summary>
public static class StringManipulation
{
    public static void Run()
    {
        string movieName = "LORD oF the RINGs";

        Console.WriteLine(movieName);
        Console.WriteLine($"Length: {movieName.Length}");
        Console.WriteLine($"Trim: {movieName.Trim()}");
        Console.WriteLine($"Character at index 5: {movieName[5]}");
        Console.WriteLine($"Upper: {movieName.ToUpper()}");
        Console.WriteLine($"Lower: {movieName.ToLower()}");
        Console.WriteLine($"Replace: {movieName.Replace("LORD", "Lord")}");
        Console.WriteLine($"IndexOf: {movieName.IndexOf("o")}");
        Console.WriteLine($"LastIndexOf: {movieName.LastIndexOf("o")}");
        Console.WriteLine($"Substring: {movieName.Substring(4, 10)}");
        Console.WriteLine($"Remove: {movieName.Remove(10)}");
        Console.WriteLine($"Insert: {movieName.Insert(0, "The ")}");
        Console.WriteLine($"Contains LORD: {movieName.Contains("LORD")}");
    }
}
