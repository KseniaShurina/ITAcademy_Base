using ClassLibrary;
using System;

namespace HW6.Extensions
{
    public static class LibraryExtensions
    {
        public static void BookMaxSize(this Library library)
        {
            int maxSize = 0;
            int index = -1;
            for (int i = 0; i < library.GetBooks().Length; i++)
            {
                int pages = library.GetBooks()[i].GetCountPages();
                if (pages > maxSize)
                {
                    maxSize = pages;
                    index = i;
                }
            }
            if (index > -1)
            {
                Console.WriteLine("Самая большая книга: ");
                library.BookInfo(index);
            }
            else
            {
                Console.WriteLine("В библиотеке нету книг");
            }
        }
    }
}
