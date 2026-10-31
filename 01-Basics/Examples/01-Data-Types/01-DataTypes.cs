namespace Basics.Examples;

/// <summary>
/// C# is strongly typed: every variable has a type that determines the values it can represent and the operations allowed on it. float, double, and decimal are numeric types with different precision and range; bool stores true or false.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/
/// </remarks>
public static class DataTypes
{
    public static void Run()
    {
        // Walkthrough: C# is strongly typed: every variable has a type that determines the values it can represent and the operations allowed on it. float, double, and decimal are numeric types with different precision and range; bool stores true or false.
        // float has less precision than double; decimal is useful for base-10 financial calculations.
        float x = 1.6F;
        double y = 1.6;
        decimal z = 1.6M;
        bool isReady = true;

        Console.WriteLine($"float = {x}, double = {y}, decimal = {z}");
        Console.WriteLine($"bool = {isReady}");
        Console.WriteLine($"int minimum = {int.MinValue}");
        Console.WriteLine($"int maximum = {int.MaxValue}");
    }
}
