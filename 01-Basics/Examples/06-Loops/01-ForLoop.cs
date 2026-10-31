namespace Basics.Examples;

/// <summary>
/// A for loop has initialization, a condition, and an iteration step.
/// </summary>
public static class ForLoopExamples
{
    public static void Run()
    {
        Console.Write("Enter the last number: ");
        if (!int.TryParse(Console.ReadLine(), out int lastNumber) || lastNumber < 0)
        {
            Console.WriteLine("Enter a non-negative integer.");
            return;
        }

        for (int i = 0; i <= lastNumber; i++)
            Console.WriteLine($"{i} is {(i % 2 == 0 ? "even" : "odd")}");
    }
}
