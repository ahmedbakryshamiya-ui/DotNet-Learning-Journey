namespace OOPLearning.Examples;

/// <summary>
/// Pass by value gives a method a copy of the argument value.
/// </summary>
public static class PassByValue
{
    public static void Run()
    {
        string firstName = "Ahmed";
        string secondName = "Bakry";

        Console.WriteLine($"Before: {firstName}, {secondName}");
        ChangeNames(firstName, secondName);
        Console.WriteLine($"After:  {firstName}, {secondName}");
    }

    private static void ChangeNames(string first, string second)
    {
        first = "Mohamed";
        second = "Ali";
        Console.WriteLine($"Inside method: {first}, {second}");
    }
}
