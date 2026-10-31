namespace OOPLearning.Examples;

/// <summary>
/// A static class cannot be instantiated and contains static members.
/// </summary>
public static class StaticClasses
{
    public static void Run()
    {
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
