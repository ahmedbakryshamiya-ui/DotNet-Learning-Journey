namespace OOPLearning.Examples;

/// <summary>
/// An enum stores a fixed set of named values.
/// </summary>
public static class Enumerations
{
    public static void Run()
    {
        PersonRecord first = new()
        {
            PersonName = "Ahmed",
            Contre = Contre.Palestine,
            language = Language.Arabic,
            months = Months.January
        };

        PersonRecord second = new("Ali", Contre.Syria, Language.Arabic, Months.February);

        Display(first);
        Display(second);

        Console.WriteLine(Months.January);
        Console.WriteLine((byte)Months.January);

        foreach (Months month in Enum.GetValues<Months>())
            Console.WriteLine($"{month}: {(byte)month}");
    }

    private static void Display(PersonRecord value)
    {
        Console.WriteLine(
            $"Person Name: {value.PersonName}, Country: {value.Contre}, " +
            $"Language: {value.language}, Month: {value.months}");
    }
}

public enum Months : byte
{
    January = 1,
    February = 2,
    March = 3,
    April = 4,
    May = 5,
    June = 6,
    July = 7,
    August = 8,
    September = 9,
    October = 10,
    November = 11,
    December = 12
}

public enum Contre
{
    Egypt,
    Syria,
    Iraq,
    Palestine
}

public enum Language
{
    Arabic,
    English,
    German
}

public class PersonRecord
{
    public string PersonName { get; set; } = string.Empty;
    public Contre Contre { get; set; }
    public Language language { get; set; }
    public Months months { get; set; }

    public PersonRecord()
    {
    }

    public PersonRecord(string name, Contre country, Language lang, Months month)
    {
        PersonName = name;
        Contre = country;
        language = lang;
        months = month;
    }
}
