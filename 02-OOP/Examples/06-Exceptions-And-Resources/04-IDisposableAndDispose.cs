namespace OOPLearning.Examples;

/// <summary>
/// IDisposable provides deterministic cleanup when an object owns disposable resources.
/// </summary>
public static class DisposePattern
{
    public static void Run()
    {
        using (DemoResource resource = new())
        {
            resource.Use();
        } // Dispose is called automatically here.
    }
}

public sealed class DemoResource : IDisposable
{
    private bool _disposed;

    public void Use()
    {
        ObjectDisposedException.ThrowIf(_disposed, this);
        Console.WriteLine("Resource is in use.");
    }

    public void Dispose()
    {
        if (_disposed)
            return;

        Console.WriteLine("Resource released.");
        _disposed = true;
        GC.SuppressFinalize(this);
    }
}
