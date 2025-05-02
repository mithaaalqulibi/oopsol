using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4
{
    internal class Employee
    {
        public string Name { get; set; }
        public int age { get; set; }
        public double salery { get; set; }
        public Employee(string Name, int age, double salery)
        {
            this.Name = Name;
            this.age = age;
            this.salery = salery;
        }
        public void print()
        {
            Console.WriteLine($" employee Name :{Name}");
            Console.WriteLine($" employee age:{age}");
            Console.WriteLine($"employee salery{salery}");

        }
        public void print(int time)
        {
            for (int i = 0; i < time; i++)
            {
                Console.WriteLine($"Name:{Name}");
                Console.WriteLine($"Age:{age}");
                Console.WriteLine($"Salery;{salery}");
            }
        }
    }
}   
