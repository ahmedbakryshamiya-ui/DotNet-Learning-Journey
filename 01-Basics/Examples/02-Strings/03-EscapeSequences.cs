namespace Basics.Examples;

/// <summary>
/// Escape sequences are backslash-prefixed character combinations used inside string and character literals. They represent characters such as quotes, tabs, carriage returns, line feeds, and backslashes; they are interpreted by the compiler when the literal is created.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/
/// </remarks>
public static class EscapeSequences
{
    public static void Run()
    {
        // Walkthrough: each escape sequence represents a character that is not typed as ordinary visible text.
        Console.WriteLine("\"Ahmed\"");       // Double quotation marks
        Console.WriteLine("C:\\Users\\Ahmed"); // Backslashes
        Console.WriteLine("\a");               // Alert/bell character
        Console.WriteLine("Ahmed\tis an Engineer"); // Tab
        Console.WriteLine("First line\nSecond line"); // New line
    }
}
