using System;

namespace Fenyofa
{
    internal class Program
    {
        static void Beolvas(out int n, out int ar, int[] arak)
        {
            string[] sor = Console.ReadLine().Split(' ');
            n = Convert.ToInt32(sor[0]);
            ar = Convert.ToInt32(sor[1]);
            for (int i = 0; i < n; i++)
            {
                arak[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        static int Keres(int n, int ar, int[] arak)
        {
            int i = 0;
            while (i < n && !(arak[i] > ar))
            {
                i++;
            }
            return i;
        }

        // Feltételes minimum kiválasztás
        static int LegolcsobbDraga(int n, int ar, int[] arak)
        {
            int mini = Keres(n, ar, arak); // Keressük meg az első drágát
            if (mini == n) return -1;
            for (int i = mini; i < n; i++)
            {
                if (arak[i] > ar && arak[i] < arak[mini])
                {
                    mini = i;
                }
            }
            return mini;
        }

        static void Kiir(int i, int[] arak)
        {
            if (i == -1)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine($"{i+1} {arak[i]}");
            }
        }

        static void Main(string[] args)
        {
            int[] arak = new int[100];
            Beolvas(out int n, out int ar, arak);
            int legolcsobbIndex = LegolcsobbDraga(n, ar, arak);
            Kiir(legolcsobbIndex, arak);
        }
    }
}
