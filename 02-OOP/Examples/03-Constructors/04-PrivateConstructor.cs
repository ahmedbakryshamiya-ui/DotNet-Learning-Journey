namespace OOPLearning.Examples;

/// <summary>
/// A private constructor prevents code outside the containing type from constructing instances directly. It is commonly used when a type exposes only static members or controls object creation through its own methods.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/private-constructors
/// </remarks>
public static class PrivateConstructor
{
    public static void Run()
    {
        // Walkthrough: A private constructor prevents code outside the containing type from constructing instances directly. It is commonly used when a type exposes only static members or controls object creation through its own methods.
        Counter.SetCount(70);
        Console.WriteLine($"Current count: {Counter.IncrementCount()}");
    }
}

public class Counter
{
    private static int _currentCount;

    // Private accessibility prevents callers outside Counter from using new Counter().
    private Counter()
    {
    }

    public static void SetCount(int value) => _currentCount = value;

    public static int IncrementCount() => ++_currentCount;
}
