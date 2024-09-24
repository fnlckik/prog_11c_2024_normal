using System;

namespace Telefon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Írjuk ki n-szer, hogy "Nem mobilozok az iskolában."
            // a1) For ciklussal
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i+1}. Nem mobilozok az iskolában.");
            }

            //Console.WriteLine();
            /*
                \n => new line (sortörés)
                \t => tabulator
            */
            Console.Write("\n");

            // a2) For ciklussal
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\t{i:00}. Nem mobilozok az iskolában.");
            }

            Console.WriteLine();

            // b) While ciklussal
            int j = 1;
            while (j <= n)
            {
                Console.WriteLine($"{j}. Nem mobilozok az iskolában.");
                j++;
            }

            Console.ReadKey();
        }
    }
}
