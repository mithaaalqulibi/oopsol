using System.ComponentModel;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle re = new Rectangle(11, 6);
            re.area1();
            re.area2( 5,2);
            Console.WriteLine( $"area " + re.area1());
            Console.WriteLine($" area"+re.area2(5,2));

        }
    }
}
