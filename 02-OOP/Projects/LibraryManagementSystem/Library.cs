namespace Library_management_system;

/// <summary>
/// Stores available and borrowed books using bounded arrays.
/// </summary>
internal sealed class Library
{
    private readonly Book?[] books = new Book?[100];
    private int currentBookcount;

    private readonly Book?[] borrowedBooks = new Book?[50];
    private int currentBorrowedBookcount;

    public void Display()
    {
        if (currentBookcount == 0)
        {
            Console.WriteLine("No books are currently available.");
            Console.WriteLine("-----------------------");
            return;
        }

        Console.WriteLine("Available books:");
        for (int i = 0; i < currentBookcount; i++)
        {
            Book book = books[i]!;
            Console.WriteLine($"{i + 1}. {book.Title} — {book.Author} ({book.Year})");
        }

        Console.WriteLine("-----------------------");
    }

    public void DisplayBorrowed()
    {
        if (currentBorrowedBookcount == 0)
        {
            Console.WriteLine("No books have been borrowed.");
            return;
        }

        Console.WriteLine("Borrowed books:");
        for (int i = 0; i < currentBorrowedBookcount; i++)
        {
            Book book = borrowedBooks[i]!;
            Console.WriteLine($"{i + 1}. {book.Title} — {book.Author} ({book.Year})");
        }
    }

    public void Add(Book book)
    {
        if (string.IsNullOrWhiteSpace(book.Title))
        {
            Console.WriteLine("A book title is required.");
            return;
        }

        if (currentBookcount >= books.Length)
        {
            Console.WriteLine("Library is full. Cannot add more books.");
            return;
        }

        if (FindAvailableBookIndex(book.Title) >= 0)
        {
            Console.WriteLine("A book with this title is already available.");
            return;
        }

        books[currentBookcount++] = book;
        Console.WriteLine("Book added successfully.\n------------------------");
    }

    public void Remove(Book requestedBook)
    {
        int index = FindAvailableBookIndex(requestedBook.Title);
        if (index < 0)
        {
            Console.WriteLine("Book not found.\n----------------------------");
            return;
        }

        RemoveAvailableBookAt(index);
        Console.WriteLine("Book removed successfully.\n----------------------------");
    }

    public void Borrow(Book requestedBook)
    {
        int index = FindAvailableBookIndex(requestedBook.Title);
        if (index < 0)
        {
            Console.WriteLine("This book is not currently available.");
            return;
        }

        if (currentBorrowedBookcount >= borrowedBooks.Length)
        {
            Console.WriteLine("The borrowed-book list is full.");
            return;
        }

        Book bookToBorrow = books[index]!;
        borrowedBooks[currentBorrowedBookcount++] = bookToBorrow;
        RemoveAvailableBookAt(index);

        Console.WriteLine("Book borrowed successfully.\n----------------------------");
    }

    private int FindAvailableBookIndex(string title)
    {
        for (int i = 0; i < currentBookcount; i++)
        {
            if (string.Equals(books[i]!.Title, title, StringComparison.OrdinalIgnoreCase))
                return i;
        }

        return -1;
    }

    private void RemoveAvailableBookAt(int index)
    {
        for (int i = index; i < currentBookcount - 1; i++)
            books[i] = books[i + 1];

        books[--currentBookcount] = null;
    }
}
