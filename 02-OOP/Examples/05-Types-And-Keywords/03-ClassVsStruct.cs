namespace OOPLearning.Examples;

/// <summary>
/// Classes are reference types; structs are value types. Assignment behaves differently.
/// </summary>
public static class ClassVsStruct
{
    public static void Run()
    {
        CounterClass classFirst = new() { Value = 10 };
        CounterClass classSecond = classFirst;
        classSecond.Value = 20;

        CounterStruct structFirst = new() { Value = 10 };
        CounterStruct structSecond = structFirst;
        structSecond.Value = 20;

        Console.WriteLine($"Class first: {classFirst.Value}");
        Console.WriteLine($"Class second: {classSecond.Value}");
        Console.WriteLine($"Struct first: {structFirst.Value}");
        Console.WriteLine($"Struct second: {structSecond.Value}");
    }
}

public class CounterClass
{
    public int Value { get; set; }
}

public struct CounterStruct
{
    public int Value { get; set; }
}
