namespace Basics.Examples;

/// <summary>
/// foreach visits each item in a collection without requiring an index.
/// </summary>
public static class ForeachLoopExamples
{
    public static void Run()
    {
        string[] names = { "Ahmed", "Bakry", "Sayed" };

        foreach (string name in names)
            Console.WriteLine(name);
    }
}
