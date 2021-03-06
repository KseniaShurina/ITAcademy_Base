
using System;

namespace ClassLibrary
{
    public class Library
    {
        /// <summary>
        /// название библиотееки
        /// </summary>
        private string libraryName;

        private Book[] books;  //массив книг

        public Library(string libraryName) //описываем конструктор библиотеки
        {
            books = new Book[0]; // создаём массив книг
            this.libraryName = libraryName;  //задаём название библиотееки
        }

        public void AddBook(string name, int countPages)
        {
            Book book1 = new Book(name, libraryName, countPages);
            Array.Resize(ref books, books.Length + 1);
            books[books.Length - 1] = book1;
        }
        public Book[] GetBooks()
        {
            return books;
        }
        public void BookInfo(int index)
        {
            if (index < 0 || index >= books.Length)
            {
                Console.WriteLine("Вы ввели неверный номер книги");
                return;
            }
            Book book = books[index];
            Console.WriteLine(book.Info());
        }
        public void BookInfoByName(string name)
        {
            foreach (Book book in books)
            {
                if (book.GetName().Equals(name))
                {
                    Console.WriteLine(book.Info());
                    return;
                }
            }
            Console.WriteLine("Вы ввели неверное название книги");
        }
        
    }
}