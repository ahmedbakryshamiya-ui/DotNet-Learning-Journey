namespace Basics.Examples;

/// <summary>
/// A jagged array is an array whose elements are themselves arrays. Each inner array can have a different length, and each dimension is indexed separately.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays
/// </remarks>
public static class JaggedArrays
{
    public static void Run()
    {
        // Walkthrough: A jagged array is an array whose elements are themselves arrays. Each inner array can have a different length, and each dimension is indexed separately.
        // Each outer element is its own int[]; inner arrays may have different lengths.
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
