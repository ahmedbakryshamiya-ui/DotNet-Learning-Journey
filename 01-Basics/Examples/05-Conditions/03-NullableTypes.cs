namespace Basics.Examples;

/// <summary>
/// A nullable value type can contain either a value or null.
/// </summary>
public static class NullableTypes
{
    public static void Run()
    {
        int? number = null;
        double? optionalPrice = null;

        double total = optionalPrice ?? 1;

        Console.WriteLine($"Number has value: {number.HasValue}");
        Console.WriteLine($"Total using null-coalescing: {total}");

        number = 10;
        Console.WriteLine($"Number: {number.Value}");
    }
}
