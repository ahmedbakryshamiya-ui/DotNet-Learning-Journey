namespace Basics.Examples;

/// <summary>
/// The conditional operator (?:) evaluates a Boolean condition and produces the value of one of two expressions. It is an expression, so its result can be assigned or passed to a method.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator
/// </remarks>
public static class TernaryOperator
{
    public static void Run()
    {
        // Walkthrough: The conditional operator (?:) evaluates a Boolean condition and produces the value of one of two expressions. It is an expression, so its result can be assigned or passed to a method.
        int x = 10;
        int y = 20;

        // The condition before ? selects the expression before : or the expression after it.
        string comparison = x > y ? "x is greater than y" : "x is not greater than y";
        string evenOrOdd = x % 2 == 0 ? "even" : "odd";

        Console.WriteLine(comparison);
        Console.WriteLine($"{x} is {evenOrOdd}");
    }
}
