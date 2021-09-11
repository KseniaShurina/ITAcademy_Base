using System;

namespace HW13
{
    public class Product
    {
        public string Name { get; set; }
        public string NameStore { get; set; }
        
        public Product(string name, string nameStore)
        {
            Name = name;
            NameStore = nameStore;
        }
        public override string ToString()
        {
            return $"{Name}:{NameStore}";
        }
    }
}
