namespace OOPLearning.Examples;

/// <summary>
/// C# does not automatically generate a copy constructor for a class. A programmer can define one that creates a new object by copying selected state from an existing object; this example copies two string and numeric properties.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/instance-constructors
/// </remarks>
public static class CopyConstructor
{
    public static void Run()
    {
        // Walkthrough: C# does not automatically generate a copy constructor for a class. A programmer can define one that creates a new object by copying selected state from an existing object; this example copies two string and numeric properties.
        CopyEnemy original = new("Giant Zombie", 200);
        // This creates a distinct CopyEnemy object and copies the selected state from original.
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
