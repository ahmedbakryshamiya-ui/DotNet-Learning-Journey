namespace Basics.Examples;

/// <summary>
/// Reference-type variables can refer to the same object in memory.
/// </summary>
public static class ReferenceTypes
{
    public static void Run()
    {
        int[] first = { 1, 2, 3 };
        int[] second = first;

        second[0] = 99;

        Console.WriteLine($"first[0] = {first[0]}");
        Console.WriteLine($"second[0] = {second[0]}");
        Console.WriteLine("Both variables refer to the same array.");
    }
}
