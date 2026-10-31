namespace OOPLearning.Examples;

/// <summary>
/// XML documentation comments describe types and members for IDE help and generated documentation.
/// </summary>
public static class DocumentationComments
{
    public static void Run()
    {
        Point point = new(1, 2, 3);
        point.Translate(2, 3, 4);

        Console.WriteLine($"Moved point: ({point.X}, {point.Y}, {point.Z})");
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

    public int X { get; private set; }
    public int Y { get; private set; }
    public int Z { get; private set; }

    /// <summary>
    /// Moves the current point by the supplied x, y, and z offsets.
    /// </summary>
    /// <param name="x">Horizontal offset.</param>
    /// <param name="y">Vertical offset.</param>
    /// <param name="z">Depth offset.</param>
    public void Translate(int x, int y, int z)
    {
        X += x;
        Y += y;
        Z += z;
    }
}
