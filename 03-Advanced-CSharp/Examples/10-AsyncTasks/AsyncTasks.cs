namespace AdvancedCSharp.Examples;

/// <summary>
/// Task represents an asynchronous operation. await waits for its completion without blocking the current thread,
/// and Task.WhenAll allows independent operations to run concurrently and then collects their results.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/
/// </remarks>
public static class AsyncTasks
{
    public static async Task RunAsync()
    {
        Console.WriteLine("Starting two independent operations...");

        // Both tasks are started before either one is awaited.
        Task<string> firstTask = GetMessageAsync("First", 700);
        Task<string> secondTask = GetMessageAsync("Second", 400);

        // WhenAll completes when every supplied task has completed.
        string[] results = await Task.WhenAll(firstTask, secondTask);

        foreach (string result in results)
        {
            Console.WriteLine(result);
        }

        Console.WriteLine("Both operations completed.");
    }

    private static async Task<string> GetMessageAsync(string name, int delayMilliseconds)
    {
        // Task.Delay represents asynchronous waiting and does not block this thread.
        await Task.Delay(delayMilliseconds);

        return $"{name} operation finished after {delayMilliseconds} ms.";
    }
}
