namespace Basics.Examples;

/// <summary>
/// Console.ReadLine reads text entered by the user.
/// </summary>
public static class UserInput
{
    public static void Run()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine() ?? string.Empty;
        Console.WriteLine($"Name: {name}");

        Console.Write("What is your job? ");
        string job = Console.ReadLine() ?? string.Empty;
        Console.WriteLine($"Job: {job}");

        Console.Write("Enter your current salary: ");
        bool currentValid = decimal.TryParse(Console.ReadLine(), out decimal currentSalary);

        Console.Write("Enter your desired salary: ");
        bool desiredValid = decimal.TryParse(Console.ReadLine(), out decimal desiredSalary);

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
        if (DateTime.TryParse(Console.ReadLine(), out DateTime birthday))
            Console.WriteLine($"{birthday.DayOfWeek} - {birthday.Day} of {birthday:MMMM} {birthday.Year}");
        else
            Console.WriteLine("Invalid date.");
    }
}
