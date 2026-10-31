namespace Basics.Examples;

/// <summary>
/// A reference-type variable stores a reference to an object. Assigning it copies the reference, so both variables can refer to the same object and observe changes to that object.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/
/// </remarks>
public static class ReferenceTypes
{
    public static void Run()
    {
        // Walkthrough: A reference-type variable stores a reference to an object. Assigning it copies the reference, so both variables can refer to the same object and observe changes to that object.
        int[] first = { 1, 2, 3 };
        // The array itself is not duplicated; only its reference is copied.
        int[] second = first;

        second[0] = 99;

        Console.WriteLine($"first[0] = {first[0]}");
        Console.WriteLine($"second[0] = {second[0]}");
        Console.WriteLine("Both variables refer to the same array.");
    }
}
