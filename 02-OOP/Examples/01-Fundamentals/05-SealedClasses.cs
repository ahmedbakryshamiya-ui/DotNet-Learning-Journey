namespace OOPLearning.Examples;

/// <summary>
/// The sealed modifier prevents a class from being used as a base class. A sealed class can still be instantiated and used normally; attempting to derive from it causes a compile-time error.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/sealed
/// </remarks>
public static class SealedClasses
{
    public static void Run()
    {
        // Sealed does not prevent object creation.
        FinalProduct product = new("Learning Kit");
        Console.WriteLine($"Product: {product.Name}");

        Console.WriteLine("FinalProduct is sealed, so another class cannot inherit from it.");
    }
}

/// <summary>
/// The sealed keyword prevents any class from deriving from FinalProduct.
/// </summary>
// The sealed modifier is what makes the inheritance attempt below illegal.
public sealed class FinalProduct
{
    public FinalProduct(string name)
    {
        // Store the name supplied when the object is created.
        Name = name;
    }

    // A read-only property exposes the product name.
    public string Name { get; }
}

/*
 * The following code is intentionally commented out because it causes a compile-time error:
 *
 * public class SpecialProduct : FinalProduct
 * {
 * }
 *
 * Compiler error: CS0509
 * 'SpecialProduct': cannot derive from sealed type 'FinalProduct'
 *
 * In other words, sealed blocks inheritance at compile time, not at runtime.
 */
