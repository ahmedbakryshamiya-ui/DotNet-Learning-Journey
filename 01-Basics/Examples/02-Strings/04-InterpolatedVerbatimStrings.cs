namespace Basics.Examples;

/// <summary>
/// String interpolation evaluates expressions inside a string, while verbatim string literals preserve backslashes and allow line breaks. The two features can be combined.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
/// </remarks>
public static class InterpolatedVerbatimStrings
{
    public static void Run()
    {
        // Walkthrough: String interpolation evaluates expressions inside a string, while verbatim string literals preserve backslashes and allow line breaks. The two features can be combined.
        string normalString = "Ahmed\nBakry";
        string verbatimString = @"Ahmed
Bakry";

        int age = 5;
        string concatenation = "Ahmed Bakry is " + age + " years old.";
        string format = string.Format("Ahmed Bakry is {0} years old.", age);
        // Interpolation evaluates {age} and inserts its value into the resulting string.
        string interpolation = $"Ahmed Bakry is {age} years old.";

        Console.WriteLine(normalString);
        Console.WriteLine(verbatimString);
        Console.WriteLine(concatenation);
        Console.WriteLine(format);
        Console.WriteLine(interpolation);

        string fileName = "employees";
        string normalPath = "C:\\Users\\Ahmed\\Documents\\file.txt";
        string verbatimPath = @"C:\Users\Ahmed\Documents\file.txt";
        string interpolatedPath = @$"C:\Users\Ahmed\Documents\{fileName}.txt";

        Console.WriteLine(normalPath);
        Console.WriteLine(verbatimPath);
        Console.WriteLine(interpolatedPath);
    }
}
