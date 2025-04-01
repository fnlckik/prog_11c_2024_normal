using System;
using System.Collections.Generic;
using System.IO;

namespace Utemezes
{
    internal class Program
    {
        struct Tabor
        {
            public int kezdoHonap;
            public int kezdoNap;
            public int vegHonap;
            public int vegNap;
            public string diakok;
            public string tema;
        }

        static void Main(string[] args)
        {
            List<Tabor> taborok = new List<Tabor>();
            Beolvas(taborok);
            F2(taborok);
            //F3Gergo(taborok);
            //F3Fanni(taborok);
            //F3Nikol(taborok);
            F3(taborok);
        }

        static void F3(List<Tabor> taborok)
        {
            Console.WriteLine("\n3. feladat");
            List<Tabor> zeneitaborok = new List<Tabor>();
            foreach (Tabor tabor in taborok)
            {
                if (tabor.tema == "zenei")
                {
                    zeneitaborok.Add(tabor);
                }
            }
            if (zeneitaborok.Count == 0)
            {
                Console.WriteLine("Nincs zenei tábor");
            }
            foreach (Tabor tabor in zeneitaborok)
            {
                Console.WriteLine($"A zenei tábor kezdődik: {tabor.kezdoHonap} hó - {tabor.kezdoNap}. napon");
            }
        }

        static void F3Nikol(List<Tabor> taborok)
        {
            List<Tabor> zeneitaborok = new List<Tabor>();
            for (int i = 0; i < taborok.Count; i++)
            {
                if (taborok[i].tema == "zenei")
                {
                    zeneitaborok.Add(taborok[i]);
                }
            }
            if (zeneitaborok.Count == 0)
            {
                Console.WriteLine("Nincs zenei tábor");
            }
            else
            {
                for (int i = 0; i < zeneitaborok.Count; i++)
                {
                    Console.WriteLine($"A zenei tábor kezdődik: {zeneitaborok[i].kezdoHonap} hó - {zeneitaborok[i].kezdoNap}. napon");
                }
            }
        }

        private static void F3Fanni(List<Tabor> taborok)
        {
            Console.WriteLine("\n3. feladat");
            int db = 0;
            for (int i = 0; i < taborok.Count; i++)
            {
                if (taborok[i].tema == "zenei")
                {
                    int kHonap = taborok[i].kezdoHonap;
                    int kNap = taborok[i].kezdoNap;
                    Console.WriteLine($"Zenei tabor kezdodik: {kHonap} ho {kNap} napon");
                    db++;
                }
            }
            if (db == 0)
            {
                Console.WriteLine("Nincs zenei tabor");
            }
        }

        static void F3Gergo(List<Tabor> taborok)
        {
            Console.WriteLine("\n3. feladat");
            List<int> kesz = new List<int>();
            foreach (Tabor tabor in taborok)
            {
                if (tabor.tema == "zenei")
                {
                    kesz.Add(tabor.kezdoHonap);
                    kesz.Add(tabor.kezdoNap);
                }
            }
            for (int i = 0; i < kesz.Count - 1; i += 2)
            {
                Console.WriteLine($"Zenei tábor kezdődik {kesz[i]}. hó {kesz[i + 1]}. napján.");
            }
            if (kesz.Count == 0)
            {
                Console.WriteLine("Nem volt zenei tábor.");
            }
        }

        static void F2(List<Tabor> taborok)
        {
            Console.WriteLine("2. feladat");
            Console.WriteLine($"Az adatsorok száma: {taborok.Count}");
            Console.WriteLine("Az először rögzített tábor témája: " + taborok[0].tema);
            Console.WriteLine("Az utoljára rögzített tábor témája: " + taborok[taborok.Count - 1].tema);
        }

        static void Beolvas(List<Tabor> taborok)
        {
            StreamReader sr = new StreamReader("taborok.txt");
            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split('\t');
                Tabor tabor = new Tabor
                {
                    kezdoHonap = int.Parse(sor[0]),
                    kezdoNap = int.Parse(sor[1]),
                    vegHonap = int.Parse(sor[2]),
                    vegNap = int.Parse(sor[3]),
                    diakok = sor[4],
                    tema = sor[5]
                };
                taborok.Add(tabor);
            }
            sr.Close();
        }
    }
}
