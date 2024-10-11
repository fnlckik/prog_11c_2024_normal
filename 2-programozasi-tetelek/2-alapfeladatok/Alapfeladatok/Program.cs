using System;

namespace Alapfeladatok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 5, 7, 2, 2, 9, -1, 4, -3, 9, 3, 2, 1 };
            int n = x.Length;
            // Indexek: 0-tól (n-1)-ig

            // 1. Megszámolás
            // Hány páros elem van?
            int db = 0;
            for (int i = 0; i < n; i++)
            {
                if (x[i] % 2 == 0)
                {
                    db++;
                }
            }
            Console.WriteLine($"1. Párosak száma: {db}");

            // 2. Összegzés
            // Add meg a párosak szorzatát!
            int szorzat = 1;
            for (int i = 0; i < n; i++)
            {
                if (x[i] % 2 == 0)
                {
                    // szorzat = szorzat * x[i]
                    szorzat *= x[i];
                }
            }
            Console.WriteLine($"2. Párosak szorzata: {szorzat}");

            // 3. Maximum-kiválasztás
            int maxi = 0; // maxindex, maximális értékű elem indexe
            int maxe = x[0]; // maxert, maximális érték
            for (int i = 1; i < n; i++)
            {
                if (x[i] > maxe)
                {
                    maxi = i;
                    maxe = x[i];
                }
            }
            Console.WriteLine("3. Legnagyobb elem:");
            Console.WriteLine($"   a) Értéke: {maxe}");
            Console.WriteLine($"   b) Sorszáma: {maxi+1}");

            // 4. Maximum-kiválasztás
            int maxindex = n-1;
            int maxertek = x[n-1];
            for (int i = n-2; i >= 0; i--)
            {
                if (x[i] > maxertek)
                {
                    maxindex = i;
                    maxertek = x[i];
                }
            }
            Console.WriteLine("4. Legnagyobb elem (hátulról):");
            Console.WriteLine($"   a) Értéke: {maxertek}");
            Console.WriteLine($"   b) Sorszáma: {maxindex + 1}");

            Console.ReadKey();
        }
    }
}
