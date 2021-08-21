using System;

namespace HW8
{
    public class BluePrinter : Printer
    {
        public override void Print(string a)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            base.Print(a);
            Console.ForegroundColor = oldColor;
        }
    }
}
