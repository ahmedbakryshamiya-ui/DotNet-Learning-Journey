namespace OOPLearning.Examples;

/// <summary>
/// A struct is a value type that can contain data, properties, constructors, and methods.
/// </summary>
public static class Structs
{
    public static void Run()
    {
        EmployeeRecord employee = new("Ahmed", 20);
        employee.DisplayTimeSheet();

        Console.WriteLine($"Name: {employee.EmployeeName}");
        Console.WriteLine($"Age: {employee.EmployeeAge}");
    }
}

public struct EmployeeRecord
{
    public EmployeeRecord(string name, int age)
    {
        EmployeeName = name;
        EmployeeAge = age;
    }

    public string EmployeeName { get; set; }
    public int EmployeeAge { get; set; }

    public void DisplayTimeSheet()
    {
        Console.WriteLine("Displaying employee time sheet.");
    }
}
