using System;

namespace Dobokocka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            /*
            int n;
            do
            {
                n = r.Next(10, 31);
            } while (n % 2 == 1);
            */
            int n = r.Next(5, 16) * 2;

            int db = 0;
            for (int i = 0; i < n; i++)
            {
                int d1 = r.Next(1, 7);
                int d2 = r.Next(1, 7);
                Console.WriteLine($"{d1} {d2}");
                if (d1 == 6 || d2 == 6)
                {
                    db++;
                }
            }
            Console.WriteLine($"Dobások száma: {n}");
            Console.WriteLine($"{db} alkalommal volt 6-os dobás!");
            double szazalek = (double) db / n * 100;
            Console.WriteLine($"Ez a kísérletek {szazalek:0.00}%-a!");

            Console.ReadKey();
        }
    }
}
