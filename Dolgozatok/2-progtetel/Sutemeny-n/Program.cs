using System;

namespace Sutemeny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // F1
            string[] osztalyok = new string[20];
            int[] kostolok = new int[20];
            double[] pontok = new double[20];
            int n = Convert.ToInt32(Console.ReadLine());
            int i;
            for (i = 0; i < n; i++)
            {
                string sor = Console.ReadLine();
                string[] adatok = sor.Split(' ');
                osztalyok[i] = adatok[0];
                kostolok[i] = Convert.ToInt32(adatok[1]);
                pontok[i] = Convert.ToDouble(adatok[2]);
            }

            // F2
            int db = 0;
            for (i = 0; i < n; i++)
            {
                if (kostolok[i] == 45)
                {
                    db++;
                }
            }
            Console.WriteLine($"2. feladat: {db}");

            // F3
            int maxi = 0;
            for (i = 0; i < n; i++)
            {
                if (pontok[i] > pontok[maxi])
                {
                    maxi = i;
                }
            }
            Console.WriteLine($"3. feladat: {osztalyok[maxi]}");

            // F4
            i = 0;
            while (i < n && !(pontok[i] < 1 && kostolok[i] > 40))
            {
                i++;
            }
            if (i < n)
            {
                Console.WriteLine($"4. feladat: {osztalyok[i]}");
            }
            else
            {
                Console.WriteLine("4. feladat: -");
            }

            // F5
            int s = 0;
            for (i = 0; i < n; i++)
            {
                s += kostolok[i];
            }
            Console.WriteLine($"5. feladat: {(double)s / n:0.00}");
        }
    }
}
