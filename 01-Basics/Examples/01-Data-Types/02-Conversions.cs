namespace Basics.Examples;

/// <summary>
/// C# supports implicit conversions when the language defines them as safe, explicit casts when the programmer requests a conversion that might lose information, and parsing when text must be converted to a value.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/
/// </remarks>
public static class Conversions
{
    public static void Run()
    {
        // Walkthrough: C# supports implicit conversions when the language defines them as safe, explicit casts when the programmer requests a conversion that might lose information, and parsing when text must be converted to a value.
        int intValue = 10;
        double doubleValue = 15.10;

        // Implicit conversion: a smaller-range numeric type can fit in a double.
        doubleValue = intValue;
        Console.WriteLine($"Implicit conversion: {doubleValue}");

        // Explicit conversion: the cast may remove the fractional part.
        // Converting a floating-point value to int discards the fractional part (truncates toward zero).
        intValue = (int)15.90;
        Console.WriteLine($"Explicit conversion: {intValue}");

        string ageText = "30";
        // Parse expects valid numeric text; unlike TryParse, invalid text causes a format exception.
        int age = int.Parse(ageText);
        Console.WriteLine($"Parsed age: {age}");

        int price = 100;
        Console.WriteLine($"Number as text: {price.ToString()}");
    }
}
