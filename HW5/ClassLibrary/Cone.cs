using System;

namespace ClassLibrary
{
    /// <summary>
    /// конус
    /// </summary>
    public class Cone
    {
        /// <summary>
        /// радиус
        /// </summary>
        int radius;
        int height;

        public Cone(int r, int h)
        {
            radius = r;
            height = h;
        }
        public string GetInfo()
        {
            return $"Радиус: {radius}  Высота: {height}";
        }
        public double SquareBase()
        {
            var square = Math.PI * Math.Pow(radius, 2);
            return square;
        }
        // πRl+πR2
        public double SquareSurface()
        {
            var l = Math.Sqrt(Math.Pow(radius, 2) + Math.Pow(height, 2));
            var square = Math.PI * radius * l + SquareBase();
            return square;
        }
        public double SquareFull()
        {
            var square = SquareBase() + SquareSurface();
            return square;
        }
    }
}
