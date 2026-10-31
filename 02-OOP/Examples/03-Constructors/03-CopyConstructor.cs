namespace OOPLearning.Examples;

/// <summary>
/// A copy constructor creates a new object using another object of the same type.
/// </summary>
public static class CopyConstructor
{
    public static void Run()
    {
        CopyEnemy original = new("Giant Zombie", 200);
        CopyEnemy copy = new(original);

        Console.WriteLine(copy.EnemyName);
        Console.WriteLine($"Health: {copy.Health}");
    }
}

public class CopyEnemy
{
    public CopyEnemy(string enemyName, double health)
    {
        EnemyName = enemyName;
        Health = health;
    }

    public CopyEnemy(CopyEnemy source)
    {
        EnemyName = source.EnemyName;
        Health = source.Health;
    }

    public string EnemyName { get; }
    public double Health { get; }
}
