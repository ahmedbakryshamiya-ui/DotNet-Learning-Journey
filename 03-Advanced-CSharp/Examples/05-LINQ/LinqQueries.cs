namespace AdvancedCSharp.Examples;

/// <summary>
/// LINQ provides query operations for filtering, ordering, grouping, and projecting data from collections.
/// Many LINQ operators use deferred execution and run when the query is enumerated.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/csharp/linq/
/// </remarks>
public static class LinqQueries
{
    public static void Run()
    {
        List<int> scores = [72, 95, 60, 88, 95, 43];

        // Where and OrderBy build a query; they do not immediately create a new result list.
        IEnumerable<int> passingScores = scores
            .Where(score => score >= 70)
            .OrderBy(score => score);

        // The query executes when foreach enumerates it.
        Console.WriteLine("Passing scores:");
        foreach (int score in passingScores)
        {
            Console.WriteLine(score);
        }

        // ToList executes the query now and stores the results in a separate list.
        List<int> savedResults = passingScores.ToList();

        // A later change to the source list affects a deferred query but not the saved list.
        scores.Add(100);

        Console.WriteLine($"Deferred query count: {passingScores.Count()}");
        Console.WriteLine($"Saved result count: {savedResults.Count}");

        // Select projects each score into a formatted string.
        IEnumerable<string> labels = scores.Select(score => $"Score: {score}");
        Console.WriteLine(string.Join(" | ", labels));
    }
}
