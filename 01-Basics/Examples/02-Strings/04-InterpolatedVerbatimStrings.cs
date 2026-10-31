namespace Basics.Examples;

/// <summary>
/// Interpolation inserts values into text; verbatim strings preserve backslashes and line breaks.
/// </summary>
public static class InterpolatedVerbatimStrings
{
    public static void Run()
    {
        string normalString = "Ahmed\nBakry";
        string verbatimString = @"Ahmed
Bakry";

        int age = 5;
        string concatenation = "Ahmed Bakry is " + age + " years old.";
        string format = string.Format("Ahmed Bakry is {0} years old.", age);
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
