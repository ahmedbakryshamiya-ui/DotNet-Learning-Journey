namespace OOPLearning.Examples;

/// <summary>
/// IDisposable gives a type a predictable way to release resources.
/// The example uses the same using pattern as the original CurrencyService lesson.
/// </summary>
public static class DisposePattern
{
    public static void Run()
    {
        Console.WriteLine("Using statement (recommended):");

        using (CurrencyService service = new())
        {
            Console.WriteLine("CurrencyService is ready.");
            Console.WriteLine("It owns an HttpClient that will be disposed automatically.");

            Console.Write("Call the Coinbase currencies endpoint? (y/N): ");
            string answer = Console.ReadLine() ?? string.Empty;

            if (answer.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    // Demonstrates awaiting a real HTTP request.
                    string data = service.GetCurrenciesAsync().GetAwaiter().GetResult();
                    Console.WriteLine(data[..Math.Min(data.Length, 500)]);
                }
                catch (HttpRequestException exception)
                {
                    Console.WriteLine($"Request failed: {exception.Message}");
                }
                catch (TaskCanceledException)
                {
                    Console.WriteLine("The request timed out or was cancelled.");
                }
            }
        } // Dispose runs automatically, even if an exception occurs.
    }
}

/// <summary>
/// A service that owns an HttpClient, which is itself an IDisposable managed resource.
/// No finalizer is needed for this managed-resource-only example.
/// </summary>
public sealed class CurrencyService : IDisposable
{
    private bool _disposed;
    private readonly HttpClient _httpClient = new();

    public async Task<string> GetCurrenciesAsync()
    {
        ObjectDisposedException.ThrowIf(_disposed, this);

        const string url = "https://coinbase.com/api/v2/currencies";
        return await _httpClient.GetStringAsync(url);
    }

    public void Dispose()
    {
        if (_disposed)
            return;

        _httpClient.Dispose();
        _disposed = true;
        GC.SuppressFinalize(this);
    }
}
