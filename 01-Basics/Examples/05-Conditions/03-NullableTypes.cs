namespace Basics.Examples;

/// <summary>
/// A nullable value type T? can represent every value of T plus null. HasValue checks whether a value exists, Value accesses it when present, and ?? supplies a fallback when the left operand is null.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-value-types
/// </remarks>
public static class NullableTypes
{
    public static void Run()
    {
        // Walkthrough: A nullable value type T? can represent every value of T plus null. HasValue checks whether a value exists, Value accesses it when present, and ?? supplies a fallback when the left operand is null.
        int? number = null;
        double? optionalPrice = null;

        // ?? uses 1 only when optionalPrice is null; it does not replace a real zero value.
        double total = optionalPrice ?? 1;

        Console.WriteLine($"Number has value: {number.HasValue}");
        Console.WriteLine($"Total using null-coalescing: {total}");

        number = 10;
        Console.WriteLine($"Number: {number.Value}");
    }
}
