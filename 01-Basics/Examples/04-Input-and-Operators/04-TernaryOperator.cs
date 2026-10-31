namespace Basics.Examples;

/// <summary>
/// The ternary operator is a compact if/else expression with three parts.
/// </summary>
public static class TernaryOperator
{
    public static void Run()
    {
        int x = 10;
        int y = 20;

        string comparison = x > y ? "x is greater than y" : "x is not greater than y";
        string evenOrOdd = x % 2 == 0 ? "even" : "odd";

        Console.WriteLine(comparison);
        Console.WriteLine($"{x} is {evenOrOdd}");
    }
}
