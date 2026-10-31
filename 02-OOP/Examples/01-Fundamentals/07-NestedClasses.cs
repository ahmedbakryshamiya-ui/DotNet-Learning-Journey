namespace OOPLearning.Examples;

/// <summary>
/// A nested class is declared inside another class.
/// </summary>
public static class NestedClasses
{
    public static void Run()
    {
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

    private class Engine
    {
        public void Start() => Console.WriteLine("Engine started.");
    }
}
