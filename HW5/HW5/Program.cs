using ClassLibrary;
using System;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[] { 1, 2, 3 };

            var mas2 = ArrayWorker.Inverse(mass);
            var mas3 = ArrayWorker.Insert(mass, 1, 4);
            Console.WriteLine("Первый массив: ");
            MassToConsole(mass);

            Console.WriteLine("Второй массив: ");
            MassToConsole(mas2);

            Console.WriteLine("Третий массив: ");
            MassToConsole(mas3);



            var cone = new Cone(3, 4);
            Console.WriteLine(cone.GetInfo());
            Console.WriteLine(cone.SquareFull());
        }
        static void MassToConsole(int[] mass)
        {
            foreach (int i in mass)
            {
                Console.WriteLine(i);
            }
        }
    }
}
