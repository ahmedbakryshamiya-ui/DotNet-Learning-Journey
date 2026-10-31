namespace Basics.Examples;

/// <summary>
/// Arithmetic operators perform calculations on numeric values.
/// </summary>
public static class ArithmeticOperators
{
    public static void Run()
    {
        int x = 10;
        int y = 3;

        Console.WriteLine($"Addition: {x + y}");
        Console.WriteLine($"Subtraction: {x - y}");
        Console.WriteLine($"Multiplication: {x * y}");
        Console.WriteLine($"Integer division: {x / y}");
        Console.WriteLine($"Remainder: {x % y}");
    }
}
