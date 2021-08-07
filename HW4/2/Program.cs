using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 200;
            string str = string.Empty;
            while (i <= 500)
            {
                if (i % 17 == 0)
                {
                    str += $"{i},";
                }
                i++;
            }
            Console.WriteLine(str);
        }
    }
}
