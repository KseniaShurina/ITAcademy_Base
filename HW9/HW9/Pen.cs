using HW9.Enums;
using System;

namespace HW9
{
    public class Pen
    {
        public Color Color { get; private set; }

        private int lenght;
        public int Lenght
        {
            get { return lenght; }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine($"Длина карандаша не может быть меньше 1");
                    return;
                }
                if (value > lenght)
                {
                    Console.WriteLine($"Карандаш не может быть больше текущей длины {lenght}");
                    return;
                }
                lenght = value;
            }
        }

        public Pen(Color color, int lenght)
        {
            Color = color;
            this.lenght = lenght;
        }
    }
}
