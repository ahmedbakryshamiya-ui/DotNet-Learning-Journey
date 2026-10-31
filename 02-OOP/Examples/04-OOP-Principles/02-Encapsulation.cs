namespace OOPLearning.Examples;

/// <summary>
/// Encapsulation keeps data private and exposes controlled operations.
/// </summary>
public static class Encapsulation
{
    public static void Run()
    {
        SecureAnimal animal = new("Cat");
        animal.Feed();
        animal.ShowStatus();

        // The private health field cannot be changed directly from this class.
    }
}

public class SecureAnimal
{
    private int _health = 100;

    public SecureAnimal(string name) => Name = name;

    public string Name { get; }

    public void Feed()
    {
        _health = Math.Min(_health + 10, 100);
        Console.WriteLine($"{Name} has been fed.");
    }

    public void ShowStatus()
    {
        Console.WriteLine($"{Name}'s health: {_health}");
    }
}
