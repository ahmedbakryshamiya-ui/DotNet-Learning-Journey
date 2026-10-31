namespace Basics.Examples;

/// <summary>
/// A value-type variable stores its value directly. Assigning it to another variable copies that value, so later changes to one variable do not change the other.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/
/// </remarks>
public static class ValueTypes
{
    public static void Run()
    {
        // Walkthrough: A value-type variable stores its value directly. Assigning it to another variable copies that value, so later changes to one variable do not change the other.
        int first = 10;
        // The numeric value is copied; second is independent from first.
        int second = first;
        second = 20;

        Console.WriteLine($"first = {first}");
        Console.WriteLine($"second = {second}");
        Console.WriteLine("Changing second does not change first.");
    }
}
