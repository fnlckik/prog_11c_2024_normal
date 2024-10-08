using System;

namespace Deszka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deszka;
            do
            {
                Console.Write("Deszka hossza: ");
                deszka = Convert.ToDouble(Console.ReadLine());
            } while (!(8 <= deszka && deszka <= 18));
            // 8 > deszka || deszka > 18

            double egyseg = deszka / 7;
            Console.WriteLine($"Kb. {2*egyseg:0.00} dm és {5*egyseg:0.00} dm hosszú részekre vágjuk!");

            Console.ReadKey();
        }
    }
}
