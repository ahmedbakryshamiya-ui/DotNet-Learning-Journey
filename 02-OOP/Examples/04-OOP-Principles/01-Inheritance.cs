namespace OOPLearning.Examples;

/// <summary>
/// Inheritance lets a derived class reuse accessible members of a base class and add or specialize behavior. C# classes support single class inheritance: a class has one direct base class, though it can implement multiple interfaces.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/inheritance
/// </remarks>
public static class Inheritance
{
    public static void Run()
    {
        // Walkthrough: Inheritance lets a derived class reuse accessible members of a base class and add or specialize behavior. C# classes support single class inheritance: a class has one direct base class, though it can implement multiple interfaces.
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

// Dog inherits the accessible Name property and Feed method from Animal.
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
