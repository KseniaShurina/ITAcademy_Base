using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace HW17
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = new Stopwatch();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < 100000000; i++)
            {
                cars.Add(new Car(i));
            }

            time.Reset();
            time.Start();
            foreach (Car car in cars)
            {
                car.Age = (343 * 34 * 2 * 77) / 567;
            }
            time.Stop();
            Console.Write("foreach: ");
            Console.WriteLine(new TimeSpan(time.ElapsedTicks));

            time.Reset();
            time.Start();
            for (int i = 0; i < cars.Count; i++)
            {
                cars[i].Age = (343 * 34 * 2 * 77) / 567;
            }
            time.Stop();
            Console.Write("for: ");
            Console.WriteLine(new TimeSpan(time.ElapsedTicks));

            time.Reset();
            time.Start();
            Parallel.For(0, cars.Count, (i) =>
            {
                cars[i].Age = (343 * 34 * 2 * 77) / 567;
            });
            time.Stop();
            Console.Write("Parallel.For: ");
            Console.WriteLine(new TimeSpan(time.ElapsedTicks));

            time.Reset();
            time.Start();
            Parallel.ForEach(cars, car => {car.Age = (343 * 34 * 2 * 77) / 567; });
            time.Stop();
            Console.Write("Parallel.ForEach: ");
            Console.WriteLine(new TimeSpan(time.ElapsedTicks));
        }

    }
}
