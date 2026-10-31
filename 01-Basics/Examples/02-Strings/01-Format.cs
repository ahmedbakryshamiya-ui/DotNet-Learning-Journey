using System.Text;

namespace Basics.Examples;

/// <summary>
/// String formatting controls how values appear in text.
/// </summary>
public static class FormatExamples
{
    public static void Run()
    {
        string message = string.Format("Hello, {0}!", "World");
        Console.WriteLine(message);

        // StringBuilder is useful when text is built through several operations.
        StringBuilder name = new();
        name.Append("Ahmed");
        name.Append(" Bakry");
        Console.WriteLine(name);
        Console.WriteLine($"Length: {name.Length}");
        Console.WriteLine(name.Replace("Bakry", "Sayed"));

        Console.WriteLine($"Currency: {90:C}");
        Console.WriteLine($"Number: {90:N}");
        Console.WriteLine($"Percentage: {0.90:P}");
        Console.WriteLine($"Five digits: {90:D5}");
        Console.WriteLine($"Hexadecimal: {19287983:X}");
    }
}
