namespace OOPLearning.Examples;

/// <summary>
/// A class is a reference type, while a struct is a value type. This affects assignment and parameter passing, but it does not mean that every class object is always on the heap or every struct is always on the stack; storage depends on context and runtime implementation.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/structs
/// </remarks>
public static class ClassVsStruct
{
    public static void Run()
    {
        // Walkthrough: A class is a reference type, while a struct is a value type. This affects assignment and parameter passing, but it does not mean that every class object is always on the heap or every struct is always on the stack; storage depends on context and runtime implementation.
        CounterClass classFirst = new() { Value = 10 };
        // This copies the reference, so both variables refer to the same CounterClass object.
        CounterClass classSecond = classFirst;
        classSecond.Value = 20;

        CounterStruct structFirst = new() { Value = 10 };
        // This copies the struct value, so structSecond is independent from structFirst.
        CounterStruct structSecond = structFirst;
        structSecond.Value = 20;

        Console.WriteLine("Assignment behavior:");
        Console.WriteLine($"Class first: {classFirst.Value}");
        Console.WriteLine($"Class second: {classSecond.Value}");
        Console.WriteLine($"Struct first: {structFirst.Value}");
        Console.WriteLine($"Struct second: {structSecond.Value}");

        Console.WriteLine("\nMain differences:");
        Console.WriteLine("- Class is a reference type; struct is a value type.");
        Console.WriteLine("- A class can inherit from another class; a struct cannot inherit from a class or another struct.");
        Console.WriteLine("- Both classes and structs can implement interfaces.");
        Console.WriteLine("- A class can declare protected members; a struct cannot.");
        Console.WriteLine("- A class can declare a finalizer; a struct cannot.");
        Console.WriteLine("- Both support constructors. Structs also have implicit default initialization.");
        Console.WriteLine("- A class instance is created with new; structs can be initialized with or without new.");
        Console.WriteLine("- Stack versus heap is not a reliable definition: storage depends on where a value is held.");
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
