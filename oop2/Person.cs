using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    internal class Person
    {private string name;
        private int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void printinfo()
        { Console.WriteLine($"name:{name},age:{age}"); }
        public void printinfo( int times)
        {
            for (int i = 0; i < times ; i++)
            {
                Console.WriteLine($" name:{name} ,age :{age}");

            }
            
        }
    }
}
