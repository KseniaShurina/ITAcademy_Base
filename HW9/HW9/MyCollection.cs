using System.Collections.Generic;

namespace HW9
{
    public class MyCollection<T>
    {
        public int Length { get { return container.Count; } }
        List<T> container = new List<T>();
        /// <summary>
        /// метод добавления элемента в коллекцию
        /// </summary>
        /// <param name="item">новый элемент</param>
        public void Add(T item)
        {
            container.Add(item);
        }
        /// <summary>
        /// Индексаторы позволяют индексировать объекты и обращаться к данным по индексу
        /// https://metanit.com/sharp/tutorial/4.10.php
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[int index]
        {
            get
            {
                return container[index];
            }
            set
            {
                container[index] = value;
            }

        }
    }
}
