namespace OOPLearning.Examples;

/// <summary>
/// Demonstrates an explicitly declared parameterless (default) constructor.
/// </summary>
public static class DefaultConstructor
{
    public static void Run()
    {
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
    public DefaultEnemy()
    {
        Console.WriteLine("DefaultEnemy constructor is called.");

        // Set the initial state of the object.
        EnemyName = "Unknown";
        Health = 100;
        Id = 0;
    }
}
