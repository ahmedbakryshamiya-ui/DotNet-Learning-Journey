namespace OOPLearning.Examples;

/// <summary>
/// PartialClasses demonstrates a class whose members are split across source files.
/// </summary>
public static class PartialClasses
{
    public static void Run()
    {
        Employee employee = new()
        {
            EmployeeName = "Ahmed",
            EmployeeNumber = 1
        };

        Console.WriteLine($"{employee.EmployeeName} - {employee.EmployeeNumber}");
        Console.WriteLine($"Salary: {employee.CalculateSalary():C}");
    }
}
