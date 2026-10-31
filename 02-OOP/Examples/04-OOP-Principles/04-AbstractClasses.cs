namespace OOPLearning.Examples;

/// <summary>
/// An abstract class cannot be instantiated directly. It can provide implemented members and declare abstract members that non-abstract derived classes must implement with override.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract
/// </remarks>
public static class AbstractClasses
{
    public static void Run()
    {
        // Walkthrough: An abstract class cannot be instantiated directly. It can provide implemented members and declare abstract members that non-abstract derived classes must implement with override.
        ShapeBase line = new LineShape();
        line.SayHello();
        line.Draw();
    }
}

// ShapeBase defines a shared contract and behavior; it cannot be instantiated directly.
public abstract class ShapeBase
{
    // Each concrete derived shape must provide its own Draw implementation.
    public abstract void Draw();

    public void SayHello()
    {
        Console.WriteLine("Hello from the abstract base class.");
    }
}

public class LineShape : ShapeBase
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a line.");
    }
}
