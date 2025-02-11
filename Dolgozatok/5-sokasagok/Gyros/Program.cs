using System;
using System.Collections.Generic;

namespace Gyros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Feladat3();
        }

        static void Feladat3()
        {
            Console.WriteLine("\n3. feladat");
            List<List<int>> bevetelek = new List<List<int>>();
            int n = int.Parse(Console.ReadLine());
            int maxbevetel = Int32.MinValue;
            for (int i = 0; i < n; i++)
            {
                string[] sor = Console.ReadLine().Split(' ');
                List<int> penzek = new List<int>(); // aktuális sor listába
                foreach (string penz in sor)
                {
                    int p = int.Parse(penz);
                    penzek.Add(p);
                    if (p > maxbevetel)
                    {
                        maxbevetel = p;
                    }
                }
                bevetelek.Add(penzek);
            }
            Console.WriteLine($"Legnagyobb bevétel: {maxbevetel}");
        }

        static void Feladat2()
        {
            Console.WriteLine("\n2. feladat");
            List<string> varosok = new List<string> { "Budapest", "Cegléd", "Kecskemét", "Pécs", "Budapest", "Szolnok", "Budapest", "Debrecen", "Szolnok", "Budapest", "Budapest", "Cegléd", "Szolnok" };
            Dictionary<string, int> gyakorisagok = new Dictionary<string, int>();
            foreach (string varos in varosok)
            {
                if (!gyakorisagok.ContainsKey(varos))
                {
                    gyakorisagok.Add(varos, 1);
                }
                else
                {
                    gyakorisagok[varos]++;
                }
            }
            foreach (string varos in gyakorisagok.Keys)
            {
                Console.WriteLine($"{varos} ({gyakorisagok[varos]})");
            }
        }

        static void Feladat1()
        {
            Console.WriteLine("1. feladat");
            HashSet<string> bence = new HashSet<string> { "hagyma", "csípős", "sajt", "saláta", "uborka", "paradicsom" };
            HashSet<string> mate = new HashSet<string> { "csípős", "paradicsom", "káposzta", "saláta", "hagyma", "paprika" };
            HashSet<string> kozos = Mindketten(bence, mate);
            Kiir("a) ", kozos);

            //HashSet<string> kulonbseg = Kulonbseg(mate, bence);
            HashSet<string> kulonbseg = new HashSet<string>(mate);
            kulonbseg.ExceptWith(bence);
            Kiir("b) ", kulonbseg);
        }

        static HashSet<string> Kulonbseg(HashSet<string> mate, HashSet<string> bence)
        {
            HashSet<string> kulonbseg = new HashSet<string>();
            foreach (string elem in mate)
            {
                if (!bence.Contains(elem))
                {
                    kulonbseg.Add(elem);
                }
            }
            return kulonbseg;
        }

        static void Kiir(string szoveg, HashSet<string> halmaz)
        {
            Console.Write(szoveg);
            foreach (string elem in halmaz)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }

        static HashSet<string> Mindketten(HashSet<string> h1, HashSet<string> h2)
        {
            HashSet<string> metszet = new HashSet<string>();
            foreach (string elem in h1)
            {
                if (h2.Contains(elem))
                {
                    metszet.Add(elem);
                }
            }
            return metszet;
        }
    }
}
