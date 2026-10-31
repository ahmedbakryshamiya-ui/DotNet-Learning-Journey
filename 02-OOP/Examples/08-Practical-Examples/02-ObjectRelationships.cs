namespace OOPLearning.Examples;

/// <summary>
/// Association, aggregation, and composition describe different relationships between objects.
/// </summary>
public static class ObjectRelationships
{
    public static void Run()
    {
        Department department = new("Engineering");
        EmployeeMember employee = new("Ahmed", department); // Aggregation: department is supplied from outside.
        employee.ShowDepartment();

        ReportService reportService = new();
        reportService.PrintDepartmentName(department); // Association: the service uses a department.

        CompanyWithDepartments company = new("Example Company");
        company.ShowOwnedDepartment(); // Composition: the company creates and owns its department.
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
