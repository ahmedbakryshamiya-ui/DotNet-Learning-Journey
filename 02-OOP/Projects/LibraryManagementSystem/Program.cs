namespace Library_management_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Library System\n" +
                              "---------------------------------------------"+
                              "\nAre you a Librarian or a Regular user(L/R)?");
            Library library = new Library();
            char userType = Console.ReadLine().ToUpper()[0];


            if (userType == 'L')
            {
                // Librarian functionality
                Console.WriteLine("Welcome Librarian,Enter your name:");
                string librarianName = Console.ReadLine();
                Librarian l1 = new Librarian(librarianName);
                Console.WriteLine($"Welcome {l1.Name}");
                while (true)
                {
                    Console.WriteLine("Please select an option:\nAdd Book(A)\nRemove Book(R)\nDisplay Book(D)");
                    char choice = Console.ReadLine().ToUpper()[0];
                    switch (choice)
                    {
                        case 'A':
                            Console.WriteLine("Enter book details:(Title, Author, Year)");
                            string bookName = Console.ReadLine();
                            string bookAuthor = Console.ReadLine();
                            int bookYear = Convert.ToInt32(Console.ReadLine());
                            Book book = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear
                            };
                            l1.AddBook(book, library);
                            break;
                        case 'R':
                            Console.WriteLine("Enter the title of the book you want to remove:");
                            bookName = Console.ReadLine();
                            
                            book = new Book()
                            {
                                Title = bookName,
                                
                            };
                            l1.RemoveBook(book, library);


                            break;
                        case 'D':
                            Console.WriteLine("The book list:");
                            l1.DisplayBooks(library);
                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }
                }
                




            }
            else if (userType == 'R')
            {
                // user functionality
                
                Console.WriteLine("Welcome User,Enter your name:");
                string userName = Console.ReadLine();
                LibraryUser r1 = new LibraryUser(userName);
                Console.WriteLine($"Welcome {r1.Name}");
                while (true)
                {
                    Console.WriteLine("Please select an option:\nBorrow Book(B)\nDisplay Book(D)");
                    char choice = Console.ReadLine().ToUpper()[0];
                    switch (choice)
                    {
                        case 'D':
                            Console.WriteLine("The book list:");
                            r1.DisplayBooks(library);
                            break;

                        case 'B':
                            Console.WriteLine("Enter book details to borrow:(Title, Author, Year)");
                            string bookName = Console.ReadLine();
                            string bookAuthor = Console.ReadLine();
                            int bookYear = Convert.ToInt32(Console.ReadLine());
                            Book book = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear
                            };
                            r1.BorrowBook(book, library);
                            break;
                        
                        default:
                            Environment.Exit(0);
                            break;
                    }
                }


            }
            else
            {
                Console.WriteLine("Please enter correct value (L/R)");
            }
            }
           
        }
        
    }

