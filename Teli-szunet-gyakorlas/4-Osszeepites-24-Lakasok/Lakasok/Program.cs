using System;

namespace Lakasok
{
    internal class Program
    {
        static void Beolvas(out int n, int[] alapteruletek, int[] arak)
        {
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] sor = Console.ReadLine().Split(' ');
                alapteruletek[i] = Convert.ToInt32(sor[0]);
                arak[i] = Convert.ToInt32(sor[1]);
            }
        }

        static bool Eleme(int e, int k, int[] x)
        {
            int i = 0;
            while (i < k && !(e == x[i]))
            {
                i++;
            }
            return i < k;
        }

        static int Megszamol(int n, int[] alapteruletek)
        {
            int db = 0;
            for (int i = 0; i < n; i++)
            {
                // Ha nem volt még korábban az aktuális terület
                if (!Eleme(alapteruletek[i], i, alapteruletek))
                {
                    db++;
                }
            }
            return db;
        }

        static void Main(string[] args)
        {
            int[] alapteruletek = new int[100];
            int[] arak = new int[100];
            Beolvas(out int n, alapteruletek, arak);
            int db = Megszamol(n, alapteruletek);
            Console.WriteLine(db);
        }
    }
}
