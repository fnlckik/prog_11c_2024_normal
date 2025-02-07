using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Rendezes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch ora = new Stopwatch();

            //List<int> lista = new List<int> { 5, 3, 8, 5, 2 }; // 2, 3, 5, 5, 8
            List<int> lista = Feltolt(1000);
            //Kiir(lista, "Eredeti lista: ");

            List<int> a = new List<int>(lista);
            ora.Start();
            a.Sort(); // Növekvő
            ora.Stop();
            long idoSort = ora.ElapsedTicks;
            //Kiir(a, "Sort rendezés: ");

            List<int> b = new List<int>(lista);
            ora.Restart();
            MinRendez(b);
            ora.Stop();
            long idoMinRendez = ora.ElapsedTicks;
            //Kiir(b, "Mininimum kiválasztásos rendezés: ");

            Console.WriteLine("Sort ideje: " + idoSort);
            Console.WriteLine("MinRendez ideje: " + idoMinRendez);
        }

        static List<int> Feltolt(int n)
        {
            Random r = new Random();
            List<int> eredmeny = new List<int>();
            for (int i = 0; i < n; i++)
            {
                eredmeny.Add(r.Next(1, 101));
            }
            return eredmeny;
        }

        static void Kiir(List<int> lista, string szoveg)
        {
            Console.WriteLine(szoveg);
            foreach (int elem in lista)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }

        static void MinRendez(List<int> lista)
        {
            for (int i = 0; i < lista.Count - 1; i++)
            {
                // Hol van a minimuma a hátralévő elemeknek? (i. elemtől kezdve)
                int minindex = i;
                for (int j = minindex + 1; j < lista.Count; j++)
                {
                    if (lista[j] < lista[minindex])
                    {
                        minindex = j;
                    }
                }
                Csere(lista, i, minindex);
            }
        }

        static void Csere(List<int> lista, int i, int j)
        {
            //(lista[j], lista[i]) = (lista[i], lista[j]);
            int seged = lista[i];
            lista[i] = lista[j];
            lista[j] = seged;
        }
    }
}
