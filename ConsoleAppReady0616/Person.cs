using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp20250604
{
    internal class Person:IComparable<Person>
    {
        private int _age;
        public int Age { 
            set => _age = value <= 120 ? value:120;
            get => _age;
        }

        public int Class { set; get; }
        public string Name { set; get; }
        public int add(int a, int b) => a + b;
        //public int add(int a, int b)
        //{
        //    return a + b;
        //}
        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public Person() { }

        public override string? ToString()
        {
            return $"{Name} {Age} {Class}";
        }

        public int CompareTo(Person? other)
        {
            return this.Age - (other?.Age).GetValueOrDefault();
        }
    }
}
