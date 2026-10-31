# Quiz Game

A short console quiz that checks three answers and displays the final score.

## Run

Open [QuizGame.slnx](QuizGame.slnx) in Visual Studio, or run:

```bash
dotnet run --project QuizGame.csproj
```

## Quiz flow

![Quiz game flow](QuizGame.svg)

- [Open the editable Draw.io diagram](QuizGame.drawio)
- [Source code](Program.cs)

## How it works

1. Stores questions and matching answers in two arrays.
2. Loops through each question and reads the user's answer.
3. Calls `IsTheAnswerCorrect` to compare the answer.
4. Increments the score for a correct answer.
5. Displays the final score out of the total number of questions.

## Current behavior and limitations

- Answers are trimmed and compared without case sensitivity; `mars` matches `Mars`.
- An empty answer is treated as incorrect and does not stop the quiz.
- The quiz contains three fixed questions and does not currently support replay, random question order, or configurable questions.
- The second question explicitly asks for the biggest country by area; the stored answer is Russia.
