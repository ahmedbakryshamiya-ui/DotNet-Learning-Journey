namespace Basics.Examples;

/// <summary>
/// while checks before running; do-while always runs once before checking.
/// </summary>
public static class WhileDoWhileExamples
{
    public static void Run()
    {
        int x = 8;

        while (x >= -8)
        {
            if (x <= 1)
            {
                Console.WriteLine("Breaking the loop...");
                break;
            }

            Console.WriteLine($"Iteration = {x}");
            x--;
        }

        int i = 0;
        int multiplier = 2;

        do
        {
            Console.WriteLine($"{i} * {multiplier} = {i * multiplier}");
            i++;
        }
        while (i <= 12);
    }
}
