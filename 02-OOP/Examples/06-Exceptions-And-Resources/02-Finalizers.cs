namespace OOPLearning.Examples;

/// <summary>
/// A finalizer may run when the garbage collector reclaims an object.
/// Its timing is not deterministic, so do not rely on it for normal resource cleanup.
/// </summary>
public static class Finalizers
{
    public static void Run()
    {
        CreateTemporaryObject();

        // Forced collection is used only to make this learning demonstration visible.
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

    ~EmployeeWithFinalizer()
    {
        Console.WriteLine("Finalizer / destructor is called by the garbage collector.");
    }
}
