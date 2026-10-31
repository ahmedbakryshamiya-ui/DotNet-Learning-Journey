namespace OOPLearning.Examples;

/// <summary>
/// A class is a reference type that defines data and behavior. An object is an instance of a class; each instance has its own instance fields and properties, while methods define behavior shared by instances.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/classes
/// </remarks>
public static class ClassesAndObjects
{
    public static void Run()
    {
        // Walkthrough: A class is a reference type that defines data and behavior. An object is an instance of a class; each instance has its own instance fields and properties, while methods define behavior shared by instances.
        // new creates a Person instance; person stores a reference to that object.
        Person person = new();
        person.FirstName = "Ahmed";
        person.LastName = "Bakry";
        person.Country = "Egypt";
        person.BirthDay = new DateOnly(2000, 1, 1);

        Console.WriteLine(person.FirstName);
        Console.WriteLine($"{person.FirstName} {person.LastName}");
        Console.WriteLine(person.Country);
        Console.WriteLine($"Birthday: {person.BirthDay}");
    }
}

public class Person
{
    // These instance fields belong to each Person object and keep its internal state private.
    private string _firstName = string.Empty;
    private string _lastName = string.Empty;
    private string _country = string.Empty;
    private DateOnly _birthDay;

    // Properties provide controlled access to the private fields.
    public string FirstName
    {
        get => _firstName;
        set => _firstName = value;
    }

    public string LastName
    {
        get => _lastName;
        set => _lastName = value;
    }

    public DateOnly BirthDay
    {
        get => _birthDay;
        set => _birthDay = value;
    }

    public string Country
    {
        get => _country;
        set => _country = value;
    }
}
