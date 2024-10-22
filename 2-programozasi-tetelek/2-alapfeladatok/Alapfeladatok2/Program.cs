using System;

namespace Alapfeladatok2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 5, 7, 2, 2, 9, -1, 4, -3, 9, 3, 2, 1 };
            int n = x.Length; // 12

            // 4. Eldöntés
            // Van-e benne negatív elem?
            // !(x[i] < 0) helyett: x[i] >= 0
            int i = 0;
            while (i < n && !(x[i] < 0))
            {
                i++;
            }

            if (i < n)
            {
                Console.WriteLine("4. Van benne negatív elem!");
            }
            else
            {
                Console.WriteLine("4. Nincs benne negatív elem!");
            }

            // 5. Kiválasztás => Nagyon ritkán használjuk!
            // !(x[j]) == 9 helyett: x[j] != 9
            int j = 0;
            while (!(x[j] == 9))
            {
                j++;
            }
            Console.WriteLine($"5. Az első 9-es sorszáma: {j+1}");

            // 6. Keresés (lineáris keresés)
            int k = 0;
            while (k < n && !(x[k] % 2 == 0))
            {
                k++;
            }
            if (k < n)
            {
                Console.WriteLine("6. Az első páros szám:");
                Console.WriteLine($"   a) Sorszáma: {k+1}");
                Console.WriteLine($"   b) Értéke: {x[k]}");
            }
            else
            {
                Console.WriteLine("6. Nincs a tömbben páros szám!");
            }

            Console.ReadKey();
        }
    }
}
