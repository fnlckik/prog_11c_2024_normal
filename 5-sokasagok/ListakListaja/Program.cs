using System;
using System.Collections.Generic;

namespace ListakListaja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> gyumolcsok = new List<string> { "alma", "avokádó", "mangó" };
            List<string> zoldsegek = new List<string> { "zeller", "karalábé", "retek", "répa" };

            List<List<string>> etelek = new List<List<string>> { gyumolcsok, zoldsegek };

            // Írjuk ki a "retek" elemet!
            Console.WriteLine($"2. sor 3. eleme: {etelek[1][2]}");

            // Írjuk ki a zöldségeket!
            Console.Write("Zöldségek: ");
            Kiir(etelek[1]);

            // Írjuk ki az ételeket!
            Console.WriteLine("Ételek: ");
            Kiir(etelek);
        }

        static void Kiir(List<List<string>> etelek)
        {
            for (int i = 0; i < etelek.Count; i++) // sorokon végigmegyünk
            {
                for (int j = 0; j < etelek[i].Count; j++) // elemeken végig megyünk (adott sorban)
                {
                    Console.Write(etelek[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Kiir(List<string> lista)
        {
            foreach (string elem in lista)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }
    }
}
