using System;
using System.Collections.Generic;
using System.IO;

namespace Epitmenyado
{
    internal class Program
    {
        struct Lakas
        {
            public string adoszam; // A lakás tulajdonosának adószáma
            public string utca;
            public string hsz;
            public char sav;
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
