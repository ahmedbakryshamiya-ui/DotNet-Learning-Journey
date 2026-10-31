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

namespace Banking
{
    public class BankAccount
    {
        public string Description => "Banking.BankAccount";
    }
}

namespace Clients
{
    public class Person
    {
        public string Description => "Clients.Person";
    }
}

namespace ParentNameSpace
{
    public class ParentNameSpaceClass
    {
        public string Description => "ParentNameSpace.ParentNameSpaceClass";
    }

    namespace SonNameSpace
    {
        public class SonNameSpaceClass
        {
            public string Description => "ParentNameSpace.SonNameSpace.SonNameSpaceClass";
        }
    }
}
