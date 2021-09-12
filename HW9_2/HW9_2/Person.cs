using System;

namespace HW9_2
{
    public class Person
    {
        public string name;
        public int age;
        public Sex sex;
        public enum Sex
        {
            men,
            women,
            other,
        }
        public Person(string name, int age, Sex sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }
        public static void PersonInfo(Person person)
        {
            Console.WriteLine($"Name: {person.name}, age: {person.age}, sex: {person.sex}");
        }
    }
}
