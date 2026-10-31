namespace OOPLearning.Examples;

/// <summary>
/// This example combines a class, private state, constructor validation, methods, and inheritance. The balance is private so callers must change it through Deposit or Withdraw, where validation rules are applied.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/
/// </remarks>
public static class BankAccountExample
{
    public static void Run()
    {
        // Walkthrough: This example combines a class, private state, constructor validation, methods, and inheritance. The balance is private so callers must change it through Deposit or Withdraw, where validation rules are applied.
        // Create an account with an initial balance validated by the constructor.
        BankAccount account = new("Ahmed", 5000m);

        account.ShowBalance();
        account.Deposit(1000m);
        account.Withdraw(2000m);
        account.ShowBalance();

        NewBankAccount newAccount = new("Amr", 10000m);
        newAccount.Deposit(5000m);
        newAccount.Withdraw(10000m);
        newAccount.ShowBalance();
    }
}

public class BankAccount
{
    // Keep the balance private so all changes pass through the account validation methods.
    private decimal _balance;

    public BankAccount(string owner, decimal initialBalance)
    {
        if (initialBalance < 0)
            throw new ArgumentOutOfRangeException(nameof(initialBalance));

        Owner = owner;
        _balance = initialBalance;
    }

    public string Owner { get; }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be positive.");
            return;
        }

        _balance += amount;
        Console.WriteLine($"Deposited: {amount:C}");
    }

    // virtual lets a derived account type customize withdrawal behavior.
    public virtual void Withdraw(decimal amount)
    {
        if (amount <= 0 || amount > _balance)
        {
            Console.WriteLine("Withdrawal amount is invalid or the balance is insufficient.");
            return;
        }

        _balance -= amount;
        Console.WriteLine($"Withdrawn: {amount:C}");
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Owner: {Owner}");
        Console.WriteLine($"Balance: {_balance:C}");
    }
}

public class NewBankAccount : BankAccount
{
    public NewBankAccount(string owner, decimal initialBalance)
        : base(owner, initialBalance)
    {
        Console.WriteLine("New bank account created.");
    }
}
