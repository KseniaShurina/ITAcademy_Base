 using System;
using ClassLibrary;
using HW6.Extensions;

namespace HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library("library");
            library.AddBook("HT", 200);
            library.AddBook("JY", 1000000);
            library.AddBook("LG", 50);

            library.BookInfo(1);
            library.BookInfoByName("LG");
            library.BookMaxSize();
        }
        
    }
}
