namespace OOPLearning.Examples;

/// <summary>
/// A parameterless constructor has no parameters and initializes a new instance. If a class declares no instance constructors, C# supplies an implicit public parameterless constructor; once an instance constructor is declared, that implicit constructor is not supplied.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/instance-constructors
/// </remarks>
public static class DefaultConstructor
{
    public static void Run()
    {
        // Walkthrough: A parameterless constructor has no parameters and initializes a new instance. If a class declares no instance constructors, C# supplies an implicit public parameterless constructor; once an instance constructor is declared, that implicit constructor is not supplied.
        // No arguments are passed, so the parameterless constructor is called.
        DefaultEnemy enemy = new();

        // Values below were assigned inside DefaultEnemy() when the object was created.
        Console.WriteLine($"Enemy name: {enemy.EnemyName}");
        Console.WriteLine($"Health: {enemy.Health}");
        Console.WriteLine($"Id: {enemy.Id}");
    }
}

/// <summary>
/// A simple enemy whose parameterless constructor assigns its initial values.
/// </summary>
public class DefaultEnemy
{
    public string EnemyName { get; set; }
    public double Health { get; set; }
    public int Id { get; set; }

    // Default constructor: it has the same name as the class and takes no parameters.
    // This explicitly declared parameterless constructor overrides the need for an implicit one.
    public DefaultEnemy()
    {
        Console.WriteLine("DefaultEnemy constructor is called.");

        // Set the initial state of the object.
        EnemyName = "Unknown";
        Health = 100;
        Id = 0;
    }
}
