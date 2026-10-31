namespace OOPLearning.Examples;

/// <summary>
/// A finalizer can run when the garbage collector reclaims an object. Its timing is not deterministic.
/// </summary>
public static class Finalizers
{
    public static void Run()
    {
        CreateTemporaryObject();

        // Forced collection is shown for learning only; normal applications should not force GC.
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("Finalizer demonstration finished.");
    }

    private static void CreateTemporaryObject()
    {
        _ = new FinalizableSample();
    }
}

public class FinalizableSample
{
    ~FinalizableSample()
    {
        Console.WriteLine("Finalizer called by the garbage collector.");
    }
}
