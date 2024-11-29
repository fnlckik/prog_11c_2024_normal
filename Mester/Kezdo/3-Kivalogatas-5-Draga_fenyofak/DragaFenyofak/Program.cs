using System;

namespace DragaFenyofak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Deklaráció
            int n, k;
            int[] arak = new int[100];

            // Beolvasás
            string elsosor = Console.ReadLine(); // "6 5000"
            string[] darabok = elsosor.Split(' '); // { "6", "5000" }
            n = Convert.ToInt32(darabok[0]);
            k = Convert.ToInt32(darabok[1]);

            int i;
            for (i = 0; i < n; i++)
            {
                arak[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Feldolgozás - Kiválogatás
            // Emlék: python
            // dragak.append(i)
            int[] dragak = new int[100]; // { 2, 5, 6 }
            int db = 0;
            for (i = 0; i < n; i++)
            {
                if (arak[i] > k)
                {
                    dragak[db] = i; // { 1, 4, 5 }
                    db++;
                }
            }

            // Kiírás
            Console.Write($"{db} ");
            for (i = 0; i < db; i++)
            {
                Console.Write($"{dragak[i] + 1} ");
            }
        }
    }
}
