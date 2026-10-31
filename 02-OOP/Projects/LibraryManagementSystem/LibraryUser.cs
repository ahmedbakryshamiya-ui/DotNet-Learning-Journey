using System;
using System.Collections.Generic;
using System.Text;

namespace Library_management_system
{
    internal class LibraryUser : User
  
    {
        public LibraryUser(string userName)
        {
            Name = userName;
        }
        public LibraryCard card;
       
        public void BorrowBook(Book book,Library library) 
        {
            library.Borrow(book);
        }
       
    }
}
