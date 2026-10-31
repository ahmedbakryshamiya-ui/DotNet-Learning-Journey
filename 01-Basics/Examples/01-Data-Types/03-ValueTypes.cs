namespace Basics.Examples;

/// <summary>
/// Value types hold their own value. Assigning one copies that value.
/// </summary>
public static class ValueTypes
{
    public static void Run()
    {
        int first = 10;
        int second = first;
        second = 20;

        Console.WriteLine($"first = {first}");
        Console.WriteLine($"second = {second}");
        Console.WriteLine("Changing second does not change first.");
    }
}
