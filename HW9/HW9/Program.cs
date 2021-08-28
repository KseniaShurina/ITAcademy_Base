using System;

namespace HW9
{
    class Program
    {
        static void Main(string[] args)
        {
            PenFactory factory = new PenFactory(10);
            MyCollection<Pen> box1 = factory.CreatePenBox();
            Console.WriteLine($"Коробка {box1} содержит {box1.Length} карандашей:");
            for (int index = 0; index < box1.Length; index++)
            {
                PenInfo(box1[index]);
            }
        }
        public static void PenInfo(Pen pen)
        {
            Console.WriteLine($"Карандаш цвета {pen.Color} и размера {pen.Lenght}");
        }
    }
}
