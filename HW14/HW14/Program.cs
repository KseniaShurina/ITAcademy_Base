using HW14.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace HW14
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Bob", 20);
            Console.WriteLine($"{user.Name}, {user.Age}");

            ValidateUserReflection(user);
            ValidateUser(user);
        }

        static bool ValidateUserReflection(User user)
        {
            var t = user.GetType();
            var errors = new List<string>();
            foreach(var prop in t.GetProperties())
            {
                foreach(var attr in Attribute.GetCustomAttributes(prop))
                {
                    if (attr is RegexAttribute attrRegex) {
                        Match m = Regex.Match(prop.GetValue(user).ToString(), attrRegex.Template, RegexOptions.None);

                        if (!m.Success)
                            errors.Add("Не соответствует регулярному выражению");
                    }
                }
            }

            foreach(var error in errors)
            {
                Console.WriteLine(error);
            }

            return errors.Count == 0;
        }

        static bool ValidateUser(User user)
        {
            var context = new ValidationContext(user);// объект кот принимает объект который будет валидироваться
            var results = new List<ValidationResult>(); // лист кот будет добавл в себя ошибки валидации
            // класс Validator вызывает метод TryValidateObject кот принимает
            if (!Validator.TryValidateObject(user, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
                return false;
            }
            return true;
        }
    }
}
