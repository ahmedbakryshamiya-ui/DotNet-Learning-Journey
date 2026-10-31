namespace OOPLearning.Examples;

/// <summary>
/// The this keyword refers to the current object instance.
/// </summary>
public static class ThisKeyword
{
    public static void Run()
    {
        EmployeeWithOvertime employee = new("Ahmed", Country.Palestine, 5000m);
        employee.ShowEmployee();
    }
}

public class EmployeeWithOvertime
{
    public EmployeeWithOvertime(string name, Country country, decimal salary)
    {
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
