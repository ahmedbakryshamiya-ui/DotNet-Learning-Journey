namespace OOPLearning.Examples;

/// <summary>
/// A method's return type tells the caller what value, if any, it returns.
/// </summary>
public static class ReturnTypes
{
    public static void Run()
    {
        PrintWelcome(); // void means the method does not return a value.

        int total = AddNumbers(5, 7);
        Console.WriteLine($"Returned value: {total}");
    }

    private static void PrintWelcome()
    {
        Console.WriteLine("Welcome to C# methods.");
    }

    private static int AddNumbers(int first, int second)
    {
        return first + second;
    }
}
