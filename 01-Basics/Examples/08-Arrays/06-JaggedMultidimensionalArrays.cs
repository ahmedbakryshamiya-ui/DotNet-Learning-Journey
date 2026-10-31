namespace Basics.Examples;

/// <summary>
/// A jagged array can contain rectangular multidimensional arrays as its elements. The outer index selects an inner array, and the remaining indexes select an element inside that array.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays
/// </remarks>
public static class JaggedMultidimensionalArrays
{
    public static void Run()
    {
        // Walkthrough: A jagged array can contain rectangular multidimensional arrays as its elements. The outer index selects an inner array, and the remaining indexes select an element inside that array.
        // The outer array contains rectangular two-dimensional int arrays.
        int[][,] values =
        {
            new int[,] { { 1, 2 }, { 3, 4 } },
            new int[,] { { 5, 6 }, { 7, 8 } }
        };

        for (int arrayIndex = 0; arrayIndex < values.Length; arrayIndex++)
        {
            Console.WriteLine($"2D array {arrayIndex + 1}");

            for (int row = 0; row < values[arrayIndex].GetLength(0); row++)
            {
                for (int column = 0; column < values[arrayIndex].GetLength(1); column++)
                    Console.Write($"{values[arrayIndex][row, column]} ");

                Console.WriteLine();
            }
        }
    }
}
