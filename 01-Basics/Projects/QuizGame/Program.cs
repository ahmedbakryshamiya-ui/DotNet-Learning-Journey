string[] questions =
{
    "1. What is the Red Planet?",
    "2. What is the biggest country in the world by area?",
    "3. What is the smallest country in the world?"
};

string[] answers =
{
    "Mars",
    "Russia",
    "Vatican"
};

int correctAnswerCount = 0;

Console.WriteLine(
    "Welcome to the Quiz Game\n" +
    "------------------------\n" +
    "Answer the following questions.");

for (int i = 0; i < questions.Length; i++)
{
    Console.WriteLine();
    Console.WriteLine(questions[i]);
    Console.Write("Your answer: ");
    string userAnswer = Console.ReadLine() ?? string.Empty;

    if (string.IsNullOrWhiteSpace(userAnswer))
    {
        Console.WriteLine($"No answer entered. The correct answer is {answers[i]}.");
        continue;
    }

    if (IsTheAnswerCorrect(userAnswer, answers[i]))
    {
        Console.WriteLine("Correct answer!");
        correctAnswerCount++;
    }
    else
    {
        Console.WriteLine($"Incorrect answer. The correct answer is {answers[i]}.");
    }
}

Console.WriteLine("\n------------------------");
Console.WriteLine("Quiz completed. Thank you for playing.");
Console.WriteLine($"Your score is {correctAnswerCount} of {questions.Length}.");

static bool IsTheAnswerCorrect(string userInput, string correctAnswer)
{
    return string.Equals(
        userInput.Trim(),
        correctAnswer,
        StringComparison.OrdinalIgnoreCase);
}
