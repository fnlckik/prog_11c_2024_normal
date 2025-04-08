using System;
using System.Collections.Generic;
using System.IO;

namespace Epitmenyado
{
    internal class Program
    {
        //struct Lakcim
        //{
        //    public string utca;
        //    public string hsz;
        //}

        struct Lakas
        {
            public string adoszam; // A lakás tulajdonosának adószáma
            public string utca;
            public string hsz;
            //public Lakcim lakcim;
            public char sav; // 'A', 'B', 'C'
            public int terulet;
        }

        //struct Savszorzo
        //{
        //    public int a;
        //    public int b;
        //    public int c;
        //}

        // int a, b, c
        // List<int> (3 elemű)
        // struct Savszorzo (adattagok: a, b, c)
        // Dictionary<char, int>
        static void Main(string[] args)
        {
            List<Lakas> lakasok = new List<Lakas>();
            Dictionary<char, int> adok = new Dictionary<char, int>();
            Beolvas(lakasok, adok);
            F2(lakasok);
            //F3(lakasok);
            //Console.WriteLine(Ado('C', 60, adok));
            F5(lakasok, adok);
            F6(lakasok);
            F7(lakasok, adok);
        }

        static void F7(List<Lakas> lakasok, Dictionary<char, int> adok)
        {
            Dictionary<string, int> fizetendok = new Dictionary<string, int>();
            foreach (Lakas lakas in lakasok)
            {
                int ado = Ado(lakas.sav, lakas.terulet, adok);
                if (!fizetendok.ContainsKey(lakas.adoszam))
                {
                    fizetendok.Add(lakas.adoszam, ado);
                }
                else
                {
                    fizetendok[lakas.adoszam] += ado;
                }
            }

            StreamWriter sw = new StreamWriter("fizetendo.txt");
            foreach (string adoszam in fizetendok.Keys)
            {
                sw.WriteLine($"{adoszam} {fizetendok[adoszam]}");
            }
            sw.Close();
        }

        static void F6(List<Lakas> lakasok)
        {
            HashSet<string> utcak = new HashSet<string>();
            // Kiválogatjuk (i, i+1) ha: utca egyezik, sav nem
            for (int i = 0; i < lakasok.Count - 1; i++)
            {
                Lakas akt = lakasok[i];
                Lakas kov = lakasok[i + 1];
                if (akt.utca == kov.utca && akt.sav != kov.sav)
                {
                    utcak.Add(akt.utca);
                }
            }

            Console.WriteLine("6. feladat. A több sávba sorolt utcák: ");
            foreach (string utca in utcak)
            {
                Console.WriteLine(utca);
            }
        }

        // Meg tudjuk-e írni elágazás nélkül?
        static void F5(List<Lakas> lakasok, Dictionary<char, int> adok)
        {
            //int adb = 0, bdb = 0, cdb = 0;
            //int aosszeg = 0, bosszeg = 0, cosszeg = 0;
            //foreach (Lakas lakas in lakasok)
            //{
            //    if (lakas.sav == 'A')
            //    {
            //        adb++;
            //        aosszeg += Ado(lakas.sav, lakas.terulet, adok);
            //    }
            //    else if (lakas.sav == 'B')
            //    {
            //        bdb++;
            //        bosszeg += Ado(lakas.sav, lakas.terulet, adok);
            //    }
            //    else
            //    {
            //        cdb++;
            //        cosszeg += Ado(lakas.sav, lakas.terulet, adok);
            //    }
            //}

            Dictionary<char, int> darabok = new Dictionary<char, int>();
            darabok['A'] = 0; // darabok.Add('A', 0);
            darabok['B'] = 0;
            darabok['C'] = 0;
            Dictionary<char, int> osszegek = new Dictionary<char, int>
            {
                { 'A', 0 }, { 'B', 0 }, { 'C', 0 }
            };
            foreach (Lakas lakas in lakasok)
            {
                char sav = lakas.sav; // 'C'
                darabok[sav]++;
                osszegek[sav] += Ado(lakas.sav, lakas.terulet, adok);
                //darabok[lakas.sav]++;
            }
            Console.WriteLine("5. feladat");
            //Console.WriteLine($"A sávba {darabok['A']} telek esik, az adó {osszegek['A']} Ft.");
            //Console.WriteLine($"B sávba {darabok['B']} telek esik, az adó {osszegek['B']} Ft.");
            //Console.WriteLine($"C sávba {darabok['C']} telek esik, az adó {osszegek['C']} Ft.");
            foreach (char sav in darabok.Keys)
            {
                Console.WriteLine($"{sav} sávba {darabok[sav]} telek esik, az adó {osszegek[sav]} Ft.");
            }
        }

        static int Ado(char adosav, int alapterulet, Dictionary<char, int> adok)
        {
            //int ado;
            //if (adosav == 'A')
            //{
            //    ado = alapterulet * adok['A'];
            //}
            //else if (adosav == 'B')
            //{
            //    ado = alapterulet * adok['B'];
            //}
            //else
            //{
            //    ado = alapterulet * adok['C'];
            //}
            int ado = alapterulet * adok[adosav];
            if (ado < 10000) ado = 0;
            return ado;
        }

        static void F3(List<Lakas> lakasok)
        {
            // Kiválogatás
            Console.Write("3. feladat. Egy tulajdonos adószáma: ");
            string adoszam = Console.ReadLine();
            int db = 0;
            for (int i = 0; i < lakasok.Count; i++)
            {
                if (lakasok[i].adoszam == adoszam)
                {
                    db++;
                    Console.WriteLine($"{lakasok[i].utca} utca {lakasok[i].hsz}");
                }
            }
            if (db == 0)
            {
                Console.WriteLine("Nem szerepel az adatállományban.");
            }
        }

        static void F2(List<Lakas> lakasok)
        {
            Console.WriteLine($"2. feladat. A mintában {lakasok.Count} telek szerepel.");
        }

        static void Beolvas(List<Lakas> lakasok, Dictionary<char, int> adok)
        {
            StreamReader reader = new StreamReader("utca.txt");
            string[] adatok = reader.ReadLine().Split(); // { "800", "600", "100" } 
            adok.Add('A', int.Parse(adatok[0]));
            adok.Add('B', int.Parse(adatok[1]));
            adok.Add('C', int.Parse(adatok[2]));
            while (!reader.EndOfStream)
            {
                string[] sor = reader.ReadLine().Split();
                Lakas ujlakas = new Lakas
                {
                    adoszam = sor[0],
                    utca = sor[1],
                    hsz = sor[2],
                    sav = char.Parse(sor[3]), // "C" => 'C'
                    terulet = int.Parse(sor[4])
                };
                lakasok.Add(ujlakas);
            }
            reader.Close();
        }
    }
}
