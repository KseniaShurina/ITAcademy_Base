using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace HW18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1: ");
            Point1();
            Console.WriteLine("Задание 2: ");
            Point2();
            Console.WriteLine("Задание 3: ");
            Point3();
            Console.WriteLine("Задание 4: ");
            Point4();
        }

        /// <summary>
        /// a. Дан символ "<любой, сами решите>" и строка с текстом.
        /// Найти слово, которое заканчивается на данный символ.
        /// Если слова нет, то долно вернуться null.
        /// Если больше одного -> исключение.
       /// </summary>
        public static void Point1()
        {
            var text = "Привет. Меня зовут Ксюша и я учу С#";
            var endChar = 'а';

            var words = text
                .Split(" ")
                .Select(i => Regex.Replace(i.Trim(), @"[^0-9a-zA-ZА-Яа-я]+", ""))
                .Where(i => i.Length > 0 && i.EndsWith(endChar))
                .ToArray();

            var word = words.SingleOrDefault();
            Console.WriteLine($"Слово {word} заканчивается на букву {endChar}");
        }

        /// <summary>
        /// b. Дано [5,8,0,-1,6,4,-1,-3]. 
        /// Найти количество ее положительных элементов, а также их среднее значение.
        /// </summary>
        public static void Point2()
        {
            var data = new [] { 5, 8, 0, -1, 6, 4, -1, -3 };

            var dataPositive = data.Where(i => i > 0).ToArray();

            var count = dataPositive.Length;
            var sum = dataPositive.Sum();

            Console.WriteLine($"Кол-во: {count}");
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Ср знач: {sum / count}");
        }

        public static void Point3()
        {
            var str = "Женя скоро будет свободен, а у вас все только начинается";
            var delChar = 'о';
            var strNew = new string(str.ToCharArray().Where(i =>i != delChar).ToArray());

            Console.WriteLine(str);
            Console.WriteLine($"Удаляем все {delChar}...");
            Console.WriteLine(strNew);
        }

        public class Car
        {
            public string BrandName { get; set; }

            public string Model { get; set; }
        }

        public class CarBrand
        {
            public string Name { get; set; }

            public string Description { get; set; }
        }


        public static void Point4()
        {
            var brands = new CarBrand[]
            {
                new CarBrand() { Name = "Audi", Description = "Фирма Audi была придумана и тд..." },
                new CarBrand() { Name = "Bmw", Description = "Фирма BMW была придумана и тд..." },
            };

            var carsAll = new Car[]
            {
                new Car() {BrandName = "Audi", Model = "A1"},
                new Car() {BrandName = "Audi", Model = "A2"},
                new Car() {BrandName = "Audi", Model = "A3"},
                new Car() {BrandName = "Audi", Model = "A4"},
                new Car() {BrandName = "Audi", Model = "A5"},
                new Car() {BrandName = "Bmw", Model = "Ser 1"},
                new Car() {BrandName = "Bmw", Model = "Ser 2"},
                new Car() {BrandName = "Bmw", Model = "Ser 3"},
            };

            var cars = carsAll
                .Join(brands, c => c.BrandName, b => b.Name, (c, b) => new
                {
                    Car = c,
                    Brand = b
                })
                .ToArray();

            var carBmw = cars.Where(i => i.Brand != null && i.Brand.Name == "Bmw").ToArray();

            // Выводим все BMW
            foreach (var car in carBmw)
            {
                Console.WriteLine(car.Car.Model);
            }

            carBmw = carBmw.OrderBy(i => i.Car.Model).Take(2).Skip(1).ToArray();
            foreach (var car in carBmw)
            {
                Console.WriteLine(car.Car.Model);
            }
        }
    }
}
