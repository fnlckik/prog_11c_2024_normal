using System;
using System.Collections.Generic;
using System.IO;

namespace Sorozatok
{
    internal class Program
    {
        struct Sorozat
        {
            public string datum;
            public string cim;
            public string epizod;
            public int hossz;
            public bool lattaE;
        }

        static void Main(string[] args)
        {
            List<Sorozat> sorozatok = new List<Sorozat>();
            Beolvas(sorozatok);
            F2(sorozatok);
            Console.WriteLine(Hetnapja(2025, 4, 11));
        }

        static string Hetnapja(int ev, int ho, int nap)
        {
            string[] napok = { "v", "h", "k", "sze", "cs", "p", "szo" };
            int[] honapok = { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };
            if (ho < 3) ev--;
            int i = (ev + ev / 4 - ev / 100 + ev / 400 + honapok[ho-1] + nap) % 7;
            return napok[i];
        }

        static void F2(List<Sorozat> sorozatok)
        {
            Console.WriteLine("2. feladat");
            int db = 0;
            foreach (Sorozat sorozat in sorozatok)
            {
                if (sorozat.datum != "NI")
                {
                    db++;
                }
            }
            Console.WriteLine($"A listában {db} db vetítési dátummal rendelkező epizód van.");
        }

        static void Beolvas(List<Sorozat> sorozatok)
        {
            StreamReader sr = new StreamReader("lista.txt");
            while (!sr.EndOfStream)
            {
                Sorozat sorozat;
                sorozat.datum = sr.ReadLine();
                sorozat.cim = sr.ReadLine();
                sorozat.epizod = sr.ReadLine();
                sorozat.hossz = int.Parse(sr.ReadLine());
                sorozat.lattaE = sr.ReadLine() == "1";

                //string datum = sr.ReadLine();
                //string cim = sr.ReadLine();
                //string epizod = sr.ReadLine();
                //int hossz = int.Parse(sr.ReadLine());
                //bool lattaE = sr.ReadLine() == "1";
                //Sorozat sorozat = new Sorozat
                //{
                //    datum = datum,
                //    cim = cim,
                //    epizod = epizod,
                //    hossz = hossz,
                //    lattaE = lattaE
                //};

                sorozatok.Add(sorozat);
            }
            sr.Close();
        }
    }
}
