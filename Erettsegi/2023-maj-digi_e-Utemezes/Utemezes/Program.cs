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
            //F4Peti(taborok);
            F4(taborok);

            // Első nap: 06. 16.
            //Console.WriteLine(Sorszam(6, 20)); // 5 (20 - 16 + 1)
            //Console.WriteLine(Sorszam(7, 5)); // június: 15 (30 - 16 + 1) + július: 5 => 20
            //Console.WriteLine(Sorszam(8, 12)); // június: 15 + július: 31 + aug: 12 => 58

            //Console.WriteLine(Sorszam(taborok[taborok.Count-1].kezdoHonap, taborok[taborok.Count-1].kezdoNap));

            //Console.WriteLine(SorszamPeti(6, 20)); // 5 (20 - 16 + 1)
            //Console.WriteLine(SorszamPeti(7, 5)); // június: 15 (30 - 16 + 1) + július: 5 => 20
            //Console.WriteLine(SorszamPeti(8, 12)); // június: 15 + július: 31 + aug: 12 => 58
            //F6(taborok);
            F6Nikol(taborok);
        }

        static void F6Nikol(List<Tabor> taborok)
        {
            Console.WriteLine("\n6. feladat");
            Console.Write("hó: ");
            int ho = int.Parse(Console.ReadLine());
            Console.Write("nap: ");
            int nap = int.Parse(Console.ReadLine());
            int db = 0;
            for (int i = 0; i < taborok.Count; i++)
            {
                // 1. Már elkezdődött a tábor
                // 2. Még nem végződött a tábor
                Tabor akt = taborok[i];
                if ((ho > akt.kezdoHonap || (ho == akt.kezdoHonap && nap >= akt.kezdoNap)) &&
                    (ho < akt.vegHonap || (ho == akt.vegHonap && nap <= akt.vegNap)))
                {
                    db++;
                }
            }
            Console.WriteLine($"{db} tabor zajlik ilyenkor");
        }

        static void F6(List<Tabor> taborok)
        {
            Console.WriteLine("6. feladat");
            Console.Write("hó: ");
            int honap = int.Parse(Console.ReadLine());
            Console.Write("nap: ");
            int nap = int.Parse(Console.ReadLine());
            int sorszam = Sorszam(honap, nap); // 08.01. => 47. nap

            int db = 0;
            foreach (Tabor tabor in taborok)
            {
                int kezdes = Sorszam(tabor.kezdoHonap, tabor.kezdoNap);
                int vegzes = Sorszam(tabor.vegHonap, tabor.vegNap);
                if (kezdes <= sorszam && sorszam <= vegzes)
                {
                    db++;
                }
            }
            Console.WriteLine($"Ekkor éppen {db} tábor tart.");
        }

        struct Nyariszunet
        {
            public int honap;
            public int nap;
        }

        static int SorszamPeti(int honap, int nap)
        {
            List<Nyariszunet> napok = new List<Nyariszunet>();
            for (int i = 6; i <= 8; i++)
            {
                if (i == 7 || i == 8)
                {
                    for (int j = 1; j <= 31; j++)
                    {
                        Nyariszunet ujnap = new Nyariszunet
                        {
                            honap = i,
                            nap = j
                        };
                        napok.Add(ujnap);
                    }
                }
                else
                {
                    for (int j = 16; j <= 30; j++)
                    {
                        Nyariszunet ujnap = new Nyariszunet
                        {
                            honap = i,
                            nap = j
                        };
                        napok.Add(ujnap);
                    }
                }
            }

            //foreach (Nyariszunet elem in napok)
            //{
            //    Console.WriteLine($"{elem.honap} {elem.nap}");
            //}

            int napi = 0;
            while (napi < napok.Count && napok[napi].nap != nap || napok[napi].honap != honap)
            {
                napi++;
            }
            return napi + 1;
        }

        // Tegyük fel, hogy honap eleme { 6, 7, 8 }
        static int Sorszam(int honap, int nap)
        {
            if (honap == 6)
            {
                return nap - 15; // Június első 15 napja még nem volt szünet
            }
            else if (honap == 7)
            {
                return 15 + nap;
            }
            else
            {
                return 46 + nap;
            }
        }

        static void F4(List<Tabor> taborok)
        {
            Console.WriteLine("\n4. feladat");
            Console.WriteLine("Legnépszerűbbek:");
            int maxe = taborok[0].diakok.Length;
            foreach (Tabor tabor in taborok)
            {
                if (tabor.diakok.Length > maxe)
                {
                    maxe = tabor.diakok.Length;
                }
            }
            foreach (Tabor tabor in taborok)
            {
                if (tabor.diakok.Length == maxe)
                {
                    Console.WriteLine($"{tabor.kezdoHonap} {tabor.kezdoNap} {tabor.tema}");
                }
            }
        }

        static void F4Peti(List<Tabor> taborok)
        {
            Console.WriteLine("\n4. feladat");
            Console.WriteLine("Legnépszerűbbek:");
            int maxi = 0;
            for (int i = 0; i < taborok.Count; i++)
            {
                if (taborok[i].diakok.Length > taborok[maxi].diakok.Length)
                {
                    maxi = i;
                }
            }
            //List<int> Legnepszerubbeki = new List<int>();
            for (int i = 0; i < taborok.Count; i++)
            {
                if (taborok[maxi].diakok.Length == taborok[i].diakok.Length)
                {
                    //Legnepszerubbeki.Add(i);
                    Console.WriteLine($"{taborok[i].kezdoHonap} {taborok[i].kezdoNap} {taborok[i].tema}");
                }
            }
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
