namespace oop1
{
    internal class Program
    {
        static void Main(string[] args)
        { Calculator conunt=new Calculator();
            conunt.add(2, 2);
            conunt.add(3, 3,5);
            Console.WriteLine(" SUM of two num" + conunt.add(2,2));
            Console.WriteLine(" SUM of three num"+conunt.add(3,3,5));
        }
    }
}
