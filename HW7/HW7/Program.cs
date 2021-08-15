using System;

namespace HW7
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write($"Введите количесвто элементов массива ");
            int elementsCount = int.Parse(Console.ReadLine());
            int[] thisElements = new int[elementsCount];
            for(int i = 0; i < thisElements.Length; i++)
            {
                Console.Write($"Введите {i} элемент массива: ");
                thisElements[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Элементы массива: ");
            for (int i = 0; i < thisElements.Length; i++)
            {
                Console.Write(thisElements[i] + " ");
            }
            Console.Write("\nПеревёрнутый массив: ");
            for (int i = thisElements.Length -1; i>= 0; i--)
            {
                Console.Write(thisElements[i] + " ");
            }
        }
    }
}
