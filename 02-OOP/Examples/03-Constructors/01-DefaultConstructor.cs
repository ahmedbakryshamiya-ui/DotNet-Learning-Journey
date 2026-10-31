namespace OOPLearning.Examples;

/// <summary>
/// A default constructor initializes an object when no arguments are supplied.
/// </summary>
public static class DefaultConstructor
{
    public static void Run()
    {
        DefaultEnemy enemy = new();
        Console.WriteLine($"Health: {enemy.Health}");
    }
}

public class DefaultEnemy
{
    public string EnemyName { get; set; } = "Unknown";
    public double Health { get; set; } = 100;
    public int Id { get; set; }
}
