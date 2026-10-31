namespace OOPLearning.Examples;

/// <summary>
/// The ref keyword lets a method work with the caller's variable itself.
/// </summary>
public static class PassByReference
{
    public static void Run()
    {
        string firstName = "Ahmed";
        string secondName = "Bakry";

        Console.WriteLine($"Before: {firstName}, {secondName}");
        ChangeNames(ref firstName, ref secondName);
        Console.WriteLine($"After:  {firstName}, {secondName}");
    }

    private static void ChangeNames(ref string first, ref string second)
    {
        first = "Mohamed";
        second = "Ali";
    }
}
