namespace OOPLearning.Examples;

/// <summary>
/// try/catch/finally handle exceptions; exception filters can select a catch block.
/// </summary>
public static class ExceptionHandling
{
    public static void Run()
    {
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

        Console.WriteLine("\nExample 2: negative invalid index");
        ReadColorAtIndex(-1);
    }

    private static void ReadColorAtIndex(int index)
    {
        string[] colors = { "black", "red", "white" };

        try
        {
            Console.WriteLine(colors[index]);
        }
        catch (Exception exception) when (index > 0)
        {
            Console.WriteLine("The supplied index is greater than zero.");
            Console.WriteLine($"Exception: {exception.Message}");
        }
        catch (Exception exception) when (index < 0)
        {
            Console.WriteLine("The supplied index is less than zero.");
            Console.WriteLine($"Exception: {exception.Message}");
        }
    }
}
