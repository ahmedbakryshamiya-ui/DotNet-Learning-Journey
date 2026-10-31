namespace OOP;

/// <summary>
/// The methods part of Employee, separated from its properties.
/// </summary>
internal partial class Employee
{
    public Employee()
    {
        Console.WriteLine("Employee object is created.");
    }

    public void DisplayTimeSheet()
    {
        Displaytimesheet();
    }

    // Original method name retained from the source archive.
    public void Displaytimesheet()
    {
        Console.WriteLine($"Displaying time sheet for {EmployeeName}.");
    }

    public decimal CalculateSalary()
    {
        return 250000m;
    }
}
