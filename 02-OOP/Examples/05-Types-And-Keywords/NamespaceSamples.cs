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
