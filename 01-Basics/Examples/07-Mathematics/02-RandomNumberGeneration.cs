namespace Basics.Examples;

/// <summary>
/// Random generates pseudo-random numbers in a chosen range.
/// </summary>
public static class RandomNumberGeneration
{
    public static void Run()
    {
        Random random = new();

        // The maximum value passed to Next is exclusive.
        int randomNumber = random.Next(1, 101);
        double randomDouble = random.NextDouble() * 100;

        Console.WriteLine($"Random integer (1-100): {randomNumber}");
        Console.WriteLine($"Random double (0-100): {randomDouble:F2}");
    }
}
