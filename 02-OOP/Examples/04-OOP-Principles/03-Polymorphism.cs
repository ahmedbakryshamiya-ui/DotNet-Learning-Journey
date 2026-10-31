namespace OOPLearning.Examples;

/// <summary>
/// Runtime polymorphism lets different derived objects respond to the same virtual method.
/// </summary>
public static class Polymorphism
{
    public static void Run()
    {
        BasicShape[] shapes =
        {
            new Circle(),
            new Triangle(),
            new Line(),
            new BasicShape()
        };

        foreach (BasicShape shape in shapes)
            shape.Draw();

        Console.WriteLine("Compile-time polymorphism is also demonstrated by method overloading.");
    }
}

public class BasicShape
{
    public virtual void Draw() => Console.WriteLine("A basic shape is drawn.");
}

public class Shape : BasicShape
{
}

public class Circle : Shape
{
    public override void Draw() => Console.WriteLine("A circle is drawn.");
}

public class Triangle : Shape
{
    public override void Draw() => Console.WriteLine("A triangle is drawn.");
}

public class Line : Shape
{
    public override void Draw() => Console.WriteLine("A line is drawn.");
}
