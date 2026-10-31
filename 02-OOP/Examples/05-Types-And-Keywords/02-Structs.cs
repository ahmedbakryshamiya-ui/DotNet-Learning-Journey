namespace OOPLearning.Examples;

/// <summary>
/// A struct is a value type. It can contain properties, methods, and constructors.
/// </summary>
public static class Structs
{
    public static void Run()
    {
        Employee employee = new("Ahmed", 20);
        employee.DisplayTimeSheet();

        Console.WriteLine($"Employee name: {employee.EmployeeName}");
        Console.WriteLine($"Employee age: {employee.EmployeeAge}");
    }
}

public struct Employee
{
    public Employee(string name, int age)
    {
        EmployeeName = name;
        EmployeeAge = age;
    }

    public string EmployeeName { get; set; }
    public int EmployeeAge { get; set; }

    public void DisplayTimeSheet()
    {
        Console.WriteLine("TimeSheet method is inside the struct.");
    }
}
