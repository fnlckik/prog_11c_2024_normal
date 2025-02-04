using System;
using System.Collections.Generic;

namespace Vonat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Feladat3();
        }

        static void Feladat1()
        {
            Console.WriteLine("1. feladat");
            Dictionary<string, int> kesesek = new Dictionary<string, int>();
            Beolvas(kesesek);
            Kiir(kesesek);
        }

        static void Kiir(Dictionary<string, int> kesesek)
        {
            foreach (string varos in kesesek.Keys)
            {
                Console.WriteLine(varos + ": " + kesesek[varos]);
            }
        }

        static void Beolvas(Dictionary<string, int> kesesek)
        {
            int n = int.Parse(Console.ReadLine()); // 12
            for (int i = 0; i < n; i++)
            {
                string[] sor = Console.ReadLine().Split(' '); // { "Szolnok", "7" }
                string varos = sor[0];
                int keses = int.Parse(sor[1]);
                if (!kesesek.ContainsKey(varos)) // Ha még nincs benne a város
                {
                    kesesek.Add(varos, keses);
                }
                else if (kesesek[varos] < keses) // Ha van már adat, de nagyobb késés jött most
                {
                    //kesesek.Remove(varos);
                    //kesesek.Add(varos, keses);
                    kesesek[varos] = keses;
                }
            }
        }

        static void Feladat2()
        {
            Console.WriteLine("\n2. feladat");
            List<List<int>> buntetesek = Feltolt();
        }

        static List<List<int>> Feltolt()
        {
            Random r = new Random();
            List<List<int>> buntetesek = new List<List<int>>(); // { ?, ?, ?, ?, ? }
            int osszes = 0;
            for (int i = 0; i < 5; i++)
            {
                int u = r.Next(2, 11);
                List<int> sor = new List<int>(); // { 25000, 25000, 25000 }
                for (int j = 0; j < u; j++)
                {
                    sor.Add(r.Next(20, 51) * 1000);
                    Console.Write(sor[j] + " ");
                    osszes += sor[j];
                }
                Console.WriteLine();
                buntetesek.Add(sor);
            }
            Console.WriteLine($"Összes büntetés: {osszes}");
            return buntetesek;
        }

        static void Feladat3()
        {
            Console.WriteLine("\n3. feladat");
            HashSet<string> v1 = new HashSet<string> { "Budapest-Nyugati", "Zugló", "Kőbánya alsó", "Kőbánya-Kispest", "Ferihegy", "Monor", "Monorierdő", "Pilis", "Albertirsa", "Ceglédbercel", "Ceglédbercel-Cserő", "Budai út", "Cegléd" };
            HashSet<string> v2 = new HashSet<string> { "Budapest-Nyugati", "Zugló", "Kőbánya-Kispest", "Ferihegy", "Cegléd", "Nagykőrös", "Kecskemét", "Kiskunfélegyháza", "Kistelek", "Szatymaz", "Szeged" };
            HashSet<string> csakelso = CsakElsoAllomasok(v1, v2);
            Kiir(csakelso);
            Console.WriteLine($"b) {KozosekSzama(v1, v2)}");
            Console.WriteLine($"c) {v1.IsSubsetOf(v2)}");
            //Console.WriteLine($"c) {Reszhalmaza(v1, v2)}");
        }

        static bool Reszhalmaza(HashSet<string> v1, HashSet<string> v2)
        {
            bool reszhalmaz = true;
            foreach (string allomas in v1)
            {
                if (!v2.Contains(allomas))
                {
                    reszhalmaz = false;
                }
            }
            return reszhalmaz;
        }

        static int KozosekSzama(HashSet<string> v1, HashSet<string> v2)
        {
            HashSet<string> metszet = new HashSet<string>(v1);
            metszet.IntersectWith(v2);
            return metszet.Count;
        }

        static int KozosekSzama2(HashSet<string> v1, HashSet<string> v2)
        {
            int db = 0;
            foreach (string elem in v1)
            {
                if (v2.Contains(elem))
                {
                    db++;
                }
            }
            return db;
        }

        static int KozosekSzama3(HashSet<string> v1, HashSet<string> v2)
        {
            List<string> vonat1 = new List<string>(v1);
            List<string> vonat2 = new List<string>(v2);
            int db = 0;
            for (int i = 0; i < vonat1.Count; i++)
            {
                if (Eleme(vonat1[i], vonat2))
                {
                    db++;
                }
            }
            return db;
        }

        static bool Eleme(string e, List<string> lista)
        {
            int i = 0;
            while (i < lista.Count && !(lista[i] == e))
            {
                i++;
            }
            return i < lista.Count;
        }

        static void Kiir(HashSet<string> halmaz)
        {
            Console.WriteLine("a) ");
            foreach (string elem in halmaz)
            {
                Console.WriteLine(elem);
            }
        }

        static HashSet<string> CsakElsoAllomasok(HashSet<string> v1, HashSet<string> v2)
        {
            HashSet<string> eredmeny = new HashSet<string>();
            foreach (string allomas in v1)
            {
                if (!v2.Contains(allomas))
                {
                    eredmeny.Add(allomas);
                }
            }
            return eredmeny;
        }
    }
}
