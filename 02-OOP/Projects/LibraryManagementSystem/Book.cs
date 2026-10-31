namespace Library_management_system;

/// <summary>
/// Represents a book stored in the library.
/// </summary>
internal sealed class Book
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public int Year { get; set; }
}
