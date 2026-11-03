namespace OOPLearning.Examples;

/// <summary>
/// Classes are reference types; structs are value types. This example compares assignment behavior
/// and summarizes language differences without assuming that every class is allocated on the heap
/// or every struct is allocated on the stack.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/structs
/// </remarks>
public static class ClassVsStruct
{
    public static void Run()
    {
        // Assigning a class variable copies the object reference, not the object itself.
        CounterClass classFirst = new() { Value = 10 };
        CounterClass classSecond = classFirst;
        classSecond.Value = 20;

        // Assigning a struct variable copies the struct's value into a separate variable.
        CounterStruct structFirst = new() { Value = 10 };
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
        Console.WriteLine("- Both support constructors, and structs also have default initialization.");
        Console.WriteLine("- A class instance is created with new; structs can be initialized with or without new.");
        Console.WriteLine("- Stack versus heap is not a reliable definition: storage depends on where a value is held.");
    }
}

/// <summary>
/// Reference-type sample used to demonstrate shared object identity.
/// </summary>
public class CounterClass
{
    public int Value { get; set; }
}

/// <summary>
/// Value-type sample used to demonstrate value copying.
/// </summary>
public struct CounterStruct
{
    public int Value { get; set; }
}
