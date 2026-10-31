namespace OOPLearning.Examples;

/// <summary>
/// Method overloading uses one method name with different parameter lists.
/// </summary>
public static class MethodOverloading
{
    public static void Run()
    {
        Console.Write("Enter your name (or press Enter): ");
        string guestName = Console.ReadLine() ?? string.Empty;

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
