namespace Basics.Examples;

/// <summary>
/// Arithmetic operators perform numeric operations. When both operands of division are integral types, the result is integral and the fractional part is discarded.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators
/// </remarks>
public static class ArithmeticOperators
{
    public static void Run()
    {
        // Walkthrough: Arithmetic operators perform numeric operations. When both operands of division are integral types, the result is integral and the fractional part is discarded.
        int x = 10;
        int y = 3;

        Console.WriteLine($"Addition: {x + y}");
        Console.WriteLine($"Subtraction: {x - y}");
        Console.WriteLine($"Multiplication: {x * y}");
        // Both operands are int, so 10 / 3 produces 3 rather than 3.333....
        Console.WriteLine($"Integer division: {x / y}");
        Console.WriteLine($"Remainder: {x % y}");
    }
}
