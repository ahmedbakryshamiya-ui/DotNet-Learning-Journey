namespace OOPLearning.Examples;

/// <summary>
/// A static method belongs to the type; an instance method belongs to an object.
/// </summary>
public static class StaticMethods
{
    public static void Run()
    {
        Bank.CreateNewAccountStatic();

        Bank bank = new();
        bank.CreateNewAccount();
    }
}

public class Bank
{
    public static void CreateNewAccountStatic()
    {
        Console.WriteLine("Account created using a static method.");
    }

    public void CreateNewAccount()
    {
        Console.WriteLine("Account created using an instance method.");
    }
}
