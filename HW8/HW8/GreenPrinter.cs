using System;

namespace HW8
{
    public class GreenPrinter : Printer
    {
        public override void Print(string a)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            base.Print(a);
            Console.ForegroundColor = oldColor;
        }
    }
}
