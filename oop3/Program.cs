namespace oop3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            product pr1=new product("tablet",600.0,3 );
            Console.WriteLine($"total cost:{pr1.totalcost()}");
            Console.WriteLine($"total cost :{pr1.totalcost( 200.0, 2)}");
        }
    }
}
