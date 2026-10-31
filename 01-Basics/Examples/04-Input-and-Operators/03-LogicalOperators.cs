namespace Basics.Examples;

/// <summary>
/// The Boolean operators &amp;&amp; and || use conditional evaluation: the right operand is evaluated only when needed. The ! operator negates a Boolean value.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators
/// </remarks>
public static class LogicalOperators
{
    public static void Run()
    {
        // Walkthrough: The Boolean operators && and || use conditional evaluation: the right operand is evaluated only when needed. The ! operator negates a Boolean value.
        Console.Write("Do you have a driver's license? (true/false): ");
        // && short-circuits: license is inspected only when TryParse succeeded.
        bool hasLicense = bool.TryParse(Console.ReadLine(), out bool license) && license;

        Console.Write("Do you know how to drive? (true/false): ");
        bool knowsHow = bool.TryParse(Console.ReadLine(), out bool driving) && driving;

        // Evaluate the condition; execute this block only when it is true.
        if (hasLicense && knowsHow)
            Console.WriteLine("You are qualified to drive.");
        else
            Console.WriteLine("You are not qualified to drive.");

        Console.WriteLine($"OR example: {hasLicense || knowsHow}");
        Console.WriteLine($"NOT example: {!hasLicense}");
    }
}
