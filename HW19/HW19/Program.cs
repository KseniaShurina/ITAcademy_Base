using System;
using System.Threading.Tasks;

namespace HW19
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Consistently
            await Print("asd", 2);
            await Print("fff", 2);

            // Parallel
            await Task.WhenAll(Print("asd2", 2), Print("fff2", 2));
        }

        public static async Task Print(string str, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(str);
                await Task.Delay(100);
            }
        }
    }
}
