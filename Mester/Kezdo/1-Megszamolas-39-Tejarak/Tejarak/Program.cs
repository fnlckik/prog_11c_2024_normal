using System;

namespace Tejarak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Deklaráció
            int n, also, felso;
            int[] arak = new int[100]; // { 199, 198, ..., 189 }

            // Beolvasás
            string elsosor = Console.ReadLine(); // "6 200 220"
            string[] adatok = elsosor.Split(' '); // {"6", "200", "220"}
            n = Convert.ToInt32(adatok[0]); // 6
            also = Convert.ToInt32(adatok[1]); // 200
            felso = Convert.ToInt32(adatok[2]); // 220

            int i;
            for (i = 0; i < n; i++)
            {
                int ar = Convert.ToInt32(Console.ReadLine()); // "199" => 199
                arak[i] = ar;
            }

            // Megszámolás

        }
    }
}
