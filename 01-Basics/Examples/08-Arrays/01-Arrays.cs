namespace Basics.Examples;

/// <summary>
/// An array stores a fixed-size collection of items of the same type.
/// </summary>
public static class ArraysExamples
{
    public static void Run()
    {
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
