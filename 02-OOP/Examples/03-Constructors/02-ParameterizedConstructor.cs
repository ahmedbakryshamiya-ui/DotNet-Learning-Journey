namespace OOPLearning.Examples;

/// <summary>
/// An instance constructor runs when an object is created and can receive parameters used to initialize its state. A parameterized constructor lets callers provide the initial values instead of relying on default values.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/instance-constructors
/// </remarks>
public static class ParameterizedConstructor
{
    public static void Run()
    {
        // Walkthrough: An instance constructor runs when an object is created and can receive parameters used to initialize its state. A parameterized constructor lets callers provide the initial values instead of relying on default values.
        ParameterizedEnemy enemy = new("Giant Zombie", 200);
        Console.WriteLine(enemy.EnemyName);
        Console.WriteLine($"Health: {enemy.Health}");
    }
}

public class ParameterizedEnemy
{
    // The caller supplies initial values; the constructor stores them in this new object.
    public ParameterizedEnemy(string enemyName, double health)
    {
        EnemyName = enemyName;
        Health = health;
    }

    public string EnemyName { get; }
    public double Health { get; }
}
