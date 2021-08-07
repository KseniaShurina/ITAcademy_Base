using System;

namespace HW1
{
    class Program
    {

        static void Main(string[] args)
        {
            // говорим, что в программе есть рандом (его надо объявлять только 1 раз)
            Random rnd = new Random();
            // объявляем, что рандом гвоздей составляет от 1 до 10
            int nailsCount = rnd.Next(1, 10);
            // просим красиво вывести количество гвоздей на консоль
            Console.WriteLine("Количество гвоздей: " + nailsCount);

            for (int i = 0; i < nailsCount; i++)
            {
                int hitsNeed = rnd.Next(1, 5);
                Console.WriteLine($"Количество ударов для гвоздя {i + 1} = {hitsNeed}");
                int hits = 0;
                while (hits < hitsNeed)
                {
                    hits++;
                    Console.WriteLine($"Ты сделала удар");
                }
                Console.WriteLine($"Ты забила {i + 1} гвоздь за {hits} ударов");
            }
            Console.WriteLine($"Ты забила все гвозди");
        }

    }
}
