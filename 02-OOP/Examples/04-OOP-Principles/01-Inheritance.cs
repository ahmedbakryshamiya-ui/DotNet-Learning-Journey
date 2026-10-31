namespace OOPLearning.Examples;

/// <summary>
/// Inheritance lets a derived class reuse and extend a base class.
/// </summary>
public static class Inheritance
{
    public static void Run()
    {
        Animal animal = new() { Name = "Animal" };
        Dog dog = new() { Name = "Dog", Breed = "Labrador" };
        Bird bird = new() { Name = "Bird", Color = "Blue" };

        animal.Feed();
        dog.Feed();
        dog.Walk();
        bird.Fly();

        Console.WriteLine($"{dog.Name}: {dog.Breed}");
        Console.WriteLine($"{bird.Name}: {bird.Color}");
    }
}

public class Animal
{
    public string Name { get; set; } = string.Empty;

    public void Feed()
    {
        Console.WriteLine($"{Name} is being fed.");
    }
}

public class Dog : Animal
{
    public string Breed { get; set; } = string.Empty;

    public void Walk()
    {
        Console.WriteLine($"{Name} is walking.");
    }
}

public class Bird : Animal
{
    public string Color { get; set; } = string.Empty;

    public void Fly()
    {
        Console.WriteLine($"{Name} is flying.");
    }
}
