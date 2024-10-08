using System;

namespace Paritas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0 && b % 2 == 0)
            {
                Console.WriteLine("Mindkettő páros!");
            }
            else if (a % 2 == 0)
            {
                Console.WriteLine("Csak az első páros!");
            }
            else if (b % 2 == 0)
            {
                Console.WriteLine("Csak a második páros!");
            }
            else
            {
                Console.WriteLine("Egyik sem páros!");
            }

            Console.ReadKey();
        }
    }
}
