using System.Runtime.CompilerServices;

namespace AdvancedCSharp.Examples;

/// <summary>
/// IAsyncEnumerable<T> represents a sequence whose elements are produced asynchronously.
/// await foreach requests each element and awaits the asynchronous move to the next element.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/generate-consume-asynchronous-stream
/// </remarks>
public static class AsyncStreams
{
    public static async Task RunAsync()
    {
        using CancellationTokenSource cancellationSource = new();

        // await foreach consumes values as they become available instead of waiting for a complete list.
        await foreach (int value in GetNumbersAsync(cancellationSource.Token))
        {
            Console.WriteLine($"Received: {value}");
        }
    }

    private static async IAsyncEnumerable<int> GetNumbersAsync(
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        for (int number = 1; number <= 5; number++)
        {
            // Simulate an asynchronous source such as a network response or database cursor.
            await Task.Delay(300, cancellationToken);

            // Yield the current value and suspend this iterator until the consumer asks for another.
            yield return number;
        }
    }
}
