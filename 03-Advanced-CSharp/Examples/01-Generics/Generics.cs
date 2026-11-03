namespace AdvancedCSharp.Examples;

/// <summary>
/// Generic types and methods let one implementation work with multiple data types while preserving compile-time type safety.
/// Constraints describe the capabilities a type argument must provide.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/generics
/// </remarks>
public static class Generics
{
    public static void Run()
    {
        // GenericBox<int> stores integers, while GenericBox<string> stores strings.
        // The compiler prevents putting a value of the wrong type in either box.
        GenericBox<int> scoreBox = new(95);
        GenericBox<string> nameBox = new("Ahmed");

        Console.WriteLine($"Score: {scoreBox.Value}");
        Console.WriteLine($"Name: {nameBox.Value}");

        // The where constraint allows this method to call CompareTo on T.
        Console.WriteLine($"Larger number: {GetLarger(18, 25)}");
        Console.WriteLine($"Last alphabetically: {GetLarger("Alpha", "Omega")}");
    }

    /// <summary>
    /// Returns the greater of two values that support generic comparison.
    /// </summary>
    private static T GetLarger<T>(T first, T second) where T : IComparable<T>
    {
        // CompareTo returns a negative number, zero, or a positive number.
        return first.CompareTo(second) >= 0 ? first : second;
    }
}

/// <summary>
/// A strongly typed container whose stored value has the type selected by the caller.
/// </summary>
public sealed class GenericBox<T>
{
    public GenericBox(T value)
    {
        Value = value;
    }

    public T Value { get; }
}
