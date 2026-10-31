using OOPLearning.Examples;

namespace OOPLearning;

/// <summary>
/// Lets learners run one OOP topic at a time.
/// </summary>
public static class OopMenu
{
    private static readonly (string Name, Action Run)[] Topics =
    {
        ("Return Types", ReturnTypes.Run),
        ("Access Modifiers", AccessModifiers.Run),
        ("Classes and Objects", ClassesAndObjects.Run),
        ("Static Classes", StaticClasses.Run),
        ("Sealed Classes", SealedClasses.Run),
        ("Partial Classes", PartialClasses.Run),
        ("Nested Classes", NestedClasses.Run),
        ("Pass by Value", PassByValue.Run),
        ("Pass by Reference", PassByReference.Run),
        ("Method Overloading", MethodOverloading.Run),
        ("Static Methods", StaticMethods.Run),
        ("Extension Methods", ExtensionMethods.Run),
        ("Recursive Methods", RecursiveMethods.Run),
        ("Default Constructor", DefaultConstructor.Run),
        ("Parameterized Constructor", ParameterizedConstructor.Run),
        ("Copy Constructor", CopyConstructor.Run),
        ("Private Constructor", PrivateConstructor.Run),
        ("Static Constructor", StaticConstructor.Run),
        ("Inheritance", Inheritance.Run),
        ("Encapsulation", Encapsulation.Run),
        ("Polymorphism", Polymorphism.Run),
        ("Abstraction and Abstract Classes", AbstractClasses.Run),
        ("Bank Account Example", BankAccountExample.Run),
        ("Namespaces", NamespaceExamples.Run),
        ("Structs", Structs.Run),
        ("Class vs Struct", ClassVsStruct.Run),
        ("Interfaces", Interfaces.Run),
        ("Enumerations", Enumerations.Run),
        ("This Keyword", ThisKeyword.Run),
        ("Exception Handling", ExceptionHandling.Run),
        ("Finalizers and Destructors", Finalizers.Run),
        ("Documentation Comments", DocumentationComments.Run),
        ("Async vs .Result", AsyncVsResult.Run),
        ("Stream I/O", StreamIO.Run),
        ("IDisposable and Dispose", DisposePattern.Run),
        ("DeflateStream", DeflateStreamExamples.Run),
        ("Association, Aggregation, and Composition", ObjectRelationships.Run)
    };

    public static void Run()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("C# OOP - TOPICS");
            Console.WriteLine("===============");

            for (int i = 0; i < Topics.Length; i++)
                Console.WriteLine($"{i + 1,2}. {Topics[i].Name}");

            Console.WriteLine(" 0. Exit");
            Console.Write("\nChoose a topic: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Pause("Please enter a valid number.");
                continue;
            }

            if (choice == 0)
                return;

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
