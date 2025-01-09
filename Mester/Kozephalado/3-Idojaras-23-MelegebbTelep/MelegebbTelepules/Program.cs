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
