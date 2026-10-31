using System;
using System.Collections.Generic;
using System.Text;

namespace Library_management_system
{
    internal abstract class User 
    {
        public string Name { get; set; }
        public void DisplayBooks(Library library)
        {
            library.Display();
        }
    }
}
