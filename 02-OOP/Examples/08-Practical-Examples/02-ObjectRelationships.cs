namespace OOPLearning.Examples;

/// <summary>
/// Association describes objects that use or communicate with one another. Aggregation is a whole-part relationship where parts can exist independently; composition is stronger ownership where the whole controls the part construction and conceptual lifetime. In managed C#, these relationships are design concepts rather than manual memory-management rules.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/standard/garbage-collection/
/// </remarks>
public static class ObjectRelationships
{
    public static void Run()
    {
        // Walkthrough: Association describes objects that use or communicate with one another. Aggregation is a whole-part relationship where parts can exist independently; composition is stronger ownership where the whole controls the part construction and conceptual lifetime. In managed C#, these relationships are design concepts rather than manual memory-management rules.
        Console.WriteLine("1. ASSOCIATION (uses-a)");
        Console.WriteLine("One object uses another object without owning it.");
        // Association: a service uses an existing Department object without owning it.
        Department department = new("Engineering");
        ReportService reportService = new();
        reportService.PrintDepartmentName(department);

        Console.WriteLine("\n2. AGGREGATION (has-a) — a special Association");
        Console.WriteLine("One object has a reference to another, and both can exist independently.");
        // Aggregation: the employee receives the existing Department rather than creating it.
        EmployeeMember employee = new("Ahmed", department);
        employee.ShowDepartment();

        Console.WriteLine("\n3. COMPOSITION (owns-a)");
        Console.WriteLine("One object creates and owns another object as one of its parts.");
        // Composition: the company creates and privately keeps its Department component.
        CompanyWithDepartments company = new("Example Company");
        company.ShowOwnedDepartment();
    }
}

public class Department
{
    public Department(string name) => Name = name;
    public string Name { get; }
}

public class EmployeeMember
{
    private readonly Department _department;

    public EmployeeMember(string name, Department department)
    {
        Name = name;
        _department = department;
    }

    public string Name { get; }

    public void ShowDepartment()
    {
        Console.WriteLine($"{Name} works in {_department.Name}.");
    }
}

public class ReportService
{
    public void PrintDepartmentName(Department department)
    {
        Console.WriteLine($"Department report: {department.Name}");
    }
}

public class CompanyWithDepartments
{
    private readonly Department _department;

    public CompanyWithDepartments(string companyName)
    {
        CompanyName = companyName;
        // Create the owned component inside the whole object and keep its reference private.
        _department = new Department("Internal Operations");
    }

    public string CompanyName { get; }

    public void ShowOwnedDepartment()
    {
        Console.WriteLine($"{CompanyName} owns {_department.Name}.");
    }
}
