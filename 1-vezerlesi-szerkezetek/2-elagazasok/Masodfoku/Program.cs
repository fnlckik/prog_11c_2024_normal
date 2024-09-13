using System;

namespace Masodfoku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int D = b * b - 4 * a * c;

            if (D > 0)
            {
                Console.WriteLine("2 valós megoldás!");
            }
            else if (D < 0)
            {
                Console.WriteLine("Nincs valós megoldás!");
            }
            else
            {
                Console.WriteLine("1 valós megoldás van!");
            }

            Console.ReadKey();
        }
    }
}
