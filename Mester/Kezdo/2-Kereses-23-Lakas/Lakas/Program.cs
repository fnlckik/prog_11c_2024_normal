using System;

namespace Lakas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Deklaráció
            int n, meret, ar;
            int[] arak = new int[100];
            int[] meretek = new int[100];

            // Beolvasás
            string elsosor = Console.ReadLine(); // "4 30 10"
            string[] darabolt = elsosor.Split(' '); // { "4", "30", "10" }
            n = Convert.ToInt32(darabolt[0]);
            meret = Convert.ToInt32(darabolt[1]);
            ar = Convert.ToInt32(darabolt[2]);

            int i;
            for (i = 0; i < n; i++)
            {
                string sor = Console.ReadLine(); // "10 45"
                string[] adatok = sor.Split(' '); // { "10", "45" }
                arak[i] = Convert.ToInt32(adatok[0]);
                meretek[i] = Convert.ToInt32(adatok[1]);
            }

            // Feldolgozás - Keresés
            i = 0;
            while (i < n && !(arak[i] > ar && meretek[i] > meret))
            {
                i++;
            }

            // Kiírás
            if (i < n)
            {
                Console.WriteLine(i+1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
