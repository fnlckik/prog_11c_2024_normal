using System;
using System.Collections.Generic;
using System.IO;

namespace Tanciskola
{
    internal class Program
    {
        struct Tanc
        {
            public string nev;
            public string no;
            public string ferfi;
        }

        static void Main(string[] args)
        {
            List<Tanc> tancok = new List<Tanc>();
            Beolvas(tancok);
            F2(tancok);
            F3(tancok);
            F4(tancok);
            F5(tancok);
            F6(tancok);
            F7(tancok);
        }

        static void F7(List<Tanc> tancok)
        {
            Dictionary<string, int> fiuk = new Dictionary<string, int>();
            Dictionary<string, int> lanyok = new Dictionary<string, int>();
            foreach (Tanc tanc in tancok)
            {
                if (!fiuk.ContainsKey(tanc.ferfi)) fiuk.Add(tanc.ferfi, 1);
                else fiuk[tanc.ferfi]++;
                if (!lanyok.ContainsKey(tanc.no)) lanyok.Add(tanc.no, 1);
                else lanyok[tanc.no]++;
            }

            int maxF = 0;
            foreach (string nev in fiuk.Keys)
            {
                if (fiuk[nev] > maxF)
                {
                    maxF = fiuk[nev];
                }
            }

            int maxL = 0;
            foreach (string nev in lanyok.Keys)
            {
                if (lanyok[nev] > maxL)
                {
                    maxL = lanyok[nev];
                }
            }

            Console.WriteLine("\n7. feladat");
            Console.Write("Legtöbbször szereplő fiú(k): ");
            foreach (string nev in fiuk.Keys)
            {
                if (fiuk[nev] == maxF)
                {
                    Console.Write(nev + " ");
                }
            }
            Console.WriteLine();

            Console.Write("Legtöbbször szereplő lány(ok): ");
            foreach (string nev in lanyok.Keys)
            {
                if (lanyok[nev] == maxL)
                {
                    Console.Write(nev + " ");
                }
            }
            Console.WriteLine();
        }

        static void F6(List<Tanc> tancok)
        {
            HashSet<string> fiuk = new HashSet<string>();
            HashSet<string> lanyok = new HashSet<string>();
            foreach (Tanc tanc in tancok)
            {
                lanyok.Add(tanc.no);
                fiuk.Add(tanc.ferfi);
            }

            StreamWriter sw = new StreamWriter("szereplok.txt");
            Kiir("Lányok: ", lanyok, sw);
            Kiir("Fiúk: ", fiuk, sw);
            sw.Close();
        }

        static void Kiir(string s, HashSet<string> nevek, StreamWriter sw)
        {
            int db = 0;
            sw.Write(s);
            foreach (string nev in nevek)
            {
                db++;
                sw.Write(nev);
                if (db < nevek.Count)
                {
                    sw.Write(", ");
                }
            }
            sw.WriteLine();
        }

        static void F5(List<Tanc> tancok)
        {
            Console.WriteLine("\n5. feladat");
            Console.Write("Tánc neve: ");
            string nev = Console.ReadLine();
            int i = 0;
            while (i < tancok.Count && !(tancok[i].nev == nev && tancok[i].no == "Vilma"))
            {
                i++;
            }
            if (i < tancok.Count)
            {
                Console.WriteLine($"A {nev} bemutatóján Vilma párja {tancok[i].ferfi} volt.");
            }
            else
            {
                Console.WriteLine($"Vilma nem táncolt {nev}-t.");
            }
        }

        static void F4(List<Tanc> tancok)
        {
            Console.WriteLine("\n4. feladat");
            Console.Write("Vilma táncai: ");
            foreach (Tanc tanc in tancok)
            {
                if (tanc.no == "Vilma")
                {
                    Console.Write(tanc.nev + " ");
                }
            }
            Console.WriteLine();
        }

        static void F3(List<Tanc> tancok)
        {
            Console.WriteLine("\n3. feladat");
            int db = 0;
            foreach (Tanc tanc in tancok)
            {
                if (tanc.nev == "samba")
                {
                    db++;
                }
            }
            Console.WriteLine($"A sambát {db} pár mutatta be.");
        }

        static void F2(List<Tanc> tancok)
        {
            Console.WriteLine("2. feladat");
            Console.WriteLine($"Az első tánc neve: {tancok[0].nev}");
            Console.WriteLine($"Az utolsó tánc neve: {tancok[tancok.Count-1].nev}");
        }

        static void Beolvas(List<Tanc> tancok)
        {
            StreamReader sr = new StreamReader("tancrend.txt");
            while (!sr.EndOfStream)
            {
                Tanc t = new Tanc
                {
                    nev = sr.ReadLine(),
                    no = sr.ReadLine(),
                    ferfi = sr.ReadLine()
                };
                tancok.Add(t);
            }
            sr.Close();
        }
    }
}
