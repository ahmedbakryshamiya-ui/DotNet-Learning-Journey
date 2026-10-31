namespace Basics.Examples;

/// <summary>
/// A rectangular multidimensional array has a fixed number of dimensions and uses comma-separated indexes. GetLength(dimension) returns the size along a specified dimension.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays
/// </remarks>
public static class MultidimensionalArrays
{
    public static void Run()
    {
        // Walkthrough: A rectangular multidimensional array has a fixed number of dimensions and uses comma-separated indexes. GetLength(dimension) returns the size along a specified dimension.
        int[] oneDimensional = { 2, 3, 5, 6, 7 };

        // A rectangular 2D array is indexed with [row, column].
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

        // A 3D array adds a third index; all dimensions belong to one rectangular array.
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
