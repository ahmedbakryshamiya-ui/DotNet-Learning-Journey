namespace OOPLearning.Examples;

/// <summary>
/// The ref keyword passes a variable by reference, allowing the method to read and assign the caller's variable itself. The caller must initialize a variable before passing it with ref, and the method can modify that variable.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref
/// </remarks>
public static class PassByReference
{
    public static void Run()
    {
        // Walkthrough: The ref keyword passes a variable by reference, allowing the method to read and assign the caller's variable itself. The caller must initialize a variable before passing it with ref, and the method can modify that variable.
        string firstName = "Ahmed";
        string secondName = "Bakry";

        Console.WriteLine($"Before: {firstName}, {secondName}");
        // ref passes the caller's variables, so assignments inside the method are visible here.
        ChangeNames(ref firstName, ref secondName);
        Console.WriteLine($"After:  {firstName}, {secondName}");
    }

    private static void ChangeNames(ref string first, ref string second)
    {
        first = "Mohamed";
        second = "Ali";
    }
}
