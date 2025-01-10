using System;

namespace ElozonelHuvosebb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            int[,] matrix = new int[1000, 1000];
            Beolvas(matrix, out n, out m);

            int[] t = Kivalogatas(matrix, n, m, out int db);

            Kiir(t, db);
        }

        static void Beolvas(int[,] matrix, out int n, out int m)
        {
            string[] elsosor = Console.ReadLine().Split(' ');
            n = Convert.ToInt32(elsosor[0]);
            m = Convert.ToInt32(elsosor[1]);
            for (int i = 0; i < n; i++)
            {
                string[] sor = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = Convert.ToInt32(sor[j]);
                }
            }
        }

        static bool VanEH(int[,] matrix, int n, int i)
        {
            int j = 0;
            while (j < n && !(matrix[j, i] < matrix[j, i - 1]))
            {
                j++;
            }
            if (j < n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int[] Kivalogatas(int[,] matrix, int n, int m, out int db)
        {
            int[] tortelidisco = new int[1000];
            db = 0;
            for (int i = 1; i < m; i++) // i. oszlopot (i. nap) nézzük
            {
                if (VanEH(matrix, n, i))
                {
                    tortelidisco[db] = i + 1;
                    db++;
                }
            }
            return tortelidisco;
        }

        static void Kiir(int[] t, int db)
        {
            Console.Write(db + " ");
            for (int i = 0; i < db; i++)
            {
                Console.Write(t[i] + " ");
            }
            Console.WriteLine();
        }
    }
}