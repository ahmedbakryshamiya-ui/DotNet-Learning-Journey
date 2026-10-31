using System;
using System.Collections.Generic;
using System.Text;

namespace Library_management_system
{
    internal class Library
    {
        private Book[] books = new Book[100];
        private int currentBookcount = 0;
        private Book[] borrowedBooks = new Book[50];
        private int currentBorrowedBookcount = 0;
        public void Display()
        {
            for (int i = 0; i < currentBookcount; i++)
            {
                Console.WriteLine(books[i].Title);
            }
            Console.WriteLine("-----------------------");

        }
        public void Add(Book book)
        {
            if (currentBookcount < books.Length)
            {
                books[currentBookcount] = book;
                currentBookcount++;
                Console.WriteLine("Book added successfully." +
                                  "\n------------------------");

            }
            else
            {
                Console.WriteLine("Library is full. Cannot add more books.");
            }                   
        }
       
           public void Remove(Book book)
        {
            int index = -1;

            for (int i = 0; i < currentBookcount; i++)
            {
                if (books[i].Title == book.Title)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("Book not found." +
                    "\n----------------------------");
                return;
            }

            for (int i = index; i < currentBookcount - 1; i++)
            {
                books[i] = books[i + 1];
            }

            books[currentBookcount - 1] = null;
            currentBookcount--;

            Console.WriteLine("Book removed successfully." +
                              "\n----------------------------");
                              
        }

        public void Borrow(Book book) 
        {
            if (currentBorrowedBookcount < borrowedBooks.Length)
            {
                borrowedBooks[currentBorrowedBookcount] = book;
                currentBorrowedBookcount++;
                Console.WriteLine("Book borrowed successfully." +
                                  "\n----------------------------");
            }
            else
            {
                Console.WriteLine("Sorry, you cannot borrow more books.");
            }
        }
    }
}