namespace OOPLearning.Examples;

/// <summary>
/// Polymorphism means one base type can represent objects with different implementations.
/// </summary>
public static class Polymorphism
{
    public static void Run()
    {
        Shape[] shapes =
        {
            new Circle(),
            new Triangle(),
            new Line(),
            new Shape()
        };

        foreach (Shape shape in shapes)
            shape.Draw();

        Console.WriteLine("Compile-time polymorphism: method overloading.");
        WelcomeGuest();
        WelcomeGuest("Ahmed");
    }

    private static void WelcomeGuest()
    {
        Console.WriteLine("How can I help you?");
    }

    private static void WelcomeGuest(string name)
    {
        Console.WriteLine($"Good day {name}, how can I help you?");
    }
}

public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("A basic shape is created.");
    }
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("A circle is created.");
    }
}

public class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("A triangle is created.");
    }
}

public class Line : Shape
{
    public override void Draw()
    {
        Console.WriteLine("A line is created.");
    }
}
