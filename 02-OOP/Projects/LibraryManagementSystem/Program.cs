namespace Library_management_system;

internal static class Program
{
    private static void Main()
    {
        Library library = new();

        while (true)
        {
            Console.WriteLine("\nLibrary Management System");
            Console.WriteLine("-------------------------");
            Console.Write("Are you a Librarian or a Regular user (L/R), or Q to quit? ");
            char role = ReadChoice();

            switch (role)
            {
                case 'L':
                    RunLibrarianMenu(library);
                    break;
                case 'R':
                    RunRegularUserMenu(library);
                    break;
                case 'Q':
                    return;
                default:
                    Console.WriteLine("Please enter L, R, or Q.");
                    break;
            }
        }
    }

    private static void RunLibrarianMenu(Library library)
    {
        Console.Write("Enter your name: ");
        Librarian librarian = new(ReadRequiredText());

        while (true)
        {
            Console.WriteLine("\nLibrarian menu: A) Add book  R) Remove book  D) Display books  B) Back");
            switch (ReadChoice())
            {
                case 'A':
                    librarian.AddBook(ReadBookDetails(), library);
                    break;
                case 'R':
                    Console.Write("Enter the title to remove: ");
                    librarian.RemoveBook(new Book { Title = ReadRequiredText() }, library);
                    break;
                case 'D':
                    librarian.DisplayBooks(library);
                    break;
                case 'B':
                    return;
                default:
                    Console.WriteLine("Choose A, R, D, or B.");
                    break;
            }
        }
    }

    private static void RunRegularUserMenu(Library library)
    {
        Console.Write("Enter your name: ");
        LibraryUser user = new(ReadRequiredText());
        Console.WriteLine($"Welcome {user.Name}. Your library card number is {user.card.Number}.");

        while (true)
        {
            Console.WriteLine("\nUser menu: D) Display available books  B) Borrow by title  V) View borrowed books  Q) Back");
            switch (ReadChoice())
            {
                case 'D':
                    user.DisplayBooks(library);
                    break;
                case 'B':
                    Console.Write("Enter the title of the book to borrow: ");
                    user.BorrowBook(new Book { Title = ReadRequiredText() }, library);
                    break;
                case 'V':
                    user.DisplayBorrowedBooks(library);
                    break;
                case 'Q':
                    return;
                default:
                    Console.WriteLine("Choose D, B, V, or Q.");
                    break;
            }
        }
    }

    private static Book ReadBookDetails()
    {
        Console.Write("Book title: ");
        string title = ReadRequiredText();

        Console.Write("Book author: ");
        string author = ReadRequiredText();

        int year = ReadInteger("Publication year: ", 0, DateTime.Now.Year);

        return new Book
        {
            Title = title,
            Author = author,
            Year = year
        };
    }

    private static string ReadRequiredText()
    {
        while (true)
        {
            string value = Console.ReadLine()?.Trim() ?? string.Empty;
            if (!string.IsNullOrWhiteSpace(value))
                return value;

            Console.Write("This value is required. Try again: ");
        }
    }

    private static int ReadInteger(string prompt, int minimum, int maximum)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int value) &&
                value >= minimum && value <= maximum)
            {
                return value;
            }

            Console.WriteLine($"Enter a whole number from {minimum} to {maximum}.");
        }
    }

    private static char ReadChoice()
    {
        string input = Console.ReadLine()?.Trim() ?? string.Empty;
        return input.Length == 0 ? '\0' : char.ToUpperInvariant(input[0]);
    }
}
