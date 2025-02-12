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
            List<int> lista = Feltolt(20000);
            //Kiir(lista, "Eredeti lista: ");

            List<int> a = new List<int>(lista);
            ora.Start();
            a.Sort(); // Növekvő
            ora.Stop();
            long idoSort = ora.ElapsedTicks;
            //Kiir(a, "Sort rendezés: ");
            Console.WriteLine("Sort ideje: " + idoSort);

            List<int> b = new List<int>(lista);
            ora.Restart();
            MinRendez(b);
            ora.Stop();
            long idoMinRendez = ora.ElapsedTicks;
            //Kiir(b, "Mininimum kiválasztásos rendezés: ");
            Console.WriteLine("MinRendez ideje: " + idoMinRendez);

            List<int> c = new List<int>(lista);
            ora.Restart();
            Buborekos(c);
            ora.Stop();
            long idoBuborekos = ora.ElapsedTicks;
            //Kiir(c, "Buborékos rendezés: ");
            Console.WriteLine("Buborékos ideje: " + idoBuborekos);
        }

        // Tudunk-e rajta javítani?
        static void Buborekos(List<int> lista)
        {
            int n = lista.Count;
            for (int i = 0; i < n; i++)
            {
                bool csere = false;
                // i: ennyi rendezett elem van már (a végén)
                // Rendezetlenek száma: n-i
                for (int j = 0; j < n-i-1; j++)
                {
                    // Rossz sorrend: ha előrébb van a nagyobb elem
                    if (lista[j] > lista[j+1])
                    {
                        Csere(lista, j, j + 1);
                        csere = true;
                    }
                }
                if (!csere) return;
            }
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
