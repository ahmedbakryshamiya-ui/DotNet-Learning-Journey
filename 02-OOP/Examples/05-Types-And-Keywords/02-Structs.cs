namespace OOPLearning.Examples;

/// <summary>
/// A struct is a value type that can contain data, methods, properties, and constructors. Struct values are copied on assignment; structs do not support class inheritance, but they can implement interfaces.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct
/// </remarks>
public static class Structs
{
    public static void Run()
    {
        // Walkthrough: A struct is a value type that can contain data, methods, properties, and constructors. Struct values are copied on assignment; structs do not support class inheritance, but they can implement interfaces.
        // Creating this struct value calls its constructor and initializes the value's properties.
        Employee employee = new("Ahmed", 20);
        employee.DisplayTimeSheet();

        Console.WriteLine($"Employee name: {employee.EmployeeName}");
        Console.WriteLine($"Employee age: {employee.EmployeeAge}");
    }
}

// Employee is a value type: assigning it to another variable copies its value.
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
