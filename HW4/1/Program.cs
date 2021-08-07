using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = GetIntFromConsole();


            if (number > 0 & number < 30)
            {
                Console.WriteLine($"Число {number} попадает в промежуток от 0 до 30");
            }
            else if (number > 31 & number < 60)
            {
                Console.WriteLine($"Число {number} попадает в промежуток от 31 до 60");
            }
            else if (number > 61 & number < 100)
            {
                Console.WriteLine($"Число {number} попадает в промежуток от 61 до 100");
            }
            else
            {
                Console.WriteLine($"Число {number} неизвестно");
            }
        }

        static int GetIntFromConsole()
        {
            bool result;
            int i;
            do
            {
                Console.Write("Введите число ");
                string a = Console.ReadLine();
                result = int.TryParse(a, out i);
                if (!result)
                {
                    Console.WriteLine($"Вы ввели некорректное число");
                }
            }
            while (!result);
            return i;
        }
    }
}
