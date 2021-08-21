using System;

namespace HW8
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room = new Room();
            room.MakeThisLazyPrinterWork("sss");

            BluePrinter b = new BluePrinter();
            room.SetPrinter(b);
            room.MakeThisLazyPrinterWork("sss");

            GreenPrinter c = new GreenPrinter();
            room.SetPrinter(c);
            room.MakeThisLazyPrinterWork("sss");
        }
    }
}
