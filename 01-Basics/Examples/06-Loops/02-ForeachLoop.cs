namespace Basics.Examples;

/// <summary>
/// A foreach statement enumerates the elements of a collection and executes its body for each element. It avoids manual index management and uses the collection's enumerator.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements
/// </remarks>
public static class ForeachLoopExamples
{
    public static void Run()
    {
        // Walkthrough: A foreach statement enumerates the elements of a collection and executes its body for each element. It avoids manual index management and uses the collection's enumerator.
        string[] names = { "Ahmed", "Bakry", "Sayed" };

        // Enumerate the collection one element at a time; no manual index is required.
        foreach (string name in names)
            Console.WriteLine(name);
    }
}
