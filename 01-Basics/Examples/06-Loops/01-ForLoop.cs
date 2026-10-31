namespace Basics.Examples;

/// <summary>
/// A for statement evaluates its initializer once, checks its condition before each iteration, executes the body, and then evaluates its iterator. It is useful when iteration is controlled by a counter.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements
/// </remarks>
public static class ForLoopExamples
{
    public static void Run()
    {
        // Walkthrough: A for statement evaluates its initializer once, checks its condition before each iteration, executes the body, and then evaluates its iterator. It is useful when iteration is controlled by a counter.
        Console.Write("Enter the last number: ");
        // Evaluate this condition to choose whether the following branch runs.
        if (!int.TryParse(Console.ReadLine(), out int lastNumber) || lastNumber < 0)
        {
            Console.WriteLine("Enter a non-negative integer.");
            return;
        }

        // Repeat while the condition is true; the iterator advances the loop counter after each pass.
        for (int i = 0; i <= lastNumber; i++)
            Console.WriteLine($"{i} is {(i % 2 == 0 ? "even" : "odd")}");
    }
}
