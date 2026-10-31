namespace Basics.Examples;

/// <summary>
/// System.Math contains common mathematical methods.
/// </summary>
public static class MathFunctions
{
    public static void Run()
    {
        int x = -10;
        int a = 5;
        double y = 3.5;
        int z = 4;

        Console.WriteLine($"Ceiling: {Math.Ceiling(y)}");
        Console.WriteLine($"Floor: {Math.Floor(y)}");
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
