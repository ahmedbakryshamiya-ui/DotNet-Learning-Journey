namespace OOPLearning.Examples;

/// <summary>
/// A static constructor initializes static data once for the type.
/// </summary>
public static class StaticConstructor
{
    public static void Run()
    {
        _ = new ConstructorSample();
        _ = new ConstructorSample();
        _ = new ConstructorSample();
    }
}

public class ConstructorSample
{
    private static int _staticCount;
    private static int _instanceCount;

    static ConstructorSample()
    {
        _staticCount++;
        Console.WriteLine($"Static constructor called: {_staticCount}");
    }

    public ConstructorSample()
    {
        _instanceCount++;
        Console.WriteLine($"Instance constructor called: {_instanceCount}");
    }
}
