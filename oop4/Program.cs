namespace oop4
{
    internal class Program
    {
        static void Main(string[] args)
        { Employee emp=new Employee( " yousf mahammed",28,5000 );
           
            Console.WriteLine(" Employee information:");
            emp.print();
            Console.WriteLine("Employee information:");
            emp.print(5);
        }
    }
}
