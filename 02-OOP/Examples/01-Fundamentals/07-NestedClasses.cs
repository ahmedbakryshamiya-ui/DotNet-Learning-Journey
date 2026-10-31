namespace OOPLearning.Examples;

/// <summary>
/// A nested type is declared inside another type and is a member of that containing type. Nesting organizes related types and lets the nested type access private members of the containing type; its accessibility is controlled by an access modifier.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/nested-types
/// </remarks>
public static class NestedClasses
{
    public static void Run()
    {
        // Walkthrough: A nested type is declared inside another type and is a member of that containing type. Nesting organizes related types and lets the nested type access private members of the containing type; its accessibility is controlled by an access modifier.
        Car car = new();
        car.Start();
    }
}

public class Car
{
    private readonly Engine _engine = new();

    public void Start()
    {
        _engine.Start();
        Console.WriteLine("Car is ready.");
    }

    // Engine is private to Car, so callers interact with it through Car.Start().
    private class Engine
    {
        public void Start() => Console.WriteLine("Engine started.");
    }
}
