namespace Basics.Examples;

/// <summary>
/// Traversing means visiting array elements one by one.
/// </summary>
public static class TraversingOneDimensionalArray
{
    public static void Run()
    {
        char[] genders = { 'f', 'f', 'f', 'm', 'm', 'm', 'm', 'm' };
        int males = 0;
        int females = 0;

        foreach (char gender in genders)
        {
            if (gender == 'm')
                males++;
            else if (gender == 'f')
                females++;
        }

        Console.WriteLine($"Number of males: {males}");
        Console.WriteLine($"Number of females: {females}");
    }
}
