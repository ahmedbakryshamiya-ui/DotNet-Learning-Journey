namespace OOPLearning.Examples;

/// <summary>
/// A namespace organizes related types and provides a way to qualify type names. A fully qualified name includes the namespace hierarchy and the type name; using directives can make names shorter but do not move a type into another namespace.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/namespaces
/// </remarks>
public static class NamespaceExamples
{
    public static void Run()
    {
        // Walkthrough: A namespace organizes related types and provides a way to qualify type names. A fully qualified name includes the namespace hierarchy and the type name; using directives can make names shorter but do not move a type into another namespace.
        // global:: starts lookup from the global namespace, avoiding ambiguity with local names.
        global::Bank.BankAccount account = new();
        global::Clinet.Person person = new();
        global::ParentNameSpace.ParentNameSpaceClass parent = new();
        global::ParentNameSpace.SonNameSpace.SonNameSpaceClass son = new();

        Console.WriteLine($"Bank account property: {account.AccountNumber}");
        Console.WriteLine($"Client property: {person.PersonName}");
        Console.WriteLine($"Parent namespace: {parent.ParentName}");
        Console.WriteLine($"Child namespace: {son.SonName}");
    }
}
