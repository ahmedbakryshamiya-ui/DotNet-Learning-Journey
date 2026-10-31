namespace Basics.Examples;

/// <summary>
/// An if statement runs code only when its condition is true.
/// </summary>
public static class IfStatement
{
    public static void Run()
    {
        int x = 13;
        int y = 13;

        if (x > y)
            Console.WriteLine("x is greater than y");
        else if (x < y)
            Console.WriteLine("x is less than y");
        else
            Console.WriteLine("x is equal to y");
    }
}
