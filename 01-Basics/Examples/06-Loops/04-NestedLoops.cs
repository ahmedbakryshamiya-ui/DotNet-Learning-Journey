namespace Basics.Examples;

/// <summary>
/// A nested loop is a loop placed inside another loop.
/// </summary>
public static class NestedLoops
{
    public static void Run()
    {
        for (int row = 1; row <= 12; row++)
        {
            for (int column = 1; column <= 12; column++)
                Console.WriteLine($"{row} × {column} = {row * column}");

            Console.WriteLine("----------------");
        }
    }
}
