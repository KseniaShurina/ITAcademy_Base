using System;

namespace HW9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCollection<Person> group = new MyCollection<Person>();
            Create("Di", 23, Person.Sex.women);
            Person person1 = new Person("Kate", 20, Person.Sex.women);
            MyCollection<Person> person2 = MyCollection<Person>.Create("Di", 23, Person.Sex.women);
            Person.PersonInfo(person1);
        }
    }
}
    