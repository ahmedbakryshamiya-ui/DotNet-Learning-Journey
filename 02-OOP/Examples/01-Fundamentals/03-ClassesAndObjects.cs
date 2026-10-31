namespace OOPLearning.Examples;

/// <summary>
/// A class is a blueprint; an object is an instance containing its own data.
/// </summary>
public static class ClassesAndObjects
{
    public static void Run()
    {
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
    // Private fields hold the object's internal data.
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
