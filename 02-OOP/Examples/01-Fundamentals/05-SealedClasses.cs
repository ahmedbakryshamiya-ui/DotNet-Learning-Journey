namespace OOPLearning.Examples;

/// <summary>
/// A sealed class prevents other classes from inheriting from it.
/// </summary>
public static class SealedClasses
{
    public static void Run()
    {
        FinalProduct product = new("Learning Kit");
        Console.WriteLine(product.Name);
    }
}

public sealed class FinalProduct
{
    public FinalProduct(string name) => Name = name;

    public string Name { get; }
}

// A class cannot derive from FinalProduct because it is sealed.
