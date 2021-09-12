using HW14.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HW14
{
    public class User
    {
        //[StringLength(15, MinimumLength = 3, ErrorMessage = "Недопустимая длина имени")]
        [Regex("^[A-Z]{1}[a-z]{1,20}$")]
        [RegexValidation("^[A-Z]{1}[a-z]{1,20}$", ErrorMessage ="Имя не соответствует регулярному выражению")]
        public string Name { get; set; }

        [Range(1,100, ErrorMessage = "Недопустимый возраст")]
        public int Age { get; set; }

        public User(string name, int age)
        {
            Name = name;
            Age = age;

            
        }
    }
}
