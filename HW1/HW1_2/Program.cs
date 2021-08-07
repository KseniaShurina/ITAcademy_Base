using System;

namespace HW1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nailsCount = 0;

            while (nailsCount < 1 || nailsCount > 10)
            {
                Console.Write("Введите количество гвоздей: ");
                nailsCount = Convert.ToInt32(Console.ReadLine());
            }

            int[] nails = new int[nailsCount];
            // Определяем количество ударов
            for (int n = 0; n < nailsCount; n++)
            {
                nails[n] = 5;
                Console.WriteLine($"Количество ударов для {n + 1} гвоздя - {nails[n]}");
            }


            for (int n = 0; n < nailsCount; n++)
            {
                int hits = 0;
                while (hits < nails[n])
                {
                    hits++;
                    Console.WriteLine($"Ты сделала удар");
                }

                Console.WriteLine($"Ты забила 1 гвоздь");

            }

            Console.WriteLine($"Ты забила все гвозди");

            Console.ReadLine();
        }
    }
}