using System;
using System.Xml.Schema;

namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] t = { 2, 7, 3 };
            // t[0]
            int[,] matrix = {
              { 8, 3, 21, 4 },
              { 1, -5, 7, 13 },
              { 3, 3, 10, -1 }
            };
            // matrix[0, 0]

            // F1
            Console.WriteLine("1. feladat:");
            Console.WriteLine(matrix[1, 2]); // 2. sor 3. eleme
            Console.WriteLine($"Elemek száma: {matrix.Length}");
            Console.WriteLine($"Sorok száma: {matrix.GetLength(0)}"); // dim1
            Console.WriteLine($"Oszlopok száma: {matrix.GetLength(1)}"); // dim2

            // F2
            Console.WriteLine("\n2. feladat:");
            int n = matrix.GetLength(0); // sorok száma
            int m = matrix.GetLength(1); // oszlopok száma
            for (int i = 0; i < n; i++) // sorok bejárása
            {
                for (int j = 0; j < m; j++) // elemek bejárása
                {
                    if (j == m-1 && i == n-1)
                    {
                        Console.Write(matrix[i, j]); // i. sor j. eleme
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + ", "); // i. sor j. eleme
                    }
                }
                Console.WriteLine();
            }

            // F3
            int osszeg = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    osszeg += matrix[i, j];
                }
            }
            Console.WriteLine($"\n3. feladat: {osszeg}");

            // F3.5
            int[] t = { 5, 7, -3, 2 };
            int maxtombi = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] > t[maxtombi])
                {
                    maxtombi = i;
                }
            }
            Console.WriteLine($"3.5. feladat: {maxtombi+1}");

            // F4
            //int maxi;
            //int maxj;
            //Console.WriteLine($"\n4. feladat: ({maxi+1}, {maxj+1})");
        }
    }
}
