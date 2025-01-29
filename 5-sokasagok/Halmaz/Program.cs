using System;
using System.Collections.Generic;

namespace Halmaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> lista = new List<int> { 4, 6, 1, 2, 2, 1, 2 };
            Console.WriteLine(lista.Count);
            Console.WriteLine("A lista 1. eleme: " + lista[0]);
            */

            // Halmaz:
            // 1. Elemeknek nincs sorrendje -> nem indexelhető
            // 2. Egyediek az elemei.
            HashSet<int> halmaz = new HashSet<int> { 4, 6, 1, 2, 2, 1, 2 };
            Console.WriteLine("Halmaz elemszáma: " + halmaz.Count);
            //Console.WriteLine("A halmaz 1. eleme: " + halmaz[0]);

            halmaz.Add(13); // { 4, 6, 1, 2, 13 }
            halmaz.Remove(6);
            Console.WriteLine("Eleme-e a 13-mas? " + halmaz.Contains(13)); // tartalmazza

            Kiir("Halmaz elemei: ", halmaz);

            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            HashSet<string> v1 = new HashSet<string> { "Bence", "Réka", "Máté", "Pisti", "Johanna", "Kata" };
            HashSet<string> v2 = new HashSet<string> { "Máté", "Zalán", "Csaba", "Kata", "Bence" };
            Kiir("1. Verseny: ", v1);
            Kiir("2. Verseny: ", v2);
            Kiir("Mindkettő: ", Metszet(v1, v2));
            Kiir("Legalább egyik verseny: ", Unio(v1, v2));
            Kiir("Csak az 1. versenyen indulók: ", Kulonbseg(v1, v2));

            HashSet<string> bitfarago = new HashSet<string> { "Máté", "Csaba", "Zalán" };
            Console.WriteLine("Részhalmaz(bitfarago, v1)? " + ReszhalmazE(bitfarago, v1)); // false
            Console.WriteLine("Részhalmaz(bitfarago, v2)? " + ReszhalmazE(bitfarago, v2)); // true

            // Van-e olyan, aki mindkét versenyen elindult? (mindkét halmazban benne van)
            Console.WriteLine("VanKozos(bitfarago, v1)? " + VanKozos(bitfarago, v1)); // true

            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            HashSet<string> metszet = new HashSet<string>(v1);
            metszet.IntersectWith(v2);
            Kiir("Mindkettő: ", metszet);

            HashSet<string> unio = new HashSet<string>(v1);
            unio.UnionWith(v2);
            Kiir("Legalább egyik verseny: ", unio);

            HashSet<string> kulonbseg = new HashSet<string>(v1);
            kulonbseg.ExceptWith(v2);
            Kiir("Csak az 1. versenyen indulók: ", kulonbseg);

            Console.WriteLine("Részhalmaz(bitfarago, v1)? " + bitfarago.IsSubsetOf(v1));
            Console.WriteLine("Részhalmaz(bitfarago, v2)? " + bitfarago.IsSubsetOf(v2));
            Console.WriteLine("VanKozos(bitfarago, v1)? " + bitfarago.Overlaps(v1));
        }

        // Van-e közös eleme halmaz1-nek és halmaz2-nek?
        static bool VanKozos(HashSet<string> halmaz1, HashSet<string> halmaz2)
        {
            bool van = false;
            foreach (string elem in halmaz1)
            {
                if (halmaz2.Contains(elem))
                {
                    van = true;
                }
            }
            return van;
        }

        // A halmaz1 részhalmaza-e halmaz2-nek?
        static bool ReszhalmazE(HashSet<string> halmaz1, HashSet<string> halmaz2)
        {
            bool reszhalmaza = true;
            foreach (string elem in halmaz1)
            {
                if (!halmaz2.Contains(elem))
                {
                    reszhalmaza = false;
                }
            }
            return reszhalmaza;
        }

        // Megadja az 1. halmaz azon elemeit, amik a 2. halmazban nincsenek benne
        static HashSet<string> Kulonbseg(HashSet<string> halmaz1, HashSet<string> halmaz2)
        {
            HashSet<string> kulonbseg = new HashSet<string>();
            foreach (string elem in halmaz1)
            {
                if (!halmaz2.Contains(elem))
                {
                    kulonbseg.Add(elem);
                }
            }
            return kulonbseg;
        }

        static HashSet<string> Unio(HashSet<string> halmaz1, HashSet<string> halmaz2)
        {
            // Vigyázat! Ha unio elemeit módosítjuk, akkor az eredeti halmaz is módosul!
            // HashSet<string> unio = halmaz1;
            HashSet<string> unio = new HashSet<string>(halmaz1);
            foreach (string elem in halmaz2)
            {
                unio.Add(elem);
            }
            return unio;
        }

        static HashSet<string> Metszet(HashSet<string> halmaz1, HashSet<string> halmaz2)
        {
            HashSet<string> metszet = new HashSet<string>();
            foreach (string elem in halmaz1)
            {
                if (halmaz2.Contains(elem))
                {
                    metszet.Add(elem);
                }
            }
            return metszet;
        }

        static void Kiir<T>(string szoveg, HashSet<T> halmaz)
        {
            Console.Write(szoveg);
            Console.Write("{ ");
            int db = 0;
            foreach (T elem in halmaz)
            {
                db++;
                if (db < halmaz.Count)
                {
                    Console.Write(elem + ", ");
                }
                else
                {
                    Console.Write(elem);
                }
            }
            Console.WriteLine(" }");
        }
    }
}
