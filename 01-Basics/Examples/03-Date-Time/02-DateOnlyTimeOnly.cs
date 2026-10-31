namespace Basics.Examples;

/// <summary>
/// DateOnly represents a calendar date without a time zone or time-of-day component. TimeOnly represents a clock time without a date. Subtracting two TimeOnly values produces a TimeSpan.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/standard/datetime/how-to-use-dateonly-timeonly
/// </remarks>
public static class DateOnlyTimeOnly
{
    public static void Run()
    {
        // Walkthrough: DateOnly represents a calendar date without a time zone or time-of-day component. TimeOnly represents a clock time without a date. Subtracting two TimeOnly values produces a TimeSpan.
        DateOnly date = new(2026, 3, 25);
        Console.WriteLine(date);
        Console.WriteLine(date.DayOfWeek);
        Console.WriteLine(date.DayOfYear);
        Console.WriteLine(date.AddMonths(1).AddYears(10));

        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
        Console.WriteLine($"Today: {today}");

        TimeOnly eventIn = new(8, 0, 0);
        TimeOnly eventOut = new(16, 0, 0);
        // TimeOnly subtraction returns a TimeSpan representing the elapsed clock-time difference.
        TimeSpan duration = eventOut - eventIn;

        Console.WriteLine($"Start: {eventIn}");
        Console.WriteLine($"End: {eventOut}");
        Console.WriteLine($"Hours: {duration.TotalHours}");
        Console.WriteLine($"Minutes: {duration.TotalMinutes}");
    }
}
