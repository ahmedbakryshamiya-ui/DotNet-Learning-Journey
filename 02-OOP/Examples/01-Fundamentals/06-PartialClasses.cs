namespace OOPLearning.Examples;

/// <summary>
/// A partial class lets one type be split across several files.
/// </summary>
public static class PartialClasses
{
    public static void Run()
    {
        OOP.Employee employee = new()
        {
            EmployeeName = "Ahmed",
            EmployeeNumber = 1,
            Employeegob = "Software Developer"
        };

        Console.WriteLine(
            $"{employee.EmployeeName} - {employee.EmployeeNumber} - " +
            $"{employee.Employeegob} - Salary: {employee.CalculateSalary():C}");
    }
}
