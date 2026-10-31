namespace Basics.Examples;

/// <summary>
/// Logical operators combine Boolean expressions: AND, OR, and NOT.
/// </summary>
public static class LogicalOperators
{
    public static void Run()
    {
        Console.Write("Do you have a driver's license? (true/false): ");
        bool hasLicense = bool.TryParse(Console.ReadLine(), out bool license) && license;

        Console.Write("Do you know how to drive? (true/false): ");
        bool knowsHow = bool.TryParse(Console.ReadLine(), out bool driving) && driving;

        if (hasLicense && knowsHow)
            Console.WriteLine("You are qualified to drive.");
        else
            Console.WriteLine("You are not qualified to drive.");

        Console.WriteLine($"OR example: {hasLicense || knowsHow}");
        Console.WriteLine($"NOT example: {!hasLicense}");
    }
}
