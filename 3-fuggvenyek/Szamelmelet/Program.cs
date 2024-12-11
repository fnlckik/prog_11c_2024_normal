using System;

namespace Szamelmelet
{
    internal class Program
    {
        // 1. Helyes-e?
        // 2. Szép-e? (tiszta kód)
        // 3. Hatékony-e? (tudjuk-e gyorsabban)

        /*
        if (d <= n-1) // találtunk osztót
        {
            return false;
        }
        else
        {
            return true;
        } 
        */
        // !(d <= n-1) nem igaz, hogy találtam osztót
        // d > n-1 nem találtam osztót
        static bool PrimE(int n)
        {
            if (n < 2) return false;
            int d = 2;
            while (d <= Math.Sqrt(n) && !(n % d == 0))
            {
                d++;
            }
            return d > Math.Sqrt(n);
        }

        static int[] Primszamok(int[] x, out int db)
        {
            int[] y = new int[1000]; // ebbe válogatom ki
            db = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (PrimE(x[i]))
                {
                    y[db] = x[i]; // y.append(x[i])
                    db++;
                }
            }
            return y;
        }

        static void Kiir(int[] x, int db)
        {
            Console.WriteLine("Prímszámok: ");
            for (int i = 0; i < db; i++)
            {
                Console.Write(x[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            /*
            Console.WriteLine(PrimE(17)); // True
            Console.WriteLine(PrimE(35)); // False
            Console.WriteLine(PrimE(2)); // True
            Console.WriteLine(PrimE(1)); // False
            Console.WriteLine(PrimE(-12)); // False
            */

            // F8 - Prímszámok
            int[] primek = Primszamok(new int[] { 7, 23, 6, 42, 73, 2, 3, 9, 1, 5 }, out int db);
            Kiir(primek, db);

            // F9 - SokOsztos
            //Console.WriteLine(OsztokSzama(6)); // 4
            //Console.WriteLine(OsztokSzama(1001)); // 8
            //Console.WriteLine(OsztokSzama(360)); // 24
            Console.WriteLine("alma");
        }
    }
}
