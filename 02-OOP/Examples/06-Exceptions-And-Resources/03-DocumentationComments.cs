namespace OOPLearning.Examples;

/// <summary>
/// XML documentation comments describe types and members for IDE help and generated documentation.
/// </summary>
public static class DocumentationComments
{
    public static void Run()
    {
        Point point = new(1, 2, 3);
        Point moved = point.Translate(2, 3, 4);

        Console.WriteLine($"Moved point: ({moved.X}, {moved.Y}, {moved.Z})");
    }
}

/// <summary>
/// Represents a point in three-dimensional space.
/// </summary>
public class Point
{
    public Point(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public int X { get; }
    public int Y { get; }
    public int Z { get; }

    /// <summary>
    /// Returns a new point translated by the supplied offsets.
    /// </summary>
    /// <param name="x">Horizontal offset.</param>
    /// <param name="y">Vertical offset.</param>
    /// <param name="z">Depth offset.</param>
    /// <returns>The translated point.</returns>
    public Point Translate(int x, int y, int z)
    {
        return new Point(X + x, Y + y, Z + z);
    }
}
