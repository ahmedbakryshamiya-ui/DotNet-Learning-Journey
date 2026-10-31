namespace OOPLearning.Examples;

/// <summary>
/// An exception represents an error that occurs while a program is executing. try encloses code that may throw, catch handles a matching exception, finally performs cleanup when control leaves the try statement, and a when filter adds a condition to a catch clause.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/
/// </remarks>
public static class ExceptionHandling
{
    public static void Run()
    {
        // Walkthrough: An exception represents an error that occurs while a program is executing. try encloses code that may throw, catch handles a matching exception, finally performs cleanup when control leaves the try statement, and a when filter adds a condition to a catch clause.
        Console.WriteLine("Example 1: division by zero");
        int result = 0;
        int divisor = 0;

        try
        {
            result = 5 / divisor;
        }
        catch (DivideByZeroException exception)
        {
            Console.WriteLine($"Exception: {exception.Message}");
        }
        finally
        {
            Console.WriteLine($"Result: {result}");
        }

        Console.WriteLine("\nExample 2: positive invalid index");
        ReadColorAtIndex(5);

        Console.WriteLine("\nExample 3: negative invalid index");
        ReadColorAtIndex(-1);
    }

    private static void ReadColorAtIndex(int index)
    {
        string[] colors = { "black", "red", "white" };

        try
        {
            Console.WriteLine(colors[index]);
        }
        // Catch the specific range exception instead of swallowing unrelated failures.
        catch (IndexOutOfRangeException exception) when (index > 0)
        {
            Console.WriteLine("The supplied index is greater than zero.");
            Console.WriteLine($"Exception: {exception.Message}");
        }
        catch (IndexOutOfRangeException exception) when (index < 0)
        {
            Console.WriteLine("The supplied index is less than zero.");
            Console.WriteLine($"Exception: {exception.Message}");
        }
    }
}
