using System;

namespace Hatvany2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Alap: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kitevő: ");
            int k = Convert.ToInt32(Console.ReadLine());

            // A kitevő abszolútértéke
            // Egy változónak akarunk értéket adni
            // egy feltételtől függően => ternary operator ?:
            /*
            int n;
            if (k > 0)
            {
                n = k;
            }
            else
            {
                n = -k;
            }
            */
            int n = k > 0 ? k : -k;

            double hatvany = 1;
            for (int i = 0; i < n; i++)
            {
                hatvany *= a;
            }

            if (k < 0)
            {
                hatvany = 1 / hatvany;
            }

            Console.WriteLine($"Hatvány: {hatvany}");

            Console.ReadKey();
        }
    }
}
