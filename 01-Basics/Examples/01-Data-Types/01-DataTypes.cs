namespace Basics.Examples;

/// <summary>
/// Data types define what kind of value a variable can store.
/// </summary>
public static class DataTypes
{
    public static void Run()
    {
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
