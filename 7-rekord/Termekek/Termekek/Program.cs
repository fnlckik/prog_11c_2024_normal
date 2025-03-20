using System;
using System.Collections.Generic;
using System.IO;

namespace Termekek
{
    internal class Program
    {
        struct Termek // Product
        {
            public string nev; // name
            public int ar; // prince
            public bool elelmiszerE; // isFood
        }

        static void Main(string[] args)
        {
            List<Termek> termekek = new List<Termek>(); // products
            Beolvas(termekek);
            Kiir(termekek);

            // Összegzés
            Console.WriteLine($"\nÖsszeg: {Osszeg2(termekek)} Ft");

            // Minimax
            Termek legdragabb = Legdragabb2(termekek);
            Console.WriteLine($"\nLegdrágább termék (név): {legdragabb.nev}");

            // Kiválogatás
            // Válogassuk ki az élelmiszereket!
            List<string> elelmiszerek = Kivalogatas(termekek);
            // Írd ki őket!
            Kiir(elelmiszerek);

            // Keresés (lineáris)
            // Add meg az első olyan terméket a listán,
            // amely drágább mindkét mellette lévőnél!
            // => Hátizsák
            Console.WriteLine($"\nDrágább, mint a szomszédai: {Draga(termekek)}");

            // Rendezzük az adatokat ár szerint növekvően!
            Rendez(termekek);
            Kiir(termekek);
        }

        static void Rendez(List<Termek> termekek)
        {
            for (int i = 0; i < termekek.Count; i++)
            {
                // Ki az "i"-edik legolcsóbb (nevezzük k-nak)
                int k = i; // A "k"-adik elemet gondolom legolcsóbbnak.
                for (int j = i+1; j < termekek.Count; j++)
                {
                    if (termekek[j].ar < termekek[k].ar)
                    {
                        k = j;
                    }
                }
                Csere(termekek, i, k);
            }
        }

        static void Csere(List<Termek> termekek, int i, int k)
        {
            (termekek[i], termekek[k]) = (termekek[k], termekek[i]);
        }

        static void Kiir(List<string> elelmiszerek)
        {
            Console.WriteLine("\nÉlelmiszerek: ");
            for (int i = 0; i < elelmiszerek.Count; i++)
            {
                Console.WriteLine(elelmiszerek[i]);
            }
        }

        static string Draga(List<Termek> termekek)
        {
            int i = 1;
            while (i < termekek.Count-1 && !(termekek[i].ar > termekek[i-1].ar && termekek[i].ar > termekek[i+1].ar))
            {
                i++;
            }
            if (i < termekek.Count-1)
            {
                return termekek[i].nev;
            }
            else
            {
                return "-";
            }
        }

        static List<string> Kivalogatas(List<Termek> termekek)
        {
            List<string> elelmiszerek = new List<string>();
            foreach (Termek termek in termekek)
            {
                if (termek.elelmiszerE)
                {
                    elelmiszerek.Add(termek.nev);
                }
            }
            //for (int i = 0; i < termekek.Count; i++)
            //{
            //    if (termekek[i].elelmiszerE)
            //    {
            //        elelmiszerek.Add(termekek[i].nev);
            //    }
            //}
            return elelmiszerek;
        }

        static Termek Legdragabb2(List<Termek> termekek)
        {
            Termek legdragabb = termekek[0];
            foreach (Termek termek in termekek)
            {
                if (termek.ar > legdragabb.ar)
                {
                    legdragabb = termek;
                }
            }
            return legdragabb;
        }

        // Melyik a legdrágább termék?
        static Termek Legdragabb(List<Termek> termekek)
        {
            Termek legdragabb = termekek[0];
            for (int i = 0; i < termekek.Count; i++)
            {
                if (termekek[i].ar > legdragabb.ar)
                {
                    legdragabb = termekek[i];
                }
            }
            return legdragabb;
        }

        static int Osszeg2(List<Termek> termekek)
        {
            int osszeg = 0;
            for (int i = 0; i < termekek.Count; i++)
            {
                osszeg += termekek[i].ar;
            }
            return osszeg;
        }

        static int Osszeg(List<Termek> termekek)
        {
            int osszeg = 0;
            foreach (Termek termek in termekek)
            {
                osszeg += termek.ar;
            }
            return osszeg;
        }

        static void Kiir(List<Termek> termekek)
        {
            for (int i = 0; i < termekek.Count; i++)
            {
                //string tipus;
                //if (termekek[i].elelmiszerE)
                //{
                //    tipus = "élelmiszer";
                //}
                //else
                //{
                //    tipus = "tárgy";
                //}
                string tipus = termekek[i].elelmiszerE ? "élelmiszer" : "tárgy"; 
                Console.WriteLine($"{termekek[i].nev}: {termekek[i].ar} Ft ({tipus})");
            }
        }

        static void Beolvas(List<Termek> termekek)
        {
            StreamReader sr = new StreamReader("termekek.txt");
            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(';');
                Termek termek = new Termek
                {
                    nev = sor[0],
                    ar = int.Parse(sor[1]),
                    elelmiszerE = int.Parse(sor[2]) == 1
                };
                termekek.Add(termek);
            }
            sr.Close();
        }
    }
}
