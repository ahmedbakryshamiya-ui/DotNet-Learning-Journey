namespace Basics.Examples;

/// <summary>
/// DateTime represents a point in time with date and clock-time components. DateTime.Now uses the computer's local clock; format specifiers such as MM (month) and mm (minute) have distinct meanings.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/system.datetime
/// </remarks>
public static class DateTimeExamples
{
    public static void Run()
    {
        // Walkthrough: DateTime represents a point in time with date and clock-time components. DateTime.Now uses the computer's local clock; format specifiers such as MM (month) and mm (minute) have distinct meanings.
        // Now reads the local system clock; use UtcNow when UTC is required.
        DateTime current = DateTime.Now;
        DateTime fixedDate = new(2026, 3, 25);

        Console.WriteLine($"Now: {current}");
        Console.WriteLine($"Fixed date: {fixedDate}");

        // Use MM for month and mm for minutes.
        Console.WriteLine(current.ToString("dd/MMMM/yyyy dddd HH:mm:ss tt"));
    }
}
