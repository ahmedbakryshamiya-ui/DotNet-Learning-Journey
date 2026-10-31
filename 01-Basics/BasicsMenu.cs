using Basics.Examples;

namespace Basics;

/// <summary>
/// Lets learners choose and run one C# Basics topic at a time.
/// </summary>
public static class BasicsMenu
{
    private static readonly (string Name, Action Run)[] Topics =
    {
        ("Data Types", DataTypes.Run),
        ("Conversions", Conversions.Run),
        ("Value Types", ValueTypes.Run),
        ("Reference Types", ReferenceTypes.Run),
        ("Format and StringBuilder", FormatExamples.Run),
        ("DateTime", DateTimeExamples.Run),
        ("DateOnly and TimeOnly", DateOnlyTimeOnly.Run),
        ("Get Input From User", UserInput.Run),
        ("Arithmetic Operators", ArithmeticOperators.Run),
        ("If Statement", IfStatement.Run),
        ("Logical Operators", LogicalOperators.Run),
        ("Ternary Operator", TernaryOperator.Run),
        ("Switch Statement", SwitchStatement.Run),
        ("Nullable Types", NullableTypes.Run),
        ("TryParse", TryParseExamples.Run),
        ("Constants", Constants.Run),
        ("String Manipulation", StringManipulation.Run),
        ("Escape Sequences", EscapeSequences.Run),
        ("Interpolated and Verbatim Strings", InterpolatedVerbatimStrings.Run),
        ("For Loop", ForLoopExamples.Run),
        ("Foreach Loop", ForeachLoopExamples.Run),
        ("While and Do-While", WhileDoWhileExamples.Run),
        ("Nested Loops", NestedLoops.Run),
        ("Triangle Patterns", TrianglePatterns.Run),
        ("Math Functions", MathFunctions.Run),
        ("Random Number Generation", RandomNumberGeneration.Run),
        ("Arrays", ArraysExamples.Run),
        ("Traversing 1D Array", TraversingOneDimensionalArray.Run),
        ("Bubble Sort", BubbleSort.Run),
        ("Multidimensional Arrays", MultidimensionalArrays.Run),
        ("Jagged Arrays", JaggedArrays.Run),
        ("Jagged Multidimensional Arrays", JaggedMultidimensionalArrays.Run),
        ("Ranges and Indices", RangesAndIndices.Run)
    };

    public static void Run()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("C# BASICS - TOPICS");
            Console.WriteLine("=================");

            for (int i = 0; i < Topics.Length; i++)
                Console.WriteLine($"{i + 1,2}. {Topics[i].Name}");

            Console.WriteLine(" 0. Exit");
            Console.Write("\nChoose a topic: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Pause("Please enter a valid number.");
                continue;
            }

            if (choice == 0)
                return;

            if (choice < 1 || choice > Topics.Length)
            {
                Pause("Topic not found. Choose a number from the menu.");
                continue;
            }

            Console.Clear();
            Console.WriteLine(Topics[choice - 1].Name);
            Console.WriteLine(new string('-', Topics[choice - 1].Name.Length));
            Topics[choice - 1].Run();
            Pause("\nPress Enter to return to the menu.");
        }
    }

    private static void Pause(string message)
    {
        Console.WriteLine(message);
        Console.ReadLine();
    }
}
