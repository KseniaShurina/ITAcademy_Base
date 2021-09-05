using System;

namespace HW12_delegats_events
{
    public class Subscriber
    {
        private string name;
        int age;

        public Subscriber(string name, int age) //конструктор
        {
            this.name = name;
            this.age = age;
        }

        public void OnMessage(NewsProvider.News type, string message)
        {
            Console.WriteLine($"Подписчик {name} оформил подписку на категорию новостей {type}");
            Console.WriteLine($"{message}");
        }
    }
}
