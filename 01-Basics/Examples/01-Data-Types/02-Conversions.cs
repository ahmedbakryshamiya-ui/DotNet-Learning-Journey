namespace Basics.Examples;

/// <summary>
/// Conversion changes a value from one type to another.
/// </summary>
public static class Conversions
{
    public static void Run()
    {
        int intValue = 10;
        double doubleValue = 15.10;

        // Implicit conversion: a smaller-range numeric type can fit in a double.
        doubleValue = intValue;
        Console.WriteLine($"Implicit conversion: {doubleValue}");

        // Explicit conversion: the cast may remove the fractional part.
        intValue = (int)15.90;
        Console.WriteLine($"Explicit conversion: {intValue}");

        string ageText = "30";
        int age = int.Parse(ageText);
        Console.WriteLine($"Parsed age: {age}");

        int price = 100;
        Console.WriteLine($"Number as text: {price.ToString()}");
    }
}
