namespace Basics.Examples;

/// <summary>
/// Escape sequences represent characters such as quotes, tabs, and new lines.
/// </summary>
public static class EscapeSequences
{
    public static void Run()
    {
        Console.WriteLine("\"Ahmed\"");       // Double quotation marks
        Console.WriteLine("C:\\Users\\Ahmed"); // Backslashes
        Console.WriteLine("\a");               // Alert/bell character
        Console.WriteLine("Ahmed\tis an Engineer"); // Tab
        Console.WriteLine("First line\nSecond line"); // New line
    }
}
