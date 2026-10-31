namespace OOP;

/// <summary>
/// The properties part of Employee. The original lesson used this partial class
/// in a separate source file from its methods.
/// </summary>
internal partial class Employee
{
    public int EmployeeNumber { get; set; }
    public string EmployeeName { get; set; } = string.Empty;

    // Kept with the original lesson's property name.
    public string Employeegob { get; set; } = string.Empty;
}
