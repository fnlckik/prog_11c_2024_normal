using System;
using System.Collections.Generic;

namespace Jegyek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> tanulok = new List<List<int>>();
            Beolvas(tanulok);
            Kiir2(tanulok);
            Console.Write("Átlagok: ");
            Atlagok2(tanulok);
            // Adjuk meg a legjobb tanuló sorszámát! => 2
        }

        static void Atlagok2(List<List<int>> tanulok)
        {
            for (int i = 0; i < tanulok.Count; i++)
            {
                int osszeg = 0;
                for (int j = 0; j < tanulok[i].Count; j++)
                {
                    osszeg += tanulok[i][j];
                }
                double atlag = (double)osszeg / tanulok[i].Count;
                Console.Write($"{atlag:0.00} ");
            }
        }

        static void Kiir3(List<List<int>> tanulok)
        {
            for (int i = 0; i < tanulok.Count; i++)
            {
                Console.Write($"{i + 1}. tanuló: ");
                for (int j = 0; j < tanulok[i].Count; j++)
                {
                    Console.Write(tanulok[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Kiir2(List<List<int>> tanulok)
        {
            for (int i = 0; i < tanulok.Count; i++)
            {
                Console.Write($"{i + 1}. tanuló: ");
                List<int> tanulo = tanulok[i];
                foreach (int jegy in tanulo)
                {
                    Console.Write(jegy + " ");
                }
                Console.WriteLine();
            }
        }

        // Írd ki a tanulók átlagait! 4,4 4,75 2 3,33 ...
        static void Atlagok(List<List<int>> tanulok)
        {
            foreach (List<int> tanulo in tanulok)
            {
                int osszeg = 0;
                foreach (int jegy in tanulo)
                {
                    osszeg += jegy;
                }
                double atlag = (double)osszeg / tanulo.Count;
                Console.Write($"{atlag:0.00} ");
                //Console.Write($"{Math.Round(atlag, 2)} ");
            }
        }

        /*
            1. tanuló: 5 3 5 5 4
            2. tanuló: 5 5 4 5
            3. tanuló: 2 2 1 2 3
            4. tanuló: 3 5 2
            5. tanuló: 1 4 1 2 4 4 
        */
        static void Kiir(List<List<int>> tanulok)
        {
            int db = 1;
            foreach (List<int> tanulo in tanulok)
            {
                Console.Write($"{db}. tanuló: ");
                foreach (int jegy in tanulo)
                {
                    Console.Write(jegy + " ");
                }
                Console.WriteLine();
                db++;
            }
        }

        static void Beolvas(List<List<int>> tanulok)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<int> tanulo = new List<int>(); // létrehoztunk egy üres listát
                string[] sor = Console.ReadLine().Split(' '); // {"5", "3", "5", "5", "4"}
                //for (int j = 0; j < sor.Length; j++)
                //{
                //    tanulo.Add(Convert.ToInt32(sor[j]));
                //}
                foreach (string jegy in sor)
                {
                    tanulo.Add(int.Parse(jegy));
                }
                tanulok.Add(tanulo);
            }
        }
    }
}
