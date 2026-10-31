namespace OOPLearning.Examples;

/// <summary>
/// A parameterized constructor receives values used to initialize an object.
/// </summary>
public static class ParameterizedConstructor
{
    public static void Run()
    {
        ParameterizedEnemy enemy = new("Giant Zombie", 200);
        Console.WriteLine(enemy.EnemyName);
        Console.WriteLine($"Health: {enemy.Health}");
    }
}

public class ParameterizedEnemy
{
    public ParameterizedEnemy(string enemyName, double health)
    {
        EnemyName = enemyName;
        Health = health;
    }

    public string EnemyName { get; }
    public double Health { get; }
}
