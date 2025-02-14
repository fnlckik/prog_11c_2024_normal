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
            List<int> lista = Feltolt(200);
            //List<int> lista = FeltoltRendezett(200);
            //List<int> lista = FeltoltMajdnemRendezett(20000);
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

            List<int> d = new List<int>(lista);
            ora.Restart();
            Beszurasos(ref d);
            ora.Stop();
            long idoBeszurasos = ora.ElapsedTicks;
            Console.WriteLine("Beszúrásos ideje: " + idoBeszurasos);
            //Kiir(d, "Beszúrásos rendezés: ");

            //int[] x = { 3, 4, 5 };
            //f(ref x);
            //Console.WriteLine("x: " + x[0]);
        }

        //static void f(ref int[] x)
        //{
        //    x = new int[] { 6, 7, 8, 6 };
        //}

        // Hogyan lehetne javítani?
        // 1. Logaritmikus keresés
        // 2. LinkedList
        static void Beszurasos(ref List<int> lista)
        {
            List<int> rendezett = new List<int>();
            foreach (int elem in lista)
            {
                int i = 0;
                // rendezett[i] < elem
                while (i < rendezett.Count && !(rendezett[i] >= elem))
                {
                    i++;
                }
                rendezett.Insert(i, elem);
            }
            lista = rendezett;
        }
        //if (i<rendezett.Count)
        //{
        //    rendezett.Insert(i, elem);
        //}
        //else
        //{
        //    rendezett.Insert(rendezett.Count, elem);
        //}

        // { 20, 21, 22, 23, 22, 23, 24, 23, 22, 23, 24, 25, 26, 27, 26 }
        // 90% valószínűséggel növekednek az elemek (10% valószínűséggel csökkennek)
        // Minél inkább rendezett a lista, annál gyorsabb a buborékos!
        static List<int> FeltoltMajdnemRendezett(int n)
        {
            List<int> eredmeny = new List<int>();
            Random r = new Random();
            int akt = 20;
            for (int i = 0; i < n; i++)
            {
                eredmeny.Add(akt);
                int esely = r.Next(1, 101); // 1-100
                if (esely <= 90)
                {
                    akt++;
                }
                else
                {
                    akt--;
                }
            }
            return eredmeny;
        }

        static List<int> FeltoltRendezett(int n)
        {
            List<int> eredmeny = new List<int>();
            for (int i = 0; i < n; i++)
            {
                eredmeny.Add(i+1);
            }
            return eredmeny;
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
