using System;

namespace AtlagosanLegmeleg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] h = new int[1000, 1000];
            Beolvas(h, out int n, out int m);
            double[] atlagok = AtlagosanLegmelegebb(h, n, m);
            int maxi = Maxhely(atlagok, n);
            Console.WriteLine(maxi + 1);
        }

        static int Maxhely(double[] atlagok, int n)
        {
            int maxi = 0;
            for (int i = 0; i < n; i++)
            {
                if (atlagok[i] > atlagok[maxi])
                {
                    maxi = i;
                }
            }
            return maxi;
        }

        static double[] AtlagosanLegmelegebb(int[,] h, int n, int m)
        {
            double[] atlagok = new double[1000]; // atlagok[i]: i. település (sor) átlaga
            for (int i = 0; i < n; i++)
            {
                int s = 0;
                for (int j = 0; j < m; j++)
                {
                    s += h[i, j];
                }
                double atlag = (double)s / m;
                atlagok[i] = atlag;
            }
            return atlagok;
        }

        static void Beolvas(int[,] h, out int n, out int m)
        {
            string[] sor = Console.ReadLine().Split(' ');
            n = Convert.ToInt32(sor[0]);
            m = Convert.ToInt32(sor[1]);

            for (int i = 0; i < n; i++)
            {
                sor = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    h[i, j] = Convert.ToInt32(sor[j]);
                }
            }
        }
    }
}
