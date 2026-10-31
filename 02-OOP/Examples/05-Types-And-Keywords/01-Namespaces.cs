namespace OOPLearning.Examples;

/// <summary>
/// Namespaces organize related types and help avoid naming conflicts.
/// </summary>
public static class NamespaceExamples
{
    public static void Run()
    {
        Banking.BankAccount account = new();
        Clients.Person person = new();
        ParentNameSpace.ParentNameSpaceClass parent = new();
        ParentNameSpace.SonNameSpace.SonNameSpaceClass child = new();

        Console.WriteLine(account.Description);
        Console.WriteLine(person.Description);
        Console.WriteLine(parent.Description);
        Console.WriteLine(child.Description);
    }
}
