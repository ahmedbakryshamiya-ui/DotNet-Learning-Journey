namespace AdvancedCSharp.Examples;

/// <summary>
/// A delegate is a type-safe reference to a method with a compatible parameter list and return type.
/// Func, Action, and Predicate are common built-in generic delegate types.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/
/// </remarks>
public static class Delegates
{
    // This custom delegate describes methods that accept two integers and return an integer.
    private delegate int Calculation(int first, int second);

    public static void Run()
    {
        // A method group can be assigned to a compatible delegate variable.
        Calculation operation = Add;
        Console.WriteLine($"Custom delegate: {operation(10, 5)}");

        // Func represents a method that returns a value.
        Func<int, int, int> multiply = Multiply;
        Console.WriteLine($"Func: {multiply(4, 3)}");

        // Action represents a method that returns void.
        Action<string> printMessage = message => Console.WriteLine($"Action: {message}");
        printMessage("Delegates can point to methods and lambda expressions.");

        // Predicate<T> represents a method that checks a T value and returns bool.
        Predicate<int> isEven = number => number % 2 == 0;
        Console.WriteLine($"Is 12 even? {isEven(12)}");
    }

    private static int Add(int first, int second) => first + second;

    private static int Multiply(int first, int second) => first * second;
}
