namespace Basics.Examples;

/// <summary>
/// An array is a reference type whose elements all have the same type. Its length is fixed after the array instance is created, and its elements are accessed by zero-based indexes.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays
/// </remarks>
public static class ArraysExamples
{
    public static void Run()
    {
        // Walkthrough: An array is a reference type whose elements all have the same type. Its length is fixed after the array instance is created, and its elements are accessed by zero-based indexes.
        // The array stores five int elements and its length cannot be changed after creation.
        int[] numbers = { 1, 2, 3, 4, 5 };
        int[] mobileNumbers = new int[12];
        string[] names = { "Ali", "Bakry", "Sayed" };

        Console.WriteLine(names[0]);
        names[0] = "Ahmed";

        for (int i = 0; i < names.Length; i++)
            Console.WriteLine(names[i]);

        Console.WriteLine($"Numbers length: {numbers.Length}");
        Console.WriteLine($"Mobile numbers length: {mobileNumbers.Length}");
    }
}
