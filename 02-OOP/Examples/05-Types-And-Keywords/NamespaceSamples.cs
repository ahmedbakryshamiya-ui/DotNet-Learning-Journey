/// <summary>
/// These declarations define sample types in separate namespaces. A namespace groups types under a qualified name, which helps organize code and distinguish types with the same short name.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/namespaces
/// </remarks>
// BankAccount belongs to the Bank namespace; its fully qualified name is Bank.BankAccount.
namespace Bank
{
    public class BankAccount
    {
        public string AccountNumber { get; set; } = string.Empty;
        public int MyProperty { get; set; }

        public BankAccount()
        {
            Console.WriteLine("Bank Account is created");
        }
    }
}

// Clinet is retained as the namespace spelling used in the source example.
namespace Clinet
{
    public class Person
    {
        public string PersonName { get; set; } = string.Empty;
        public int PersonID { get; set; }

        public Person()
        {
            Console.WriteLine("Person account is created");
        }
    }
}

namespace ParentNameSpace
{
    public class ParentNameSpaceClass
    {
        public string ParentName { get; set; } = string.Empty;

        public ParentNameSpaceClass()
        {
            Console.WriteLine("Parent is here");
        }
    }

    namespace SonNameSpace
    {
        public class SonNameSpaceClass
        {
            public string SonName { get; set; } = string.Empty;

            public SonNameSpaceClass()
            {
                Console.WriteLine("Son is here");
            }
        }
    }
}
