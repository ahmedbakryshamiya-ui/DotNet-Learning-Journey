namespace Basics.Examples;

/// <summary>
/// A constant is assigned once and cannot be changed later.
/// </summary>
public static class Constants
{
    public static void Run()
    {
        const int daysInWeek = 7;
        const double pi = 3.14159;

        Console.WriteLine($"Days in a week: {daysInWeek}");
        Console.WriteLine($"Pi: {pi}");
        // daysInWeek = 8; // Uncommenting this line causes a compile-time error.
    }
}
