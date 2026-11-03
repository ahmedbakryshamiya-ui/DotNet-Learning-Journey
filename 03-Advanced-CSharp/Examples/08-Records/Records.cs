namespace AdvancedCSharp.Examples;

/// <summary>
/// Records provide concise syntax for data-centric types and value-based equality.
/// A with expression creates a copy with selected properties changed.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/records
/// </remarks>
public static class Records
{
    public static void Run()
    {
        // Two record instances with the same property values compare as equal by value.
        PersonRecord first = new("Ahmed", 26);
        PersonRecord second = new("Ahmed", 26);

        Console.WriteLine($"Same values: {first == second}");

        // The with expression creates a new record and changes only the selected property.
        PersonRecord olderVersion = first with { Age = 27 };

        Console.WriteLine($"Original: {first.Name}, {first.Age}");
        Console.WriteLine($"Copy: {olderVersion.Name}, {olderVersion.Age}");
    }
}

/// <summary>
/// Immutable-by-default sample data record with init-only properties.
/// </summary>
public sealed record PersonRecord(string Name, int Age);
