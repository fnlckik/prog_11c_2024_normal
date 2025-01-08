using System;

namespace Meleg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            int[,] h = new int[1000, 1000];
            Beolvas(h, out n, out m);
            // h[n-1, m-1]: jobb alsó elem

            //Console.WriteLine(VanEMax(maximum, n, m, h, 0)); // false
            //Console.WriteLine(VanEMax(maximum, n, m, h, 1)); // true
            //Console.WriteLine(VanEMax(maximum, n, m, h, 2)); // true
            int[] melegek = Kivalogatas(h, n, m, out int db);

            Kiir(melegek, db);
        }

        static void Kiir(int[] melegek, int db)
        {
            Console.Write(db + " ");
            for (int i = 0; i < db; i++)
            {
                Console.Write(melegek[i] + 1 + " ");
            }
        }

        static int[] Kivalogatas(int[,] h, int n, int m, out int db)
        {
            int maximum = Maximum(h, n, m);
            int[] melegek = new int[1000];
            db = 0;
            for (int i = 0; i < n; i++)
            {
                if (VanEMax(maximum, m, h, i))
                {
                    melegek[db] = i;
                    db++;
                }
            }
            return melegek;
        }

        // Megadja, hogy az i. sorban (településen) van-e maximális érték?
        static bool VanEMax(int maximum, int m, int[,] h, int i)
        {
            int j = 0;
            while (j < m && !(h[i, j] == maximum))
            {
                j++;
            }
            return j < m;
        }

        static int Maximum(int[,] h, int n, int m)
        {
            int maxe = h[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (h[i, j] > maxe) // h[i, j]: i. sor, j. eleme
                    {
                        maxe = h[i, j];
                    }
                }
            }
            return maxe;
        }

        static void Beolvas(int[,] h, out int n, out int m)
        {
            string[] sor = Console.ReadLine().Split(' '); // {"3", "5"}
            n = Convert.ToInt32(sor[0]); // n sor (település)
            m = Convert.ToInt32(sor[1]); // m oszlop (nap)
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine(); // "10 15 12 10 10"
                sor = s.Split(' '); // {"10", "15", "12", "10", "10"}
                for (int j = 0; j < m; j++)
                {
                    h[i, j] = Convert.ToInt32(sor[j]);
                }
            }
        }
    }
}
