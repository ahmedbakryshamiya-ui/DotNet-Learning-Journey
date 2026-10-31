using System.Globalization;

internal static class CurrencyConverter
{
    private const decimal UsdToEgp = 48.5m;
    private const decimal EurToEgp = 52.0m;
    private const decimal GbpToEgp = 60.0m;

    private static readonly string[] CurrencyNames =
    {
        "Egyptian Pound (EGP)",
        "US Dollar (USD)",
        "Euro (EUR)",
        "British Pound (GBP)"
    };

    private static void Main()
    {
        Console.WriteLine("Currency Converter");
        for (int i = 0; i < CurrencyNames.Length; i++)
            Console.WriteLine($"{i + 1} - {CurrencyNames[i]}");

        if (!TryReadCurrency("From (1-4): ", out int from) ||
            !TryReadCurrency("To (1-4): ", out int to))
        {
            Console.WriteLine("Conversion cancelled because a currency selection was invalid.");
            return;
        }

        Console.Write("Amount: ");
        if (!decimal.TryParse(Console.ReadLine(), NumberStyles.Number, CultureInfo.CurrentCulture, out decimal amount) ||
            amount <= 0)
        {
            Console.WriteLine("Enter a valid amount greater than zero.");
            return;
        }

        decimal amountInEgp = from switch
        {
            1 => amount,
            2 => amount * UsdToEgp,
            3 => amount * EurToEgp,
            4 => amount * GbpToEgp,
            _ => throw new InvalidOperationException("Unexpected source currency.")
        };

        decimal result = to switch
        {
            1 => amountInEgp,
            2 => amountInEgp / UsdToEgp,
            3 => amountInEgp / EurToEgp,
            4 => amountInEgp / GbpToEgp,
            _ => throw new InvalidOperationException("Unexpected target currency.")
        };

        Console.WriteLine($"{amount:N2} {CurrencyNames[from - 1]} = {result:N2} {CurrencyNames[to - 1]}");
        Console.WriteLine("Note: these are fixed example rates, not live exchange rates.");
    }

    private static bool TryReadCurrency(string prompt, out int currency)
    {
        Console.Write(prompt);
        if (int.TryParse(Console.ReadLine(), out currency) &&
            currency >= 1 && currency <= CurrencyNames.Length)
        {
            return true;
        }

        Console.WriteLine("Choose a currency number from 1 to 4.");
        return false;
    }
}
