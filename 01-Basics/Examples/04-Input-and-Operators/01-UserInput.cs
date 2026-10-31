namespace Basics.Examples;

/// <summary>
/// Console.ReadLine returns the next line of input as a string, or null when no more input is available. TryParse methods validate text before the program uses converted numeric or date values.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/system.console.readline
/// </remarks>
public static class UserInput
{
    public static void Run()
    {
        // Walkthrough: Console.ReadLine returns the next line of input as a string, or null when no more input is available. TryParse methods validate text before the program uses converted numeric or date values.
        Console.Write("What is your name? ");
        string name = Console.ReadLine() ?? string.Empty;
        Console.WriteLine($"Name: {name}");

        Console.Write("What is your job? ");
        string job = Console.ReadLine() ?? string.Empty;
        Console.WriteLine($"Job: {job}");

        Console.Write("Enter your current salary: ");
        // TryParse returns false for text that cannot be converted, avoiding a format exception.
        bool currentValid = decimal.TryParse(Console.ReadLine(), out decimal currentSalary);

        Console.Write("Enter your desired salary: ");
        bool desiredValid = decimal.TryParse(Console.ReadLine(), out decimal desiredSalary);

        // Evaluate the condition; execute this block only when it is true.
        if (currentValid && desiredValid)
        {
            Console.WriteLine($"Current salary: {currentSalary}");
            Console.WriteLine($"Desired salary: {desiredSalary}");
        }
        else
        {
            Console.WriteLine("Please enter valid salary values.");
        }

        Console.Write("Enter your birth date: ");
        // Evaluate the condition; execute this block only when it is true.
        if (DateTime.TryParse(Console.ReadLine(), out DateTime birthday))
            Console.WriteLine($"{birthday.DayOfWeek} - {birthday.Day} of {birthday:MMMM} {birthday.Year}");
        else
            Console.WriteLine("Invalid date.");
    }
}
