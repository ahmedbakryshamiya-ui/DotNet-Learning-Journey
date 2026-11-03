namespace AdvancedCSharp.Examples;

/// <summary>
/// An iterator produces a sequence of values with yield return. The next value is produced when the caller requests it.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/iterators
/// </remarks>
public static class Iterators
{
    public static void Run()
    {
        // The iterator method is not fully run here; foreach requests one value at a time.
        foreach (int number in GetEvenNumbers(10))
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("Names:");
        foreach (string name in GetNames())
        {
            Console.WriteLine(name);
        }
    }

    /// <summary>
    /// Yields even numbers up to and including the supplied maximum.
    /// </summary>
    private static IEnumerable<int> GetEvenNumbers(int maximum)
    {
        for (int number = 0; number <= maximum; number += 2)
        {
            // Pause the iterator and return this value to the caller.
            yield return number;
        }
    }

    /// <summary>
    /// Demonstrates that yield break ends the sequence early.
    /// </summary>
    private static IEnumerable<string> GetNames()
    {
        yield return "Ahmed";
        yield return "Mona";

        // Stop producing values; later statements in this iterator are not reached.
        yield break;
    }
}
