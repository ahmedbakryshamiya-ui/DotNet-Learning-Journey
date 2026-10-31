namespace Basics.Examples;

/// <summary>
/// Switch selects a branch based on a value or matching pattern.
/// </summary>
public static class SwitchStatement
{
    public static void Run()
    {
        Console.Write("Enter a temperature: ");
        if (!double.TryParse(Console.ReadLine(), out double temperature))
        {
            Console.WriteLine("Invalid temperature.");
            return;
        }

        switch (temperature)
        {
            case < 20:
                Console.WriteLine("It's cold.");
                break;
            case >= 20 and < 30:
                Console.WriteLine("It's moderate.");
                break;
            default:
                Console.WriteLine("It's hot.");
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
