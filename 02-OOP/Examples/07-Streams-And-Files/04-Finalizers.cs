namespace OOPLearning.Examples;

/// <summary>
/// A finalizer is called by the garbage collector during object finalization, but its execution time is not deterministic. It should not be used for predictable cleanup; use IDisposable and using for resources that must be released promptly.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/finalizers
/// </remarks>
public static class Finalizers
{
    public static void Run()
    {
        // Walkthrough: A finalizer is called by the garbage collector during object finalization, but its execution time is not deterministic. It should not be used for predictable cleanup; use IDisposable and using for resources that must be released promptly.
        CreateTemporaryObject();

        // Forced collection is used only to make this learning demonstration visible.
        // Forced collection is used here only for demonstration; applications should not force GC routinely.
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("Finalizer demonstration finished.");
        Console.WriteLine("For predictable cleanup, prefer IDisposable and using.");
    }

    private static void CreateTemporaryObject()
    {
        _ = new EmployeeWithFinalizer();
    }
}

public class EmployeeWithFinalizer
{
    public EmployeeWithFinalizer()
    {
        Console.WriteLine("Constructor is called.");
    }

    // The garbage collector calls this finalizer; the program cannot predict exactly when.
    ~EmployeeWithFinalizer()
    {
        Console.WriteLine("Finalizer / destructor is called by the garbage collector.");
    }
}
