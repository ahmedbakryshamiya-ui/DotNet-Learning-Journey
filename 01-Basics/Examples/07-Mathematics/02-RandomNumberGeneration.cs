namespace Basics.Examples;

/// <summary>
/// Random produces pseudo-random values. Random.Next(min, max) includes min and excludes max, while NextDouble returns a value greater than or equal to zero and less than one.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/system.random
/// </remarks>
public static class RandomNumberGeneration
{
    public static void Run()
    {
        // Walkthrough: Random produces pseudo-random values. Random.Next(min, max) includes min and excludes max, while NextDouble returns a value greater than or equal to zero and less than one.
        Random random = new();

        // The maximum value passed to Next is exclusive.
        // The upper bound is exclusive, so this call can return 1 through 100.
        int randomNumber = random.Next(1, 101);
        // NextDouble returns a value in [0, 1); scaling it gives a value in [0, 100).
        double randomDouble = random.NextDouble() * 100;

        Console.WriteLine($"Random integer (1-100): {randomNumber}");
        Console.WriteLine($"Random double (0-100): {randomDouble:F2}");
    }
}
