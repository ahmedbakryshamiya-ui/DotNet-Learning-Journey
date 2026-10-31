namespace OOPLearning.Examples;

/// <summary>
/// Namespaces group related classes and make their full names unambiguous.
/// The supporting namespace declarations are in MyNameSpace.cs.
/// </summary>
public static class NamespaceExamples
{
    public static void Run()
    {
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
