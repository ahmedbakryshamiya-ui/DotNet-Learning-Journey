namespace OOPLearning.Examples;

/// <summary>
/// A static method belongs to the type and is called through the type name; it has no current object instance and cannot access instance members directly. An instance method is called on an object and can use that object's instance state.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members
/// </remarks>
public static class StaticMethods
{
    public static void Run()
    {
        // Walkthrough: A static method belongs to the type and is called through the type name; it has no current object instance and cannot access instance members directly. An instance method is called on an object and can use that object's instance state.
        // A static method is invoked on the type, without creating a Bank object.
        Bank.CreateNewAccountStatic();

        Bank bank = new();
        // An instance method is invoked on this particular Bank object.
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
