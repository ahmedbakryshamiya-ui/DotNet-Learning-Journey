namespace OOP;

/// <summary>
/// This file contains the property part of the Employee partial class. The compiler combines it with the Employee declaration in the methods file to produce one class.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/partial-classes-and-methods
/// </remarks>
internal partial class Employee
{
    // Auto-properties provide get/set accessors without separate backing fields.
    public int EmployeeNumber { get; set; }
    public string EmployeeName { get; set; } = string.Empty;

    // Kept with the original lesson's property name.
    public string Employeegob { get; set; } = string.Empty;
}
