using System;

namespace HW3
{
    class Program
    {
        /*
         S = πr(r + l)

        1. инициализировать r
        2. инициализировать l
        3. 

        */

        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение r: ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение l: ");
            int l = int.Parse(Console.ReadLine());
            double s = Math.PI * r * (r + l);
            Console.WriteLine($"Площадь поверхности круглого консула равна: {s}");

        }
    }
}
