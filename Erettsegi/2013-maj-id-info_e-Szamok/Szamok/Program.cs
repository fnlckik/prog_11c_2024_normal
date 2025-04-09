using System;
using System.Collections.Generic;
using System.IO;

namespace Szamok
{
    // long - Int64 (8 bájt), int - Int32 (4 bájt),
    // short - Int16 (2 bájt), byte (1 bájt, 256 féle)
    struct Kerdes
    {
        public string szoveg;
        public int valasz;
        public byte pontszam; // 1-től 3-ig
        public string tema; // "magyar", "matek", ...
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Kerdes> kerdesek = new List<Kerdes>();
            Beolvas(kerdesek);
            F2(kerdesek);
            F3(kerdesek);
            F4(kerdesek);
        }

        static void F4(List<Kerdes> kerdesek)
        {
            int mine = kerdesek[0].valasz;
            int maxe = kerdesek[0].valasz;
            foreach (Kerdes kerdes in kerdesek)
            {
                if (kerdes.valasz > maxe) maxe = kerdes.valasz;
                if (kerdes.valasz < mine) mine = kerdes.valasz;
            }
            Console.WriteLine("\n4. feladat");
            Console.WriteLine($"A válaszok {mine}-től {maxe}-ig terjednek.");
        }

        static void F3(List<Kerdes> kerdesek)
        {
            // 1 => 10db, 2 => 6db, 3 => 4db 
            Dictionary<int, int> darabok = new Dictionary<int, int>
            {
                { 1, 0 }, { 2, 0 }, { 3, 0 }
            };
            //darabok[1]: Hány darab 1 pontos feladat van?
            //darabok[2]: Hány darab 2 pontos feladat van?

            //int[] gyakorisagok = new int[3];

            int db = 0;
            foreach (Kerdes kerdes in kerdesek)
            {
                if (kerdes.tema == "matematika")
                {
                    db++;
                    darabok[kerdes.pontszam]++;
                    //gyakorisagok[kerdes.pontszam-1]++;
                }
            }

            Console.WriteLine("\n3. feladat");
            Console.Write($"Az adatfajlban {db} matematika feladat van, ");
            Console.Write($"1 pontot er {darabok[1]} feladat, ");
            Console.Write($"2 pontot er {darabok[2]} feladat, ");
            Console.WriteLine($"3 pontot er {darabok[3]} feladat.");
        }

        static void F2(List<Kerdes> kerdesek)
        {
            Console.WriteLine("2. feladat");
            Console.WriteLine($"A feladatok száma: {kerdesek.Count}");
        }

        static void Beolvas(List<Kerdes> kerdesek)
        {
            StreamReader sr = new StreamReader("felszam.txt");
            while (!sr.EndOfStream)
            {
                string szoveg = sr.ReadLine();
                string[] sor = sr.ReadLine().Split(' ');
                //Convert.ToInt32() => int.Parse()
                //Convert.ToByte() => byte.Parse()
                Kerdes kerdes = new Kerdes
                {
                    szoveg = szoveg,
                    valasz = int.Parse(sor[0]),
                    pontszam = byte.Parse(sor[1]),
                    tema = sor[2]
                };
                //Kerdes kerdes;
                //kerdes.szoveg = szoveg;
                //kerdes.valasz = int.Parse(sor[0]);
                //kerdes.pontszam = byte.Parse(sor[1]);
                //kerdes.tema = sor[2];
                kerdesek.Add(kerdes);
            }
            sr.Close();
        }
    }
}
