namespace OOP;

/// <summary>
/// This file contains one part of the Employee partial class. Partial declarations in the same assembly are combined into a single class, so these methods can use the properties declared in the other file.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/partial-classes-and-methods
/// </remarks>
internal partial class Employee
{
    // This constructor initializes each Employee instance.
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

    // Return the sample salary value used by the learning menu.
    public decimal CalculateSalary()
    {
        return 250000m;
    }
}
