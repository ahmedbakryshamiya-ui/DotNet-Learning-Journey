using System;

class CurrencyConverter
{
    static void Main()
    {
        
        
        const double USD = 48.5;
        const double EUR = 52.0;
        const double GBP = 60.0;
        
        Console.WriteLine("Currency Converter");
        Console.WriteLine("1 - Egyptian Pound (EGP)");
        Console.WriteLine("2 - US Dollar (USD)");
        Console.WriteLine("3 - Euro (EUR)");
        Console.WriteLine("4 - British Pound (GBP)");
       


        Console.Write("From: ");
        int from = int.Parse(Console.ReadLine());

        Console.Write("To: ");
        int to = int.Parse(Console.ReadLine());


        Console.Write("Amount: ");
        double amount = double.Parse(Console.ReadLine());

        double amountInEGP = 0;

        // Convert to EGP first
        switch (from)
        {
            case 1:
                amountInEGP = amount;
                break;
            case 2:
                amountInEGP = amount * USD;
                break;
            case 3:
                amountInEGP = amount * EUR;
                break;
            case 4:
                amountInEGP = amount * GBP;
                break;

            default:
                Console.WriteLine("Invalid currency");
                return;
        }

        double result = 0;

        // Convert from EGP to target currency
        switch (to)
        {
            case 1:
                result = amountInEGP; 
                break;
            case 2:
                result = amountInEGP / USD; 
                break;
            case 3:
                result = amountInEGP / EUR; 
                break;
            case 4:
                result = amountInEGP / GBP;
                break;

            default:
                Console.WriteLine("Invalid currency");
                return;
        }

        Console.WriteLine($"Result = {result}");
    }
}
