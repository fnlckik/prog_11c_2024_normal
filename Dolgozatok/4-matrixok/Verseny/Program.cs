using System;

namespace Verseny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] pontok = new int[200, 30];
            Beolvas(pontok, out int n, out int m);
            Feladat2(pontok, n, m);
            Feladat3(pontok, n, m);
            Feladat4(pontok, n, m);
        }

        static void Feladat4(int[,] pontok, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                int j = 0;
                while (j < m && !(pontok[i, j] < 0))
                {
                    j++;
                }
                if (j < m)
                {
                    Console.Write(i + 1 + " ");
                }
            }
        }

        static void Feladat3(int[,] pontok, int n, int m)
        {
            Console.Write("3. feladat: ");
            for (int i = 0; i < m; i++) // i. oszlop
            {
                int maxj = 0; // Melyik sorban van a legnagyobb elem?
                
                for (int j = 0; j < n; j++) // j. sor
                {
                    if (pontok[j, i] > pontok[maxj, i ])
                    {
                        maxj = j;
                    }
                }
               Console.Write(pontok[maxj, i] + " ");
            }
            Console.WriteLine();
        }

        static void Feladat2(int[,] pontok, int n, int m)
        {
            Console.Write("2. feladat: ");
            for (int i = 0; i < n; i++) // i. sor
            {
                int s = 0;
                for (int j = 0; j < m; j++) // j. oszlop
                {
                    s += pontok[i, j];
                }
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }

        static void Beolvas(int[,] pontok, out int n, out int m)
        {
            string[] sor = Console.ReadLine().Split(' ');
            n = Convert.ToInt32(sor[0]);
            m = Convert.ToInt32(sor[1]);
            for (int i = 0; i < n; i++)
            {
                sor = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    pontok[i, j] = Convert.ToInt32(sor[j]);
                }
            }
        }
    }
}
