using System;
using System.Collections.Generic;

namespace HW9_2
{
    public class MyCollection<T>
    {
        List<T> group = new List<T>();

        //метод добавления людей в группу
        public void Create(T newPerson) 
        {
            group.Add(newPerson);
        }

        public T this[int index] // индекс
        {   
            get
            {
                return group[index];
            }
            set
            {
                group[index] = value;
            }
        }
    }
}
