namespace OOPLearning.Examples;

/// <summary>
/// In UML class diagrams, an association indicates a relationship between classifiers (types), an aggregation is an association that indicates shared ownership, and a composition is an association that indicates a whole-part relationship. These are design relationships, not C# keywords or manual memory-management rules.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/visualstudio/modeling/scenario-change-your-design-using-visualization-and-modeling?view=visualstudio
/// </remarks>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/standard/garbage-collection/
/// </remarks>
public static class ObjectRelationships
{
    public static void Run()
    {
        // Walkthrough: Association describes objects that use or communicate with one another. Aggregation is a whole-part relationship where parts can exist independently; composition is stronger ownership where the whole controls the part construction and conceptual lifetime. In managed C#, these relationships are design concepts rather than manual memory-management rules.
        Console.WriteLine("1. ASSOCIATION (uses-a)");
        Console.WriteLine("Association is a general relationship between two types.");
        // Association: ReportService is related to Department because it uses the department in its report.
        Department department = new("Engineering");
        ReportService reportService = new();
        reportService.PrintDepartmentName(department);

        Console.WriteLine("\n2. AGGREGATION (has-a) — a special Association");
        Console.WriteLine("Aggregation is an association that indicates shared ownership.");
        // Aggregation: EmployeeMember keeps a reference to a Department supplied from outside.
        EmployeeMember employee = new("Ahmed", department);
        employee.ShowDepartment();

        Console.WriteLine("\n3. COMPOSITION (owns-a)");
        Console.WriteLine("Composition is an association that indicates a whole-part relationship.");
        // Composition: CompanyWithDepartments creates and privately encapsulates its Department part.
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
