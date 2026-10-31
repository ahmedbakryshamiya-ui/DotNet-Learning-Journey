namespace OOPLearning.Examples;

/// <summary>
/// Enums represent a fixed set of named constants.
/// </summary>
public static class Enumerations
{
    public static void Run()
    {
        PersonProfile first = new()
        {
            PersonName = "Ahmed",
            Country = PersonCountry.Palestine,
            Language = Language.Arabic,
            Month = Month.January
        };

        PersonProfile second = new("Ali", PersonCountry.Syria, Language.Arabic, Month.February);

        Display(first);
        Display(second);

        Console.WriteLine($"January numeric value: {(byte)Month.January}");

        foreach (Month month in Enum.GetValues<Month>())
            Console.WriteLine($"{month}: {(byte)month}");
    }

    private static void Display(PersonProfile person)
    {
        Console.WriteLine(
            $"Name: {person.PersonName}, Country: {person.Country}, " +
            $"Language: {person.Language}, Month: {person.Month}");
    }
}

public enum Month : byte
{
    January = 1, February, March, April, May, June,
    July, August, September, October, November, December
}

public enum PersonCountry
{
    Egypt, Syria, Iraq, Palestine
}

public enum Language
{
    Arabic, English, German
}

public class PersonProfile
{
    public PersonProfile()
    {
    }

    public PersonProfile(string name, PersonCountry country, Language language, Month month)
    {
        PersonName = name;
        Country = country;
        Language = language;
        Month = month;
    }

    public string PersonName { get; set; } = string.Empty;
    public PersonCountry Country { get; set; }
    public Language Language { get; set; }
    public Month Month { get; set; }
}
