namespace OOPLearning.Examples;

/// <summary>
/// Within an instance member, this refers to the current instance. It can distinguish an instance member from a parameter with the same name and can pass the current object to another method.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/this
/// </remarks>
public static class ThisKeyword
{
    public static void Run()
    {
        // Walkthrough: Within an instance member, this refers to the current instance. It can distinguish an instance member from a parameter with the same name and can pass the current object to another method.
        EmployeeWithOvertime employee = new("Ahmed", Country.Palestine, 5000m);
        // The current employee object is passed to Overtime.Calculate through this.
        employee.ShowEmployee();
    }
}

public class EmployeeWithOvertime
{
    public EmployeeWithOvertime(string name, Country country, decimal salary)
    {
        // this.Name identifies the instance property, while name is the constructor parameter.
        this.Name = name;
        this.Country = country;
        this.Salary = salary;
    }

    public string Name { get; set; }
    public Country Country { get; set; }
    public decimal Salary { get; set; }

    public void ShowEmployee()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Country: {Country}");
        Console.WriteLine($"Salary after overtime: {Overtime.Calculate(this, 40, 20):C}");
    }
}

public static class Overtime
{
    public static decimal Calculate(EmployeeWithOvertime employee, decimal hours, decimal rate)
    {
        return employee.Salary + (hours * rate);
    }
}

public enum Country
{
    Egypt,
    Syria,
    Iraq,
    Palestine
}
