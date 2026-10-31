namespace OOPLearning.Examples;

/// <summary>
/// await asynchronously waits for a Task without blocking the current thread while the operation is incomplete. Task<TResult>.Result synchronously blocks the caller until the task completes and can cause deadlocks in some synchronization contexts; prefer await in asynchronous code.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/
/// </remarks>
public static class AsyncVsResult
{
    // The console menu is synchronous, so it waits for this teaching demo to finish.
    public static void Run() => RunAsync().GetAwaiter().GetResult();

    private static async Task RunAsync()
    {
        Console.WriteLine(".Result (blocking):");
        // Result waits synchronously for completion and blocks this calling thread.
        string blockingResult = GetMessageAsync().Result;
        Console.WriteLine(blockingResult);

        Console.WriteLine("\nawait (asynchronous):");
        // await yields control while the task is incomplete, then resumes with its result.
        string awaitedResult = await GetMessageAsync();
        Console.WriteLine(awaitedResult);

        Console.WriteLine("\nPrefer await in modern asynchronous code.");
        Console.WriteLine("Result blocks while waiting and can cause deadlocks in some synchronization contexts.");
    }

    private static async Task<string> GetMessageAsync()
    {
        await Task.Delay(100);
        return "The asynchronous operation has completed.";
    }
}
