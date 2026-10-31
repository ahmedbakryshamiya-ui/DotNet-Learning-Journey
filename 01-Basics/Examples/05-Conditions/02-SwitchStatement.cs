namespace Basics.Examples;

/// <summary>
/// A switch statement or expression selects an outcome by matching an input against constant values or patterns. Relational patterns can express numeric ranges, and the discard pattern (_) acts as the fallback.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements
/// </remarks>
public static class SwitchStatement
{
    public static void Run()
    {
        // Walkthrough: A switch statement or expression selects an outcome by matching an input against constant values or patterns. Relational patterns can express numeric ranges, and the discard pattern (_) acts as the fallback.
        Console.Write("Enter a temperature: ");
        // Evaluate this condition to choose whether the following branch runs.
        if (!double.TryParse(Console.ReadLine(), out double temperature))
        {
            Console.WriteLine("Invalid temperature.");
            return;
        }

        // Match the input against the case labels or patterns and run the selected section.
        switch (temperature)
        {
            // Relational patterns compare temperature with the numeric boundary.
            case < 20:
                Console.WriteLine("It's cold.");
                // Exit the nearest enclosing loop or switch statement immediately.
                break;
            case >= 20 and < 30:
                Console.WriteLine("It's moderate.");
                // Exit the nearest enclosing loop or switch statement immediately.
                break;
            default:
                Console.WriteLine("It's hot.");
                // Exit the nearest enclosing loop or switch statement immediately.
                break;
        }

        string description = temperature switch
        {
            < 20 => "It's cold.",
            >= 20 and < 30 => "It's moderate.",
            _ => "It's hot."
        };

        Console.WriteLine($"Switch expression: {description}");
    }
}
