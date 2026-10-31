namespace OOPLearning.Examples;

/// <summary>
/// Method overloading allows multiple methods in one type to share a name when their parameter lists differ. The compiler selects an overload based on the arguments and overload-resolution rules; a different return type alone is not enough to overload a method.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/methods
/// </remarks>
public static class MethodOverloading
{
    public static void Run()
    {
        // Walkthrough: Method overloading allows multiple methods in one type to share a name when their parameter lists differ. The compiler selects an overload based on the arguments and overload-resolution rules; a different return type alone is not enough to overload a method.
        Console.Write("Enter your name (or press Enter): ");
        string guestName = Console.ReadLine() ?? string.Empty;

        // The argument list determines which WelcomeGuest overload the compiler calls.
        if (string.IsNullOrWhiteSpace(guestName))
            WelcomeGuest();
        else
            WelcomeGuest(guestName);
    }

    private static void WelcomeGuest()
    {
        Console.WriteLine("How can I help you?");
    }

    private static void WelcomeGuest(string name)
    {
        Console.WriteLine($"Good day, {name}. How can I help you?");
    }
}
