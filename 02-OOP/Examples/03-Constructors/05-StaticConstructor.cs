namespace OOPLearning.Examples;

/// <summary>
/// A static constructor initializes static data or performs type-specific setup. It is called automatically at most once by the runtime, before the type is first used in a way that requires initialization; it has no parameters and no access modifier.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-constructors
/// </remarks>
public static class StaticConstructor
{
    public static void Run()
    {
        // Walkthrough: A static constructor initializes static data or performs type-specific setup. It is called automatically at most once by the runtime, before the type is first used in a way that requires initialization; it has no parameters and no access modifier.
        _ = new ConstructorSample();
        _ = new ConstructorSample();
        _ = new ConstructorSample();
    }
}

public class ConstructorSample
{
    private static int _staticCount;
    private static int _instanceCount;

    // The runtime invokes this once, before the type is first initialized for use.
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
