namespace OOPLearning.Examples;

/// <summary>
/// await lets an asynchronous operation complete without blocking its asynchronous method.
/// </summary>
public static class AsyncVsResult
{
    // The menu is synchronous, so this small wrapper waits for the async demonstration to finish.
    public static void Run() => RunAsync().GetAwaiter().GetResult();

    private static async Task RunAsync()
    {
        string message = await GetMessageAsync();
        Console.WriteLine(message);

        // Avoid blocking patterns such as GetMessageAsync().Result in normal async code.
    }

    private static async Task<string> GetMessageAsync()
    {
        await Task.Delay(100);
        return "The asynchronous operation has completed.";
    }
}
