namespace Library_management_system;

/// <summary>
/// A regular user can browse available books and borrow them.
/// </summary>
internal sealed class LibraryUser : User
{
    private static int _nextCardNumber = 1001;

    public LibraryUser(string userName)
    {
        Name = userName;
        card = new LibraryCard { Number = _nextCardNumber++ };
    }

    public LibraryCard card { get; }

    public void BorrowBook(Book book, Library library)
    {
        library.Borrow(book);
    }

    public void DisplayBorrowedBooks(Library library)
    {
        library.DisplayBorrowed();
    }
}
