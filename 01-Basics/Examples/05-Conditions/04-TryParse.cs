namespace Basics.Examples;

/// <summary>
/// TryParse attempts to convert text into a value and reports success as a Boolean. On success, the parsed value is written to the out parameter; on failure, no format exception is thrown.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/system.int32.tryparse
/// </remarks>
public static class TryParseExamples
{
    public static void Run()
    {
        // Walkthrough: TryParse attempts to convert text into a value and reports success as a Boolean. On success, the parsed value is written to the out parameter; on failure, no format exception is thrown.
        Console.Write("Enter an integer: ");

        // Evaluate this condition to choose whether the following branch runs.
        // The out variable receives the converted integer when TryParse returns true.
        if (int.TryParse(Console.ReadLine(), out int number))
            Console.WriteLine($"You entered: {number}");
        else
            Console.WriteLine("Invalid input.");
    }
}
