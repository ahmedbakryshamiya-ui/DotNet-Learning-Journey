namespace Basics.Examples;

/// <summary>
/// Bubble Sort compares neighboring items and swaps them when they are out of order.
/// </summary>
public static class BubbleSort
{
    public static void Run()
    {
        int[] numbers = { 9, 8, 6, 4, 2, 3, 5, 1, 7, 10, -2, 100 };

        Console.WriteLine("Before sorting:");
        Print(numbers);

        for (int pass = 0; pass < numbers.Length - 1; pass++)
        {
            for (int i = 0; i < numbers.Length - 1 - pass; i++)
            {
                if (numbers[i] > numbers[i + 1])
                    (numbers[i], numbers[i + 1]) = (numbers[i + 1], numbers[i]);
            }
        }

        Console.WriteLine("After Bubble Sort:");
        Print(numbers);

        int[] anotherArray = { 9, 7, 5, 3, 1, 2, 4, 6, 8, 0 };
        Array.Sort(anotherArray);
        Console.WriteLine("Using Array.Sort:");
        Print(anotherArray);
    }

    private static void Print(int[] values) => Console.WriteLine(string.Join(" ", values));
}
