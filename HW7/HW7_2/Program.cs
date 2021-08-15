using System;

namespace HW7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] nums = new int[3, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            int rows = nums.GetUpperBound(0) + 1;
            int columns = nums.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                int rowMaxValue = nums[i, 0];
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{nums[i, j]} \t");
                    if (nums[i, j] > rowMaxValue)
                    {
                        rowMaxValue = nums[i, j];
                    }
                }
                Console.Write($"\t Максимальное значение строки: {rowMaxValue}");
                Console.WriteLine();
            }
            //Console.Write("Введите элементы 1 массива ");
            //int otherElementsCount = int.Parse(Console.ReadLine());
            //Console.Write("Введите элементы 2 массива ");
            //int otherElementsCount2 = int.Parse(Console.ReadLine());
            //int[,] nums = new int[otherElementsCount, otherElementsCount2];
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int a = 0; a < 2; a++)
            //    {
            //        nums[i, a] = otherElementsCount;
            //        Console.Write("{0}\t", nums[i, a]);
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
