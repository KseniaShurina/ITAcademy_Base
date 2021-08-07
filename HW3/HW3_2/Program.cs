using System;

namespace HW3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 14, y = 1, z = 5, w;
            Console.WriteLine($"x = "+ x);
            Console.WriteLine($"y = "+ y);
            Console.WriteLine($"z = "+ z);
            w = x += y - x++ * z;
            Console.WriteLine($"Ответ " + w);
        }
    }
}
