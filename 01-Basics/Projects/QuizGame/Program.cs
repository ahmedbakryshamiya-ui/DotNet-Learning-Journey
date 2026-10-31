using System.Threading.Channels;


string[] questions = new string[] 
{
    "1.what is the red Planet? ",
    "2.what is the biggest country in the world",
    "3. What is the smallest country in the world?"

};

string[] answers = new string[] 
{
    "Mars",
    "Russia",
    "Vatican"
};
int CorrectAnswer = 0;

Console.WriteLine("Welcome to the Game" +
    "\n---------------------------" +
    "\nPlease answer the following question ");

for (int i = 0; i < questions.Length; i++)
{
    Console.WriteLine(questions[i]);
    string userAnswer= Console.ReadLine();
    try
    {
        bool result = IsTheAnswerCorrect (userAnswer, answers[i]);
        if (result == true)
        {
            Console.WriteLine("Correct answer ");
            CorrectAnswer ++;
        }
        else
            Console.WriteLine($"sorry, Incorrect answer, The correct answer is {answers[i]}");
    }
    catch (Exception ex) { Console.WriteLine(ex.Message); }
}
Console.WriteLine("---------------------------" +
    "\nQuiz completed ,Thank you for playing" +
    $"\nYour score is {CorrectAnswer} of {questions.Length}");

 static bool IsTheAnswerCorrect(string userInput ,string correctAnswer)
{
    if (string.IsNullOrEmpty(userInput))
    { 
        throw new Exception("Answer cant be empty");
    }
    return userInput == correctAnswer; // Easy way
    /* if (userInput== correctAnswer) 
         return true;

       else
         return false;*/
}


