namespace AdvancedCSharp.Examples;

/// <summary>
/// Lambda expressions create anonymous functions. A lambda can capture variables from its enclosing scope, forming a closure.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions
/// </remarks>
public static class LambdaExpressions
{
    public static void Run()
    {
        // This lambda receives one integer and returns its square.
        Func<int, int> square = number => number * number;
        Console.WriteLine($"Square of 6: {square(6)}");

        // A block lambda can contain multiple statements and an explicit return.
        Func<int, int, int> calculateTotal = (first, second) =>
        {
            int total = first + second;
            return total;
        };
        Console.WriteLine($"Total: {calculateTotal(12, 8)}");

        // This lambda captures the local variable taxRate from the enclosing method.
        decimal taxRate = 0.14m;
        Func<decimal, decimal> addTax = price => price + (price * taxRate);

        Console.WriteLine($"Price with tax: {addTax(100m):C}");
    }
}
