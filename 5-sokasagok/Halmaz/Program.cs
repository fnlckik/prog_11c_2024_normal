using System;
using System.Collections.Generic;

namespace Halmaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> lista = new List<int> { 4, 6, 1, 2, 2, 1, 2 };
            Console.WriteLine(lista.Count);
            Console.WriteLine("A lista 1. eleme: " + lista[0]);
            */

            // Halmaz:
            // 1. Elemeknek nincs sorrendje -> nem indexelhető
            // 2. Egyediek az elemei.
            HashSet<int> halmaz = new HashSet<int> { 4, 6, 1, 2, 2, 1, 2 };
            Console.WriteLine("Halmaz elemszáma: " + halmaz.Count);
            //Console.WriteLine("A halmaz 1. eleme: " + halmaz[0]);

            halmaz.Add(13); // { 4, 6, 1, 2, 13 }
            halmaz.Remove(6);
            Console.WriteLine("Eleme-e a 13-mas? " + halmaz.Contains(13));

            Console.Write("Halmaz elemei: ");
            Kiir(halmaz);

            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            HashSet<string> v1 = new HashSet<string> { "Bence", "Réka", "Máté", "Pisti", "Johanna", "Kata" };
            HashSet<string> v2 = new HashSet<string> { "Máté", "Zalán", "Csaba", "Kata", "Bence" };
        }

        static void Kiir(HashSet<int> halmaz)
        {
            Console.Write("{ ");
            int db = 0;
            foreach (int elem in halmaz)
            {
                db++;
                if (db < halmaz.Count)
                {
                    Console.Write(elem + ", ");
                }
                else
                {
                    Console.Write(elem);
                }
            }
            Console.WriteLine(" }");
        }
    }
}
