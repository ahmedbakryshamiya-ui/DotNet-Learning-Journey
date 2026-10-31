namespace Library_management_system;

/// <summary>
/// A librarian manages the available book collection.
/// </summary>
internal sealed class Librarian : User
{
    public Librarian(string name)
    {
        Name = name;
    }

    public int EmployeeNumber { get; set; }

    public void AddBook(Book newBook, Library library)
    {
        library.Add(newBook);
    }

    public void RemoveBook(Book book, Library library)
    {
        library.Remove(book);
    }
}
