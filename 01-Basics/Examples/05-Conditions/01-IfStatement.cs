namespace Basics.Examples;

/// <summary>
/// An if statement evaluates a Boolean condition and executes the associated statement only when the condition is true. else if and else provide alternative branches.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements
/// </remarks>
public static class IfStatement
{
    public static void Run()
    {
        // Walkthrough: An if statement evaluates a Boolean condition and executes the associated statement only when the condition is true. else if and else provide alternative branches.
        int x = 13;
        int y = 13;

        // Evaluate the condition; execute this block only when it is true.
        if (x > y)
            Console.WriteLine("x is greater than y");
        else if (x < y)
            Console.WriteLine("x is less than y");
        else
            Console.WriteLine("x is equal to y");
    }
}
