namespace ClassLibrary
{
    public class Book
    {
        private string name;
        private string libraryName;
        private int countPages;

        /// <summary>
        /// описываем конструктор и книгу (что есть в книге)
        /// </summary>
        public Book(string name, string libraryName, int countPages)
        {
            this.name = name;
            this.libraryName = libraryName;
            this.countPages = countPages;
        }
        /// <summary>
        /// описываем метод, который возвращает информацию о книге
        /// </summary>
        /// <returns></returns>
        public string Info() 
        {
            string result = $"Название книги: {name} Название библиотеки:{libraryName} Количество страниц: {countPages}";
            return result;
        }
        public string GetName()
        {
            return name;
        }
        public int GetCountPages()
        {
            return countPages;
        }
    }
}
