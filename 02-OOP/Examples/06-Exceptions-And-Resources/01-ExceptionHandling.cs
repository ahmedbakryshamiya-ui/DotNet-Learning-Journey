namespace OOPLearning.Examples;

/// <summary>
/// try, catch, and finally let a program handle exceptional situations safely.
/// </summary>
public static class ExceptionHandling
{
    public static void Run()
    {
        int result = 0;
        int divisor = 0;

        try
        {
            result = 5 / divisor;
        }
        catch (DivideByZeroException exception)
        {
            Console.WriteLine($"Cannot divide by zero: {exception.Message}");
        }
        finally
        {
            Console.WriteLine($"Result: {result}");
        }

        string[] colors = { "black", "red", "white" };
        int index = 5;

        try
        {
            Console.WriteLine(colors[index]);
        }
        catch (IndexOutOfRangeException exception) when (index >= 0)
        {
            Console.WriteLine($"The index is outside the array: {exception.Message}");
        }
    }
}
