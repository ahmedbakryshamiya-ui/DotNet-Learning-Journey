namespace OOPLearning.Examples;

/// <summary>
/// Demonstrates three object relationships:
/// <list type="bullet">
/// <item><description>Association (uses-a): ReportService temporarily uses a Department passed to a method.</description></item>
/// <item><description>Aggregation (weak has-a): EmployeeMember stores a Department created outside it; both can exist independently.</description></item>
/// <item><description>Composition (strong owns-a): CompanyWithDepartments creates and privately owns its Department.</description></item>
/// </list>
/// </summary>
public static class ObjectRelationships
{
    public static void Run()
    {
        Console.WriteLine("1. ASSOCIATION — uses-a");
        Console.WriteLine("A service uses an object but does not own it.");
        Department department = new("Engineering");
        ReportService reportService = new();
        reportService.PrintDepartmentName(department);

        Console.WriteLine("\n2. AGGREGATION — weak has-a");
        Console.WriteLine("An object keeps a reference to an independently created object.");
        EmployeeMember employee = new("Ahmed", department);
        employee.ShowDepartment();

        Console.WriteLine("\n3. COMPOSITION — strong owns-a");
        Console.WriteLine("An object creates and privately owns one of its parts.");
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
