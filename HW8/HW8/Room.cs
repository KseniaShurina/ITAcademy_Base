

namespace HW8
{
    public class Room
    {
        Printer printer;

        public Room()  // конструктор в кот мы соз принтер
        {
            printer = new Printer();
        }

        public void MakeThisLazyPrinterWork(string value)
        {
            printer.Print(value);
        }

        public void SetPrinter(Printer newPrinter) // метод кот меняет принтер
        {
            printer = newPrinter;
        }
    }
}
