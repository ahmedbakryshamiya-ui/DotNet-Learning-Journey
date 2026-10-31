namespace Basics.Examples;

/// <summary>
/// Nested loops can build text patterns by printing leading spaces and stars for each row. The row number controls the width of each line in the pyramid examples.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements
/// </remarks>
public static class TrianglePatterns
{
    public static void Run()
    {
        // Walkthrough: Nested loops can build text patterns by printing leading spaces and stars for each row. The row number controls the width of each line in the pyramid examples.
        // A small fixed height keeps the printed output readable in the console.
        const int height = 6;

        Console.WriteLine("Pyramid:");
        // Repeat while the condition is true; the iterator advances the loop counter after each pass.
        for (int row = 1; row <= height; row++)
        {
            Console.Write(new string(' ', height - row));
            Console.WriteLine(new string('*', (2 * row) - 1));
        }

        Console.WriteLine("\nInverted pyramid:");
        // Repeat while the condition is true; the iterator advances the loop counter after each pass.
        for (int row = height; row >= 1; row--)
        {
            Console.Write(new string(' ', height - row));
            Console.WriteLine(new string('*', (2 * row) - 1));
        }

        Console.WriteLine("\nHollow pyramid:");
        // Repeat while the condition is true; the iterator advances the loop counter after each pass.
        for (int row = 1; row <= height; row++)
        {
            Console.Write(new string(' ', height - row));

            // Evaluate this condition to choose whether the following branch runs.
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
