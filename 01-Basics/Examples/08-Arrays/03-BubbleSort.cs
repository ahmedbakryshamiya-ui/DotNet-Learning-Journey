namespace Basics.Examples;

/// <summary>
/// Bubble sort repeatedly compares adjacent elements and swaps them when they are out of order. This simple implementation sorts in ascending order but has quadratic time complexity in the general case.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays
/// </remarks>
public static class BubbleSort
{
    public static void Run()
    {
        // Walkthrough: Bubble sort repeatedly compares adjacent elements and swaps them when they are out of order. This simple implementation sorts in ascending order but has quadratic time complexity in the general case.
        int[] numbers = { 9, 8, 6, 4, 2, 3, 5, 1, 7, 10, -2, 100 };

        Console.WriteLine("Before sorting:");
        Print(numbers);

        // Each pass moves the largest not-yet-positioned value to the end of the unsorted section.
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

        // Array.Sort is the standard library alternative for general-purpose sorting.
        int[] anotherArray = { 9, 7, 5, 3, 1, 2, 4, 6, 8, 0 };
        Array.Sort(anotherArray);
        Console.WriteLine("Using Array.Sort:");
        Print(anotherArray);
    }

    private static void Print(int[] values) => Console.WriteLine(string.Join(" ", values));
}
