namespace Basics.Examples;

/// <summary>
/// Nested loops can print solid, inverted, and hollow triangle patterns.
/// </summary>
public static class TrianglePatterns
{
    public static void Run()
    {
        const int height = 6;

        Console.WriteLine("Pyramid:");
        for (int row = 1; row <= height; row++)
        {
            Console.Write(new string(' ', height - row));
            Console.WriteLine(new string('*', (2 * row) - 1));
        }

        Console.WriteLine("\nInverted pyramid:");
        for (int row = height; row >= 1; row--)
        {
            Console.Write(new string(' ', height - row));
            Console.WriteLine(new string('*', (2 * row) - 1));
        }

        Console.WriteLine("\nHollow pyramid:");
        for (int row = 1; row <= height; row++)
        {
            Console.Write(new string(' ', height - row));

            if (row == 1)
                Console.WriteLine("*");
            else if (row == height)
                Console.WriteLine(new string('*', (2 * height) - 1));
            else
            {
                Console.Write("*");
                Console.Write(new string(' ', (2 * row) - 3));
                Console.WriteLine("*");
            }
        }
    }
}
