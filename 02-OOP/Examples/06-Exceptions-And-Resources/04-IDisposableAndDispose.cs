namespace OOPLearning.Examples;

/// <summary>
/// IDisposable gives a type a predictable way to release disposable resources.
/// </summary>
public static class DisposePattern
{
    public static void Run()
    {
        Console.WriteLine("The using statement is the recommended way to dispose this service.");

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
        } // Dispose is called automatically, including when an exception occurs.
    }
}

/// <summary>
/// A service that owns an HttpClient.
/// The Dispose(bool) pattern is shown for teaching; no finalizer is needed because
/// HttpClient is a managed IDisposable resource and this type owns no raw unmanaged handle.
/// </summary>
public class CurrencyService : IDisposable
{
    private bool _disposed;
    private readonly HttpClient _httpClient = new();

    public async Task<string> GetCurrenciesAsync()
    {
        ObjectDisposedException.ThrowIf(_disposed, this);
        const string url = "https://coinbase.com/api/v2/currencies";
        return await _httpClient.GetStringAsync(url);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (_disposed)
            return;

        if (disposing)
        {
            // Release managed disposable resources.
            _httpClient.Dispose();
        }

        // Release unmanaged resources here if the class owns any.
        _disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}
