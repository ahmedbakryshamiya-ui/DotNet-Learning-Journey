namespace AdvancedCSharp.Examples;

/// <summary>
/// Pattern matching tests whether a value has a requested shape or satisfies a condition.
/// Switch expressions and property, type, and relational patterns can make branching code clearer.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/functional/pattern-matching
/// </remarks>
public static class PatternMatching
{
    public static void Run()
    {
        object value = "Advanced C#";

        // A type pattern checks the runtime type and assigns the matched value to text.
        if (value is string text && text.Length > 5)
        {
            Console.WriteLine($"String value: {text}");
        }

        // Relational patterns compare a value with constant boundaries.
        int score = 86;
        string grade = score switch
        {
            >= 90 => "A",
            >= 80 => "B",
            >= 70 => "C",
            >= 60 => "D",
            _ => "F"
        };

        Console.WriteLine($"Grade: {grade}");

        // A property pattern checks both the object's type and one of its properties.
        object user = new UserProfile("Mona", true);
        string message = user switch
        {
            UserProfile { IsActive: true, Name: var name } => $"{name} is active.",
            UserProfile { IsActive: false } => "The user is inactive.",
            _ => "Unknown user."
        };

        Console.WriteLine(message);
    }
}

public sealed record UserProfile(string Name, bool IsActive);
