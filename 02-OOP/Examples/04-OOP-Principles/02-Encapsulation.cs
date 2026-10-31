namespace OOPLearning.Examples;

/// <summary>
/// Encapsulation protects data and exposes only the operations that are needed.
/// This example also shows member access from derived classes.
/// </summary>
public static class Encapsulation
{
    public static void Run()
    {
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
