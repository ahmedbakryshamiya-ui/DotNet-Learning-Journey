namespace Basics.Examples;

/// <summary>
/// A const field or local is a compile-time constant: it must be initialized with a constant expression and cannot be assigned a different value later.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/
/// </remarks>
public static class Constants
{
    public static void Run()
    {
        // Walkthrough: A const field or local is a compile-time constant: it must be initialized with a constant expression and cannot be assigned a different value later.
        // A const value must be known at compile time, not calculated from runtime input.
        const int daysInWeek = 7;
        const double pi = 3.14159;

        Console.WriteLine($"Days in a week: {daysInWeek}");
        Console.WriteLine($"Pi: {pi}");
        // daysInWeek = 8; // Uncommenting this line causes a compile-time error.
    }
}
