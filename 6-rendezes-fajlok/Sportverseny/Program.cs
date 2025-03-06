using System;
using System.Collections.Generic;
using System.IO;

namespace Sportverseny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nevek = new List<string>();
            List<string> orszagok = new List<string>();
            List<int> pontok = new List<int>();
            Beolvas(nevek, orszagok, pontok);
            Rendez(nevek, orszagok, pontok);
            Kiir(nevek, orszagok, pontok);
            // "ALMA".ToLower()

            /*
                s1.CompareTo(s2):
                    -1: ha s1 < s2
                     1: ha s1 > s2
                     0: ha s1 = s2
            */
        }

        static void Kiir(List<string> nevek, List<string> orszagok, List<int> pontok)
        {
            StreamWriter sw = new StreamWriter("rendezett.txt");
            for (int i = 0; i < nevek.Count; i++)
            {
                sw.WriteLine($"{nevek[i]} ({orszagok[i]}) - {pontok[i]}");
            }
            sw.Close();
            Console.WriteLine("Fájlba írás megtörtént!");
        }

        static void Rendez(List<string> nevek, List<string> orszagok, List<int> pontok)
        {
            // i: Hány rendezett elem van már a tömb végén!
            for (int i = 0; i < pontok.Count; i++)
            {
                for (int j = 0; j < pontok.Count - i - 1; j++)
                {
                    // Operator precedence: az "és" művelet erősebb a "vagy"-nál
                    // Elhagyva innen a zárójeleket, ugyanazt kapjuk:
                    // A vagy (B és C) vagy (D és E)
                    if (pontok[j] < pontok[j+1] || 
                        pontok[j] == pontok[j+1] && nevek[j].CompareTo(nevek[j+1]) == 1)
                    {
                        Csere(pontok, j, j + 1);
                        Csere(nevek, j, j + 1);
                        Csere(orszagok, j, j + 1);
                    }
                }
            }
        }

        static void Csere<T>(List<T> pontok, int i, int j)
        {
            (pontok[i], pontok[j]) = (pontok[j], pontok[i]);
        }

        static void Beolvas(List<string> nevek, List<string> orszagok, List<int> pontok)
        {
            // Comma Seperated Value
            StreamReader sr = new StreamReader("../../eredmeny.csv");
            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(','); // { "Klaus Becker", "GER", "85" }
                nevek.Add(sor[0]);
                orszagok.Add(sor[1]);
                pontok.Add(int.Parse(sor[2]));
                /*
                string sor = sr.ReadLine();
                int db = 0;
                string s = "";
                foreach (char c in sor)
                {
                    if (c != ',')
                    {
                        s += c;
                    }
                    else if (c == ',' && db == 0)
                    {
                        nevek.Add(s);
                        s = "";
                        db++;
                    }
                    else if (c == ',' && db == 1)
                    {
                        orszagok.Add(s);
                        s = "";
                        db++;
                    }
                    else
                    {
                        pontok.Add(int.Parse(s));
                    }
                }
                */
            }
            sr.Close();
        }
    }
}
