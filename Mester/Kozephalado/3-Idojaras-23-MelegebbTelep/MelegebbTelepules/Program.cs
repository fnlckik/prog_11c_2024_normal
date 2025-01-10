using System;

namespace MelegebbTelepules
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            int[,] h = new int[1000, 1000];
            Beolvas(h, out n, out m);

            // Keressük meg az első 18-nál nagyobb hőmérsékletet!
            //Console.WriteLine(Keres18Nagyobb(h, n, m)); // 20

            // Írjuk ki az (a, b) számpárokat, ahol a<b. k-ig tegyük meg!
            // (1, 2), (1, 3), (1, 4), (2, 3), (2, 4), (3, 4)
            /*
            for (int i = 1; i <= 3; i++)
            {
                for (int j = i+1; j <= 4; j++)
                {
                    Console.Write($"({i}, {j})\t");
                }
            }
            */

            // Írjuk ki az (a, b) számpárokat, ahol a<b. k-ig tegyük meg!
            // (1, 1), (1, 2), (1, 3), (1, 4), (2, 1), (2, 2), (2, 3), ...
            /*
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write($"({i}, {j})\t");
                }
            }
            */

            // i. sor VS j. sor
            /*
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (MelegebbE(h, m, i, j))
                    {
                        Console.WriteLine(i+1);
                    }
                    //Console.WriteLine($"{i+1} {j+1} {MelegebbE(h, m, i, j)}\t");
                }
            }
            */

            // Keressünk olyan i. települést, amely melegebb valamely j. településnél!
            int i = MasnalMelegebb(h, n, m);
            Console.WriteLine(i);
        }

        static int MasnalMelegebb(int[,] h, int n, int m)
        {
            int i = 0;
            int j = 0;
            bool megvanE = false;
            while (i < n && !megvanE)
            {
                j = 0;
                while (j < n && !megvanE)
                {
                    megvanE = MelegebbE(h, m, i, j);
                    j++;
                }
                i++;
            }
            if (megvanE)
            {
                return i; // 2
            }
            else
            {
                return -1;
            }
        }

        // Igaz-e, hogy az i. település melegebb a j. településnél?
        static bool MelegebbE(int[,] h, int m, int i, int j)
        {
            int k = 0; // k. napot nézzük
            while (k < m && (h[i, k] > h[j, k]))
            {
                k++;
            }
            return !(k < m);
        }

        static int Keres18Nagyobb(int[,] h, int n, int m)
        {
            // Mit keresünk? h[i, j] > 18
            bool megvanE = false;
            int i = 0;
            int j = 0;
            while (i < n && !megvanE)
            {
                j = 0;
                while (j < m && !megvanE)
                {
                    //if (h[i,j] > 18)
                    //{
                    //    megvanE = true;
                    //}
                    megvanE = h[i, j] > 18;
                    j++;
                }
                i++;
            }

            if (megvanE)
            {
                return h[i-1, j-1]; // h[2, 5] => h[1, 4]
            }
            else
            {
                return -1;
            }
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
