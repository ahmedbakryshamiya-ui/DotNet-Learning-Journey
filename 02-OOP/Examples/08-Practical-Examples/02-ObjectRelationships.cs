namespace OOPLearning.Examples;

/// <summary>
/// Demonstrates three object relationships:
/// <list type="bullet">
/// <item><description>Association (uses-a): one object uses another object without owning it.</description></item>
/// <item><description>Aggregation (has-a): a special Association where the referenced objects can exist independently.</description></item>
/// <item><description>Composition (owns-a): one object creates and strongly owns another object as a part.</description></item>
/// </list>
/// </summary>
public static class ObjectRelationships
{
    public static void Run()
    {
        Console.WriteLine("1. ASSOCIATION (uses-a)");
        Console.WriteLine("One object uses another object without owning it.");
        Department department = new("Engineering");
        ReportService reportService = new();
        reportService.PrintDepartmentName(department);

        Console.WriteLine("\n2. AGGREGATION (has-a) — a special Association");
        Console.WriteLine("One object has a reference to another, and both can exist independently.");
        EmployeeMember employee = new("Ahmed", department);
        employee.ShowDepartment();

        Console.WriteLine("\n3. COMPOSITION (owns-a)");
        Console.WriteLine("One object creates and owns another object as one of its parts.");
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
        _department = new Department("Internal Operations");
    }

    public string CompanyName { get; }

    public void ShowOwnedDepartment()
    {
        Console.WriteLine($"{CompanyName} owns {_department.Name}.");
    }
}
