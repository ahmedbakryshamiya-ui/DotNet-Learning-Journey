namespace OOPLearning.Examples;

/// <summary>
/// A class defines the data and behavior; an object is an instance of that class.
/// </summary>
public static class ClassesAndObjects
{
    public static void Run()
    {
        Person person = new()
        {
            FirstName = "Ahmed",
            LastName = "Bakry",
            Country = "Egypt"
        };

        Console.WriteLine($"{person.FirstName} {person.LastName}");
        Console.WriteLine(person.Country);
    }
}

public class Person
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
}
