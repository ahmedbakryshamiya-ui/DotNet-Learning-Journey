namespace OOPLearning.Examples;

/// <summary>
/// The partial modifier allows a type declaration to be split across multiple source files. The compiler combines the parts into one type; the parts must be compiled together and agree on the type's identity and namespace.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/partial-classes-and-methods
/// </remarks>
public static class PartialClasses
{
    public static void Run()
    {
        // Walkthrough: The partial modifier allows a type declaration to be split across multiple source files. The compiler combines the parts into one type; the parts must be compiled together and agree on the type's identity and namespace.
        // Employee's properties and methods are declared in separate partial source files.
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
