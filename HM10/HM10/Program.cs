using System;

namespace HM10
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new MyList();

            myList.Add(new MyItem("asd"));

            foreach (var myItem in myList)
            {
                Console.WriteLine(myItem.Value);
            }
        }
    }
}
