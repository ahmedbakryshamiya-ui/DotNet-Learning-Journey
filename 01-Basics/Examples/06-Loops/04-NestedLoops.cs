namespace Basics.Examples;

/// <summary>
/// A nested loop is a loop inside another loop. For each outer iteration, the inner loop completes its own iterations before execution continues with the next outer iteration.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements
/// </remarks>
public static class NestedLoops
{
    public static void Run()
    {
        // Walkthrough: A nested loop is a loop inside another loop. For each outer iteration, the inner loop completes its own iterations before execution continues with the next outer iteration.
        // Repeat while the condition is true; the iterator advances the loop counter after each pass.
        for (int row = 1; row <= 12; row++)
        {
            // Repeat while the condition is true; the iterator advances the loop counter after each pass.
            for (int column = 1; column <= 12; column++)
                Console.WriteLine($"{row} × {column} = {row * column}");

            Console.WriteLine("----------------");
        }
    }
}
