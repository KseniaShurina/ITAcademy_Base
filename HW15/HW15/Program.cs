using System;

namespace HW15
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\Users\Xeni\Projects\HW15\Новая папка\Новая папка (2)";
            Console.WriteLine("Введите путь");
            var path = Console.ReadLine();

            //var fileName = "file.txt";
            Console.WriteLine("Введите название файла");
            var fileName = Console.ReadLine();


            //FileSearch.FoundFiles(fileName, path);
            var res = FileSearch.FoundFiles(fileName, path);

            if (res.Count == 0)
            {
                throw new CustomFileNotFoundException("Файл не найден");
            }
            Compress.ZipMethod(res[0], res[0] + ".zip");

            Console.ReadKey();
        }

       
    }
}
