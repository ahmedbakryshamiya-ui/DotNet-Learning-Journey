namespace OOPLearning.Examples;

/// <summary>
/// await lets an asynchronous operation complete without blocking the calling thread.
/// </summary>
public static class AsyncVsResult
{
    public static async Task Run()
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
