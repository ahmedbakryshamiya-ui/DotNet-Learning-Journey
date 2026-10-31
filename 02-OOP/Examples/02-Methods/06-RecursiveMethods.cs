namespace OOPLearning.Examples;

/// <summary>
/// A recursive method calls itself and needs a base case to stop.
/// </summary>
public static class RecursiveMethods
{
    public static void Run()
    {
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
        if (number <= 1)
            return 1;

        return number * FactorialRecursive(number - 1);
    }
}
