using System;
using System.Collections.Generic;

namespace Dijazottak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // példányosítás
            List<string> nevek = new List<string>();
            List<int> pontok = new List<int>();
            int n;
            int maxpont;
            Beolvas(nevek, pontok, out n, out maxpont);

            List<string> a = new List<string>(); // I.
            List<string> b = new List<string>(); // II.
            List<string> c = new List<string>(); // III.
            List<string> d = new List<string>(); // nem díjazott
            Szetvalogat(maxpont, pontok, nevek, a, b, c, d);

            Kiir(a);
            Kiir(b);
            Kiir(c);
            Kiir(d);
        }

        static void Kiir(List<string> nevek)
        {
            Console.Write(nevek.Count + ";");
            foreach (string nev in nevek)
            {
                Console.Write(nev + ";");
            }
            Console.WriteLine();
        }

        static void Szetvalogat(int maxpont, List<int> pontok, List<string> nevek, List<string> a, List<string> b, List<string> c, List<string> d)
        {
            for (int i = 0; i < pontok.Count; i++)
            {
                double szazalek = (double)pontok[i] / maxpont * 100;
                if (szazalek >= 90)
                {
                    a.Add(nevek[i]);
                }
                else if (szazalek >= 80)
                {
                    b.Add(nevek[i]);
                }
                else if (szazalek >= 70)
                {
                    c.Add(nevek[i]);
                }
                else
                {
                    d.Add(nevek[i]);
                }
            }
        }

        static void Beolvas(List<string> nevek, List<int> pontok, out int n, out int maxpont)
        {
            // List<string> sor = new List<string>(Console.ReadLine().Split(' '));
            string[] sor = Console.ReadLine().Split(' ');
            //n = Convert.ToInt32(sor[0]);
            //maxpont = Convert.ToInt32(sor[1]);
            n = int.Parse(sor[0]); // "6" => 6
            maxpont = int.Parse(sor[1]);
            for (int i = 0; i < n; i++)
            {
                sor = Console.ReadLine().Split(';'); // { "Angyal Pofa", "90" }
                nevek.Add(sor[0]);
                pontok.Add(int.Parse(sor[1]));
            }
        }
    }
}
