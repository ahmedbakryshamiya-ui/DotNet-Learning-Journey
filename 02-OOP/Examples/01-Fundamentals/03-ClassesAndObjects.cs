namespace OOPLearning.Examples;

/// <summary>
/// A class defines data and behavior; an object is an instance of that class.
/// </summary>
public static class ClassesAndObjects
{
    public static void Run()
    {
        Person person = new()
        {
            FirstName = "Ahmed",
            LastName = "Bakry",
            Country = "Egypt",
            BirthDay = new DateOnly(2000, 1, 1)
        };

        Console.WriteLine($"{person.FirstName} {person.LastName}");
        Console.WriteLine(person.Country);
        Console.WriteLine($"Birthday: {person.BirthDay}");
    }
}

public class Person
{
    // Properties expose the data of the object.
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateOnly BirthDay { get; set; }
    public string Country { get; set; } = string.Empty;
}
