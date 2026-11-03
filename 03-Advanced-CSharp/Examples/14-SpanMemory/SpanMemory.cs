namespace AdvancedCSharp.Examples;

/// <summary>
/// Span<T> and Memory<T> represent contiguous regions of memory without requiring a new array for every slice.
/// Span<T> is stack-only and synchronous; Memory<T> can be stored and used across asynchronous boundaries.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/standard/memory-and-spans/
/// </remarks>
public static class SpanMemory
{
    public static void Run()
    {
        int[] numbers = [10, 20, 30, 40, 50];

        // Create a view over the middle three elements; this does not copy the array.
        Span<int> middle = numbers.AsSpan(1, 3);

        // Updating the span updates the corresponding elements in the original array.
        middle[0] = 200;
        middle[2] = 400;

        Console.WriteLine($"Original array: {string.Join(", ", numbers)}");

        // Memory<T> can be stored in a normal object and passed to asynchronous methods.
        Memory<int> memory = numbers.AsMemory(0, 2);
        Console.WriteLine($"Memory slice: {string.Join(", ", memory.ToArray())}");
    }
}
