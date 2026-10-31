namespace OOPLearning.Examples;

/// <summary>
/// An interface defines a contract that implementing classes must provide.
/// </summary>
public static class Interfaces
{
    public static void Run()
    {
        IAccountFees current = new CurrentAccount { OpenAccount = 150m };
        IAccountFees savings = new SavingsAccount { OpenAccount = 200m };

        current.BankStatementFees();
        current.SendStatementViaEmail("learner@example.com");
        Console.WriteLine($"Current account annual fees: {current.AnnualFees():C}");

        savings.BankStatementFees();
        savings.SendStatementViaEmail("learner@example.com");
        Console.WriteLine($"Savings account annual fees: {savings.AnnualFees():C}");
    }
}

public interface IAccountFees
{
    string AccountNumber { get; set; }
    decimal OpenAccount { get; set; }

    void BankStatementFees();
    void SendStatementViaEmail(string email);
    decimal AnnualFees();
}

public class CurrentAccount : IAccountFees
{
    public string AccountNumber { get; set; } = string.Empty;
    public decimal OpenAccount { get; set; }

    public void BankStatementFees() => Console.WriteLine("Current account statement fee: 30 EGP.");
    public void SendStatementViaEmail(string email) => Console.WriteLine($"Sending statement to {email}.");
    public decimal AnnualFees() => 12m * (7m + 5m);
}

public class SavingsAccount : IAccountFees
{
    public string AccountNumber { get; set; } = string.Empty;
    public string AccountCurrency { get; set; } = "EGP";
    public decimal OpenAccount { get; set; }

    public void BankStatementFees() => Console.WriteLine("Savings account statement fee: 45 EGP.");
    public void SendStatementViaEmail(string email) => Console.WriteLine($"Sending statement to {email}.");
    public decimal AnnualFees() => 75m;
}
