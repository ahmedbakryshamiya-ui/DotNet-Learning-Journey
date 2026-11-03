namespace AdvancedCSharp.Examples;

/// <summary>
/// CancellationToken provides cooperative cancellation. A caller requests cancellation through a CancellationTokenSource,
/// and the running operation checks the token and responds by stopping or throwing OperationCanceledException.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/standard/threading/cancellation-in-managed-threads
/// </remarks>
public static class CancellationExamples
{
    public static async Task RunAsync()
    {
        using CancellationTokenSource cancellationSource = new();

        // Start an operation that checks the supplied token between steps.
        Task work = DoWorkAsync(cancellationSource.Token);

        // Request cancellation after a short interval; the running operation decides when to observe it.
        cancellationSource.CancelAfter(TimeSpan.FromMilliseconds(750));

        try
        {
            await work;
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("The operation observed the cancellation request.");
        }
    }

    private static async Task DoWorkAsync(CancellationToken cancellationToken)
    {
        for (int step = 1; step <= 10; step++)
        {
            // Throw if cancellation was requested before starting the next step.
            cancellationToken.ThrowIfCancellationRequested();

            Console.WriteLine($"Working on step {step}...");

            // Pass the token to asynchronous APIs that support cancellation.
            await Task.Delay(250, cancellationToken);
        }

        Console.WriteLine("Work completed.");
    }
}
