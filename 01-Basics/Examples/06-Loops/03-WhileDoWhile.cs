namespace Basics.Examples;

/// <summary>
/// A while loop tests its condition before each iteration. A do-while loop tests after the body, which guarantees at least one execution. break exits the nearest enclosing loop.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements
/// </remarks>
public static class WhileDoWhileExamples
{
    public static void Run()
    {
        // Walkthrough: A while loop tests its condition before each iteration. A do-while loop tests after the body, which guarantees at least one execution. break exits the nearest enclosing loop.
        int x = 8;

        // Test the condition before each pass, so the loop can run zero or more times.
        while (x >= -8)
        {
            // Evaluate this condition to choose whether the following branch runs.
            if (x <= 1)
            {
                Console.WriteLine("Breaking the loop...");
                // Exit the nearest enclosing loop or switch statement immediately.
                break;
            }

            Console.WriteLine($"Iteration = {x}");
            x--;
        }

        int i = 0;
        int multiplier = 2;

        // Execute the body first; the condition is tested after this block.
        do
        {
            Console.WriteLine($"{i} * {multiplier} = {i * multiplier}");
            i++;
        }
        // Check after each pass; another iteration runs only while the condition remains true.
        while (i <= 12);
    }
}
