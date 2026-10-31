namespace Basics.Examples;

/// <summary>
/// A jagged array is an array whose elements are arrays; inner arrays may differ in length.
/// </summary>
public static class JaggedArrays
{
    public static void Run()
    {
        int[][] values =
        {
            new[] { 34, 78 },
            new[] { 67, 34, 78, 46, 87 },
            new[] { 67, 34, 78, 23 }
        };

        Console.WriteLine($"Value at [2][3]: {values[2][3]}");

        for (int i = 0; i < values.Length; i++)
        {
            Console.WriteLine($"Array {i + 1}");
            for (int j = 0; j < values[i].Length; j++)
                Console.Write($"{values[i][j]}, ");

            Console.WriteLine();
        }
    }
}
