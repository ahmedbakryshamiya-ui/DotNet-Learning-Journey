namespace OOPLearning.Examples;

/// <summary>
/// await is asynchronous and non-blocking; Task.Result blocks the calling thread.
/// </summary>
public static class AsyncVsResult
{
    // The console menu is synchronous, so it waits for this teaching demo to finish.
    public static void Run() => RunAsync().GetAwaiter().GetResult();

    private static async Task RunAsync()
    {
        Console.WriteLine(".Result (blocking):");
        string blockingResult = GetMessageAsync().Result;
        Console.WriteLine(blockingResult);

        Console.WriteLine("\nawait (asynchronous):");
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
