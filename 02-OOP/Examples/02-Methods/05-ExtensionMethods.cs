namespace OOPLearning.Examples;

/// <summary>
/// A traditional extension method is a static method declared in a non-nested, non-generic static class, with this on its first parameter. It can be called with instance-method syntax, but it does not add members to or change the source type.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
/// </remarks>
public static class ExtensionMethods
{
    public static void Run()
    {
        // Walkthrough: A traditional extension method is a static method declared in a non-nested, non-generic static class, with this on its first parameter. It can be called with instance-method syntax, but it does not add members to or change the source type.
        int value = 5;
        string text = "123";

        Console.WriteLine(value.IsGreaterThan(2));
        Console.WriteLine(text.IsNumeric());
        Console.WriteLine("Ahmed".IsNumeric());
    }
}

public static class CustomExtensions
{
    // The this modifier on the first parameter makes this a traditional extension method.
    public static bool IsGreaterThan(this int first, int second)
    {
        return first > second;
    }

    public static bool IsNumeric(this string text)
    {
        return int.TryParse(text, out _);
    }
}
