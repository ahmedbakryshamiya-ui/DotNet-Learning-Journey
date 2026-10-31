namespace Basics.Examples;

/// <summary>
/// DateTime represents a date and a time together.
/// </summary>
public static class DateTimeExamples
{
    public static void Run()
    {
        DateTime current = DateTime.Now;
        DateTime fixedDate = new(2026, 3, 25);

        Console.WriteLine($"Now: {current}");
        Console.WriteLine($"Fixed date: {fixedDate}");

        // Use MM for month and mm for minutes.
        Console.WriteLine(current.ToString("dd/MMMM/yyyy dddd HH:mm:ss tt"));
    }
}
