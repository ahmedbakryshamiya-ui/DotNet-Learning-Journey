namespace Basics.Examples;

/// <summary>
/// A jagged array can also contain multidimensional arrays.
/// </summary>
public static class JaggedMultidimensionalArrays
{
    public static void Run()
    {
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
