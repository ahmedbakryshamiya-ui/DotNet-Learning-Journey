namespace Basics.Examples;

/// <summary>
/// Traversing an array means visiting its elements. foreach reads each element in sequence; this example counts only the recognized m and f values.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements
/// </remarks>
public static class TraversingOneDimensionalArray
{
    public static void Run()
    {
        // Walkthrough: Traversing an array means visiting its elements. foreach reads each element in sequence; this example counts only the recognized m and f values.
        char[] genders = { 'f', 'f', 'f', 'm', 'm', 'm', 'm', 'm' };
        int males = 0;
        int females = 0;

        // Process each character and update the appropriate counter only for recognized values.
        foreach (char gender in genders)
        {
            if (gender == 'm')
                males++;
            else if (gender == 'f')
                females++;
        }

        Console.WriteLine($"Number of males: {males}");
        Console.WriteLine($"Number of females: {females}");
    }
}
