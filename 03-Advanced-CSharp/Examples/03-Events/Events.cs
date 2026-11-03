namespace AdvancedCSharp.Examples;

/// <summary>
/// Events provide a publish-subscribe mechanism: an object raises a notification and subscribed handlers respond to it.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/events-overview
/// </remarks>
public static class Events
{
    public static void Run()
    {
        Thermometer thermometer = new();

        // Subscribe to the event with the += operator.
        thermometer.TemperatureChanged += OnTemperatureChanged;

        thermometer.SetTemperature(22);
        thermometer.SetTemperature(28);

        // Remove the handler when this subscriber no longer needs notifications.
        thermometer.TemperatureChanged -= OnTemperatureChanged;

        // This update is not printed because the handler has been unsubscribed.
        thermometer.SetTemperature(31);
    }

    private static void OnTemperatureChanged(object? sender, TemperatureChangedEventArgs args)
    {
        Console.WriteLine($"Temperature changed from {args.Previous}°C to {args.Current}°C.");
    }
}

/// <summary>
/// Provides the previous and current readings with a temperature-change notification.
/// </summary>
public sealed class TemperatureChangedEventArgs(int previous, int current) : EventArgs
{
    public int Previous { get; } = previous;
    public int Current { get; } = current;
}

/// <summary>
/// Publishes a notification when its temperature value changes.
/// </summary>
public sealed class Thermometer
{
    public event EventHandler<TemperatureChangedEventArgs>? TemperatureChanged;

    private int _temperature;

    public void SetTemperature(int value)
    {
        // Do not raise an event when the value has not changed.
        if (_temperature == value)
        {
            return;
        }

        int previous = _temperature;
        _temperature = value;

        // Copy the event delegate before invocation so the null check and invocation use the same handler list.
        EventHandler<TemperatureChangedEventArgs>? handler = TemperatureChanged;
        handler?.Invoke(this, new TemperatureChangedEventArgs(previous, value));
    }
}
