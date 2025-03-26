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
            F2(lakasok);
            //F3(lakasok);
            //Console.WriteLine(Ado('C', 60, adok));
            F5(lakasok);
        }

        // Meg tudjuk-e írni elágazás nélkül?
        static void F5(List<Lakas> lakasok)
        {
            int adb = 0;
            foreach (Lakas lakas in lakasok)
            {
                if (lakas.sav == 'A')
                {
                    adb++;
                }
            }
            Console.WriteLine(adb);
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
