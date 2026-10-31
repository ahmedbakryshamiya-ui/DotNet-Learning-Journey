using System.Text;

namespace OOPLearning.Examples;

/// <summary>
/// IDisposable provides a deterministic cleanup method named Dispose for releasing resources such as file handles. Manual Dispose and try/finally are valid patterns; using is usually preferred because the compiler ensures Dispose is called when control leaves the scope, including exceptional exits.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/standard/garbage-collection/implementing-dispose
/// </remarks>
public static class DisposePattern
{
    /// <summary>
    /// Runs the three disposal examples and writes their output to temporary files.
    /// </summary>
    public static void Run()
    {
        // Walkthrough: IDisposable provides a deterministic cleanup method named Dispose for releasing resources such as file handles. Manual Dispose and try/finally are valid patterns; using is usually preferred because the compiler ensures Dispose is called when control leaves the scope, including exceptional exits.
        string folder = Path.Combine(Path.GetTempPath(), "OOP-Learning-IDisposable");
        Directory.CreateDirectory(folder);

        Console.WriteLine("IDisposable: three ways to release a resource");
        Console.WriteLine("---------------------------------------------");

        ManualDisposeExample(Path.Combine(folder, "manual.txt"));
        TryFinallyExample(Path.Combine(folder, "try-finally.txt"));
        UsingStatementExample(Path.Combine(folder, "using.txt"));

        Console.WriteLine($"Demo files are stored in: {folder}");
    }

    /// <summary>
    /// Shows direct resource cleanup by calling Dispose manually.
    /// </summary>
    private static void ManualDisposeExample(string path)
    {
        Console.WriteLine("\n1. Manual Dispose:");

        // Create an object that owns a FileStream (a disposable resource).
        TextFileResource resource = new(path);

        // Use the resource before releasing it.
        resource.Write("Disposed by calling Dispose() manually.");

        // The caller is responsible for releasing the owned FileStream.
        resource.Dispose();

        // Dispose is idempotent in this implementation, so a repeated call is safe.
        resource.Dispose();
    }

    /// <summary>
    /// Uses finally to guarantee that Dispose is called after the try block.
    /// </summary>
    private static void TryFinallyExample(string path)
    {
        Console.WriteLine("\n2. try/finally:");

        // Create the resource before entering the try block.
        TextFileResource resource = new(path);

        try
        {
            // Work with the resource; cleanup still happens if this code throws.
            resource.Write("Disposed from the finally block.");
        }
        finally
        {
            // finally guarantees cleanup whether the try block succeeds or throws.
            resource.Dispose();
        }
    }

    /// <summary>
    /// Uses a using statement to dispose the resource automatically at the end of its scope.
    /// </summary>
    private static void UsingStatementExample(string path)
    {
        Console.WriteLine("\n3. using statement:");

        // C# automatically calls Dispose when execution leaves this block, including on exceptional exit.
        using (TextFileResource resource = new(path))
        {
            resource.Write("Disposed automatically by the using statement.");
        }
    }
}

/// <summary>
/// Owns a FileStream and exposes a small method for writing UTF-8 text.
/// This class implements IDisposable so callers can release the file handle explicitly.
/// </summary>
public sealed class TextFileResource : IDisposable
{
    private readonly FileStream _stream;
    private bool _disposed;

    /// <summary>
    /// Creates or overwrites a file and opens it for writing.
    /// </summary>
    public TextFileResource(string path)
    {
        _stream = new FileStream(path, FileMode.Create, FileAccess.Write);
        Console.WriteLine($"Opened: {Path.GetFileName(path)}");
    }

    /// <summary>
    /// Converts text to UTF-8 bytes and writes them to the open file stream.
    /// </summary>
    public void Write(string text)
    {
        // Prevent callers from writing after the resource has been disposed.
        ObjectDisposedException.ThrowIf(_disposed, this);

        byte[] data = Encoding.UTF8.GetBytes(text);
        _stream.Write(data);
        Console.WriteLine("Text written.");
    }

    /// <summary>
    /// Releases the FileStream and therefore releases its operating-system file handle.
    /// </summary>
    public void Dispose()
    {
        // Dispose can safely be called more than once.
        if (_disposed)
            return;

        // Forward cleanup to the FileStream owned by this object.
        _stream.Dispose();
        _disposed = true;

        Console.WriteLine("FileStream disposed.");
    }
}
