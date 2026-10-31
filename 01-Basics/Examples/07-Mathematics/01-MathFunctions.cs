namespace Basics.Examples;

/// <summary>
/// System.Math provides static methods for common mathematical operations such as rounding, absolute values, powers, roots, and integer division. Math.Round uses midpoint rounding to even by default unless a different mode is supplied.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/system.math
/// </remarks>
public static class MathFunctions
{
    public static void Run()
    {
        // Walkthrough: System.Math provides static methods for common mathematical operations such as rounding, absolute values, powers, roots, and integer division. Math.Round uses midpoint rounding to even by default unless a different mode is supplied.
        int x = -10;
        int a = 5;
        double y = 3.5;
        int z = 4;

        Console.WriteLine($"Ceiling: {Math.Ceiling(y)}");
        Console.WriteLine($"Floor: {Math.Floor(y)}");
        // Math.Round uses midpoint-to-even by default; pass MidpointRounding to select a different rule.
        Console.WriteLine($"Round: {Math.Round(y)}");
        Console.WriteLine($"Absolute value: {Math.Abs(x)}");
        Console.WriteLine($"Big multiplication: {Math.BigMul(a, z)}");
        Console.WriteLine($"Maximum: {Math.Max(x, y)}");
        Console.WriteLine($"Minimum: {Math.Min(x, y)}");
        Console.WriteLine($"Square root: {Math.Sqrt(z)}");
        Console.WriteLine($"Power: {Math.Pow(a, z)}");

        (int quotient, int remainder) = Math.DivRem(13, 3);
        Console.WriteLine($"DivRem: quotient = {quotient}, remainder = {remainder}");
    }
}
