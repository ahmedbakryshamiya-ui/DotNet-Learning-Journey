namespace OOPLearning.Examples;

/// <summary>
/// Encapsulation combines data and the operations that work on it while controlling access to implementation details. Access modifiers determine which callers can use fields and methods; private members remain inside the declaring type, while protected members are available to derived types.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/
/// </remarks>
public static class Encapsulation
{
    public static void Run()
    {
        // Walkthrough: Encapsulation combines data and the operations that work on it while controlling access to implementation details. Access modifiers determine which callers can use fields and methods; private members remain inside the declaring type, while protected members are available to derived types.
        CatAccessDemo cat = new();
        cat.FeedCat();
        cat.ShowCatAccess();

        DogAccessDemo dog = new();
        dog.FeedDog();

        AnimalAccessBase animal = new();
        animal.TrainAnimalPublic();
        animal.TrainAnimalInternal();

        // private members cannot be called from these outside classes.
        // protected members can be used by derived classes.
    }
}

public class AnimalAccessBase
{
    // The private field is hidden; callers use the public/protected methods instead.
    private string _privateVariable = "private data";
    public string PublicVariable = "public data";
    protected string ProtectedVariable = "protected data";
    internal string InternalVariable = "internal data";

    private void TrainAnimalPrivate()
    {
        Console.WriteLine("Private training method.");
    }

    public void TrainAnimalPublic()
    {
        Console.WriteLine("Public training method.");
    }

    protected void TrainAnimalProtected()
    {
        Console.WriteLine("Protected training method.");
    }

    internal void TrainAnimalInternal()
    {
        Console.WriteLine("Internal training method.");
    }

    public void ShowPrivateMember()
    {
        Console.WriteLine(_privateVariable);
        TrainAnimalPrivate();
    }
}

public class CatAccessDemo : AnimalAccessBase
{
    public void FeedCat()
    {
        Console.WriteLine("Cat is fed.");
        TrainAnimalProtected();
    }

    public void ShowCatAccess()
    {
        Console.WriteLine(PublicVariable);
        Console.WriteLine(ProtectedVariable);
        Console.WriteLine(InternalVariable);
    }
}

public class DogAccessDemo : AnimalAccessBase
{
    public void FeedDog()
    {
        Console.WriteLine("Dog is fed.");
        TrainAnimalPublic();
        TrainAnimalInternal();
    }
}
