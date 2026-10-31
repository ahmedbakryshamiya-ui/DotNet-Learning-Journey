namespace OOPLearning.Examples;

/// <summary>
/// A static class cannot be instantiated or used as a base class. Its fields, properties, methods, and events are static; it can also declare nested types. Use it to group functionality that does not depend on per-instance state.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members
/// </remarks>
public static class StaticClasses
{
    public static void Run()
    {
        // Walkthrough: A static class cannot be instantiated and can contain only static members. It is sealed and cannot be used as a base class; use it to group functionality that does not operate on per-instance state.
        // Access static members through the type name; no Company instance is created.
        Console.WriteLine(Company.CompanyName);
        Console.WriteLine(Company.CompanyLocation);
        Console.WriteLine($"Total employees: {Company.GetTotalEmployees()}");
    }
}

public static class Company
{
    public static string CompanyName { get; } = "Bakry";
    public static string CompanyLocation { get; } = "Cairo";

    public static int GetTotalEmployees() => 2000;
}
