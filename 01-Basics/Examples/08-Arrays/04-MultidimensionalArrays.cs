namespace Basics.Examples;

/// <summary>
/// Multidimensional arrays use more than one index, such as row and column.
/// </summary>
public static class MultidimensionalArrays
{
    public static void Run()
    {
        int[] oneDimensional = { 2, 3, 5, 6, 7 };

        int[,] matrix =
        {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        Console.WriteLine($"1D first item: {oneDimensional[0]}");
        Console.WriteLine($"2D [0,2]: {matrix[0, 2]}");
        Console.WriteLine($"Rows: {matrix.GetLength(0)}");
        Console.WriteLine($"Columns: {matrix.GetLength(1)}");

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
                Console.Write($"{matrix[row, column]} ");

            Console.WriteLine();
        }

        int[,,] matrix3D =
        {
            { { 1, 2, 3 }, { 4, 5, 6 } },
            { { 7, 8, 9 }, { 10, 11, 12 } }
        };

        Console.WriteLine($"3D [0,0,1]: {matrix3D[0, 0, 1]}");
        Console.WriteLine($"3D [1,1,0]: {matrix3D[1, 1, 0]}");

        for (int depth = 0; depth < matrix3D.GetLength(0); depth++)
        for (int row = 0; row < matrix3D.GetLength(1); row++)
        for (int column = 0; column < matrix3D.GetLength(2); column++)
            Console.WriteLine($"[{depth},{row},{column}]: {matrix3D[depth, row, column]}");
    }
}
