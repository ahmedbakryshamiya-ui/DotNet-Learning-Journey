namespace OOPLearning.Examples;

/// <summary>
/// Polymorphism allows a base-class reference to refer to a derived-class object and lets overridden virtual members dispatch according to the object's runtime type. Method overloading is a separate compile-time feature selected from the available parameter lists.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/polymorphism
/// </remarks>
public static class Polymorphism
{
    public static void Run()
    {
        // Walkthrough: Polymorphism allows a base-class reference to refer to a derived-class object and lets overridden virtual members dispatch according to the object's runtime type. Method overloading is a separate compile-time feature selected from the available parameter lists.
        Shape[] shapes =
        {
            new Circle(),
            new Triangle(),
            new Line(),
            new Shape()
        };

        // Every item is referenced as Shape, but the override for its runtime type is executed.
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
    // virtual permits derived classes to replace this implementation with override.
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
