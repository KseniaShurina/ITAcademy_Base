using System;
using System.ComponentModel.DataAnnotations;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            User tom = new User("Tom", 35);
            User bob = new User("bob", 16);
            bool tomIsValid = ValidateUser(tom);    // true
            bool bobIsValid = ValidateUser(bob);    // false

            Console.WriteLine($"Реультат валидации Тома: {tomIsValid}");
            Console.WriteLine($"Реультат валидации Боба: {bobIsValid}");
            Console.ReadLine();
        }
        //__________Метод, который принимает объект
        static bool ValidateUser(User user)
        {
            Type t = typeof(User);
            object[] attrs = t.GetCustomAttributes(false);
            foreach (AgeValidationAttribute attr in attrs)
            {
                if (user.Age >= attr.Age) return true;
                else return false;
            }
            return true;
        }
    }
    //____________Атрибут
    public class AgeValidationAttribute : System.Attribute
    {
        public int Age { get; set; }

        public AgeValidationAttribute()
        { }

        public AgeValidationAttribute(int age)
        {
            Age = age;
        }
    }
    //__________Класс к которому мы будем применять атрибут
    [AgeValidation(18)]
    public class User
    {
        [Required]
        public string Id { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
         ErrorMessage = "Characters are not allowed.")]
        public string Name { get; set; }
        [Required]
        [Range(1, 100)]
        public int Age { get; set; }

        public User(string n, int a)
        {
            Name = n;
            Age = a;
        }
    }
}
