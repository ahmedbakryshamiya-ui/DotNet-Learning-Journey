namespace Basics.Examples;

/// <summary>
/// TryParse attempts a conversion and reports success without throwing a format exception.
/// </summary>
public static class TryParseExamples
{
    public static void Run()
    {
        Console.Write("Enter an integer: ");

        if (int.TryParse(Console.ReadLine(), out int number))
            Console.WriteLine($"You entered: {number}");
        else
            Console.WriteLine("Invalid input.");
    }
}
