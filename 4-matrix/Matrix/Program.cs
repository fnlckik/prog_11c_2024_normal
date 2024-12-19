using System;

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
            Console.WriteLine(matrix[1, 2]); // 2. sor 3. eleme
            Console.WriteLine($"Elemek száma: {matrix.Length}");
            Console.WriteLine($"Sorok száma: {matrix.GetLength(0)}"); // dim1
            Console.WriteLine($"Oszlopok száma: {matrix.GetLength(1)}"); // dim2

            // F2
            for (int i = 0; i < matrix.GetLength(0); i++) // sorok bejárása
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // elemek bejárása
                {
                    Console.WriteLine(matrix[i, j]); // i. sor j. eleme
                }
            }
        }
    }
}
