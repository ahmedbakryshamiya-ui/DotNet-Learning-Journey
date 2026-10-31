namespace OOPLearning.Examples;

/// <summary>
/// By default, C# passes arguments by value: the method receives a copy of the argument. For a reference-type argument, the copied value is the object reference, so a method can change the referenced object's state but cannot reassign the caller's variable itself.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/methods
/// </remarks>
public static class PassByValue
{
    public static void Run()
    {
        // Walkthrough: By default, C# passes arguments by value: the method receives a copy of the argument. For a reference-type argument, the copied value is the object reference, so a method can change the referenced object's state but cannot reassign the caller's variable itself.
        string firstName = "Ahmed";
        string secondName = "Bakry";

        Console.WriteLine($"Before: {firstName}, {secondName}");
        ChangeNames(firstName, secondName);
        Console.WriteLine($"After:  {firstName}, {secondName}");
    }

    // The parameters are local copies; assigning them does not replace the caller's variables.
    private static void ChangeNames(string first, string second)
    {
        first = "Mohamed";
        second = "Ali";
        Console.WriteLine($"Inside method: {first}, {second}");
    }
}
