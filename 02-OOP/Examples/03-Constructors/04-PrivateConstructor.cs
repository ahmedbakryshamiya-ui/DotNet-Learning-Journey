namespace OOPLearning.Examples;

/// <summary>
/// A private constructor prevents code outside the type from creating instances directly.
/// </summary>
public static class PrivateConstructor
{
    public static void Run()
    {
        Counter.SetCount(70);
        Console.WriteLine($"Current count: {Counter.IncrementCount()}");
    }
}

public class Counter
{
    private static int _currentCount;

    private Counter()
    {
    }

    public static void SetCount(int value) => _currentCount = value;

    public static int IncrementCount() => ++_currentCount;
}
