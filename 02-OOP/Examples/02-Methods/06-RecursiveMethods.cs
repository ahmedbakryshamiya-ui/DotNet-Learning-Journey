namespace OOPLearning.Examples;

/// <summary>
/// A recursive method calls itself to solve a smaller version of the same problem. A base case must stop recursion; without one, calls continue until a failure such as stack exhaustion. This factorial sample is intended for non-negative integers and int-sized results.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return
/// </remarks>
public static class RecursiveMethods
{
    public static void Run()
    {
        // Walkthrough: A recursive method calls itself to solve a smaller version of the same problem. A base case must stop recursion; without one, calls continue until a failure such as stack exhaustion. This factorial sample is intended for non-negative integers and int-sized results.
        const int number = 5;

        Console.WriteLine($"Iterative factorial: {FactorialIterative(number)}");
        Console.WriteLine($"Recursive factorial: {FactorialRecursive(number)}");
    }

    private static int FactorialIterative(int number)
    {
        int result = 1;

        for (int i = 2; i <= number; i++)
            result *= i;

        return result;
    }

    private static int FactorialRecursive(int number)
    {
        // Base case: factorial of 0 or 1 is 1, so recursion stops here.
        if (number <= 1)
            return 1;

        // Recursive case: reduce the problem by one and multiply the returned result.
        return number * FactorialRecursive(number - 1);
    }
}
