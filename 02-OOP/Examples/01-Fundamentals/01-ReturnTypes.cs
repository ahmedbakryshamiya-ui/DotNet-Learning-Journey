namespace OOPLearning.Examples;

/// <summary>
/// A method's return type declares the kind of result it gives to its caller. void means the method does not return a value; a non-void method must return a value compatible with its declared type on every normal path.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/methods
/// </remarks>
public static class ReturnTypes
{
    public static void Run()
    {
        // Walkthrough: A method's return type declares the kind of result it gives to its caller. void means the method does not return a value; a non-void method must return a value compatible with its declared type on every normal path.
        // A void method performs its work but does not produce a value for this call site.
        PrintWelcome(); // void means the method does not return a value.

        // This method returns an int, which can be stored and used by the caller.
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
