using AdvancedCSharp.Examples;

namespace AdvancedCSharp;

/// <summary>
/// Lets learners run the Streams and Files topics in the Advanced C# section.
/// </summary>
public static class AdvancedCSharpMenu
{
    private static readonly (string Name, Action Run)[] Topics =
    {
        ("Stream I/O", StreamIO.Run),
        ("Finalizers and Destructors", Finalizers.Run),
        ("IDisposable and Dispose", DisposePattern.Run),
        ("DeflateStream", DeflateStreamExamples.Run)
    };

    public static void Run()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("ADVANCED C# - STREAMS AND FILES");
            Console.WriteLine("===============================");

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
            Topics[choice - 1].Run();
            Pause("\nPress Enter to return to the menu.");
        }
    }

    private static void Pause(string message)
    {
        Console.WriteLine(message);
        Console.ReadLine();
    }
}
