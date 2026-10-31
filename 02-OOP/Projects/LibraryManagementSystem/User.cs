namespace Library_management_system;

/// <summary>
/// Shared properties and book-display behavior for library users.
/// </summary>
internal abstract class User
{
    public string Name { get; set; } = string.Empty;

    public void DisplayBooks(Library library)
    {
        library.Display();
    }
}
