namespace OOPLearning.Examples;

/// <summary>
/// An extension method adds a callable method to an existing type without editing that type.
/// </summary>
public static class ExtensionMethods
{
    public static void Run()
    {
        int value = 5;
        string text = "123";

        Console.WriteLine(value.IsGreaterThan(2));
        Console.WriteLine(text.IsNumeric());
        Console.WriteLine("Ahmed".IsNumeric());
    }
}

public static class CustomExtensions
{
    public static bool IsGreaterThan(this int first, int second)
    {
        return first > second;
    }

    public static bool IsNumeric(this string text)
    {
        return int.TryParse(text, out _);
    }
}
