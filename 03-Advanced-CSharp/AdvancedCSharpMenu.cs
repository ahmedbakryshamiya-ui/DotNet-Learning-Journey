using AdvancedCSharp.Examples;

namespace AdvancedCSharp;

/// <summary>
/// Interactive menu for the Advanced C# learning section.
/// </summary>
public static class AdvancedCSharpMenu
{
    private static readonly (string Name, Func<Task> Run)[] Topics =
    {
        ("Generic Types and Methods", RunSync(Generics.Run)),
        ("Delegates and Built-in Delegate Types", RunSync(Delegates.Run)),
        ("Events and Event Handling", RunSync(Events.Run)),
        ("Lambda Expressions and Closures", RunSync(LambdaExpressions.Run)),
        ("LINQ and Deferred Execution", RunSync(LinqQueries.Run)),
        ("Generic Collections", RunSync(GenericCollections.Run)),
        ("Iterators and yield", RunSync(Iterators.Run)),
        ("Records and Non-Destructive Mutation", RunSync(Records.Run)),
        ("Pattern Matching", RunSync(PatternMatching.Run)),
        ("Async, Await, and Task.WhenAll", AsyncTasks.RunAsync),
        ("Cooperative Cancellation", CancellationExamples.RunAsync),
        ("Asynchronous Streams", AsyncStreams.RunAsync),
        ("Attributes and Reflection", RunSync(ReflectionExamples.Run)),
        ("Span and Memory", RunSync(SpanMemory.Run))
    };

    /// <summary>
    /// Displays topics and awaits each selected lesson.
    /// </summary>
    public static async Task RunAsync()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("ADVANCED C#");
            Console.WriteLine("===========");

            for (int i = 0; i < Topics.Length; i++)
            {
                Console.WriteLine($"{i + 1,2}. {Topics[i].Name}");
            }

            Console.WriteLine(" 0. Exit");
            Console.Write("\nChoose a topic: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Pause("Please enter a valid number.");
                continue;
            }

            if (choice == 0)
            {
                return;
            }

            if (choice < 1 || choice > Topics.Length)
            {
                Pause("Topic not found. Choose a number from the menu.");
                continue;
            }

            Console.Clear();
            Console.WriteLine(Topics[choice - 1].Name);
            Console.WriteLine(new string('-', Topics[choice - 1].Name.Length));

            await Topics[choice - 1].Run();

            Pause("\nPress Enter to return to the menu.");
        }
    }

    // Wrap synchronous examples so the menu can await every lesson consistently.
    private static Func<Task> RunSync(Action action)
    {
        return () =>
        {
            action();
            return Task.CompletedTask;
        };
    }

    private static void Pause(string message)
    {
        Console.WriteLine(message);
        Console.ReadLine();
    }
}
