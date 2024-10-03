using System;

namespace HaromKocka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int osszeg;
            do
            {
                int d1 = r.Next(1, 7);
                int d2 = r.Next(1, 7);
                int d3 = r.Next(1, 7);
                osszeg = d1 + d2 + d3;
                Console.WriteLine($"{d1} {d2} {d3} {osszeg}");
            } while (!(osszeg < 6 || osszeg > 15));

            Console.ReadKey();
        }
    }
}
