namespace OOPLearning.Examples;

/// <summary>
/// An abstract class cannot be instantiated directly and may require derived classes to implement members.
/// </summary>
public static class AbstractClasses
{
    public static void Run()
    {
        ShapeBase line = new LineShape();
        line.SayHello();
        line.Draw();
    }
}

public abstract class ShapeBase
{
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
