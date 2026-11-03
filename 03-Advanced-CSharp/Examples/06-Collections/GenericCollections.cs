namespace AdvancedCSharp.Examples;

/// <summary>
/// Generic collections store strongly typed elements and provide operations suited to different access patterns.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/standard/collections/
/// </remarks>
public static class GenericCollections
{
    public static void Run()
    {
        // List<T> is a resizable ordered collection and supports index-based access.
        List<string> names = ["Ahmed", "Mona", "Youssef"];
        names.Add("Sara");
        Console.WriteLine($"Second name: {names[1]}");

        // Dictionary<TKey, TValue> associates unique keys with values.
        Dictionary<string, decimal> prices = new()
        {
            ["Book"] = 120m,
            ["Notebook"] = 45m
        };
        prices["Pen"] = 15m;

        if (prices.TryGetValue("Book", out decimal bookPrice))
        {
            Console.WriteLine($"Book price: {bookPrice:C}");
        }

        // HashSet<T> stores unique values; adding an existing value has no effect.
        HashSet<string> tags = ["C#", "DotNet", "C#"];
        Console.WriteLine($"Unique tags: {tags.Count}");

        // Queue<T> follows first-in, first-out (FIFO) order.
        Queue<string> requests = new();
        requests.Enqueue("Request A");
        requests.Enqueue("Request B");
        Console.WriteLine($"Next request: {requests.Dequeue()}");

        // Stack<T> follows last-in, first-out (LIFO) order.
        Stack<string> history = new();
        history.Push("Page 1");
        history.Push("Page 2");
        Console.WriteLine($"Most recent page: {history.Pop()}");
    }
}
