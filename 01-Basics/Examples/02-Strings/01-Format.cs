// The resource is disposed automatically when this using declaration or block leaves scope.
using System.Text;

namespace Basics.Examples;

/// <summary>
/// Composite formatting and interpolation insert formatted values into text. StringBuilder is mutable and is useful when building a string through a sequence of changes.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/strings/interpolation
/// </remarks>
public static class FormatExamples
{
    public static void Run()
    {
        // Walkthrough: Composite formatting and interpolation insert formatted values into text. StringBuilder is mutable and is useful when building a string through a sequence of changes.
        string message = string.Format("Hello, {0}!", "World");
        Console.WriteLine(message);

        // StringBuilder is useful when text is built through several operations.
        StringBuilder name = new();
        name.Append("Ahmed");
        name.Append(" Bakry");
        Console.WriteLine(name);
        Console.WriteLine($"Length: {name.Length}");
        Console.WriteLine(name.Replace("Bakry", "Sayed"));

        // Format specifiers control presentation; symbols and separators depend on the current culture.
        Console.WriteLine($"Currency: {90:C}");
        Console.WriteLine($"Number: {90:N}");
        Console.WriteLine($"Percentage: {0.90:P}");
        Console.WriteLine($"Five digits: {90:D5}");
        Console.WriteLine($"Hexadecimal: {19287983:X}");
    }
}
