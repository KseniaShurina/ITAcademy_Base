using System;
using System.Collections.Generic;

namespace HW13
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[5];
            products[0] = new Product("milk", "Almi");
            products[1] = new Product("coffee", "Almi");
            products[2] = new Product("sugar", "Prostore");
            products[3] = new Product("vodca", "Evroopt");
            products[4] = new Product("juce", "Green");

            for (int i = 0; i < products.Length; i++)
                Console.WriteLine("{0}. {1}", i + 1, products[i]);

            for (int i = 0; i < products.Length; i++)
            {
                for (int j = 0; j < products.Length - 1; j++) 
                { 
                
                    if (string.Compare(products[j].NameStore, products[j + 1].NameStore) > 0)
                    {
                        var s = products[i];
                        products[i] = products[j + 1];
                        products[j + 1] = s;
                    }
                }
            }

            Console.WriteLine("Введите название магазина: ");
            string nameStore = Console.ReadLine().ToUpper();

            List<Product> foundProducts = new List<Product>();
            foreach (Product i in products)
            {
                if (nameStore == i.NameStore.ToUpper())
                {
                    
                    foundProducts.Add(i);
                }
            }

            if(foundProducts.Count == 0)
            {
                Console.WriteLine($"Магазин {nameStore} не найден");
            }

            foreach(Product a in foundProducts)
            {
                Console.WriteLine(a);
            }
        }
    }
}
