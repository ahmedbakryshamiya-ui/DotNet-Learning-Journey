namespace OOPLearning.Examples;

/// <summary>
/// XML documentation comments use triple-slash syntax and XML tags such as summary, param, and returns. The compiler can write these comments to an XML documentation file when documentation-file generation is enabled, and IDEs use them for help and IntelliSense.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/
/// </remarks>
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
    // XML documentation above this member is shown by IDEs and can be emitted to an XML file.
    public void Translate(int x, int y, int z)
    {
        X += x;
        Y += y;
        Z += z;
    }
}
