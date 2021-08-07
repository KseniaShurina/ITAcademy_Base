using System;

namespace ClassLibrary
{
    public static class ArrayWorker
    {
        public static int[] Inverse(int[] mass)
        {
            int[] massCopy = new int[mass.Length];
            for (int i = 0; i < mass.Length; i++)
            {
                massCopy[i] = mass[i];
            }

            Array.Reverse(massCopy);
            return massCopy;
        }

        public static int[] Insert(int[] source, int index, int newValue)
        {
            int i = 0;
            int c = 0;
            int[] massCopy = new int[source.Length + 1];
            while (i < massCopy.Length)
            {
                if (i == index)
                {
                    massCopy[i] = newValue;
                }
                else 
                {
                    massCopy[i] = source[c];
                    c++;
                }
                i++;
            }
            return massCopy;
        }

    }
}
