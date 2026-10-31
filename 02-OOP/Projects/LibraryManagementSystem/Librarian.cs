using System;
using System.Collections.Generic;
using System.Text;

namespace Library_management_system
{
    internal class Librarian : User
    {
        public Librarian(string name)
        {
            Name = name;
        }
        public int EmployeeNumber { get; set; }
        public void AddBook(Book newbook , Library library)
        {
            library.Add(newbook);
        }
        public void RemoveBook(Book book, Library library) 
        {
            library.Remove(book);
        }

    }
}
