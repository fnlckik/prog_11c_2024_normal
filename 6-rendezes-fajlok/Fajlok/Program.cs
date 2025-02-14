using System;
using System.Collections.Generic;
using System.IO;

namespace Fajlok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nevek = new List<string>();
            List<int> primek = new List<int>();
            Beolvas(nevek, primek);
            Kiir(nevek, primek);
        }

        static void Kiir(List<string> nevek, List<int> primek)
        {
            for (int i = 0; i < nevek.Count; i++)
            {
                Console.WriteLine(nevek[i] + ": " + primek[i]);
            }
        }

        static void Beolvas(List<string> nevek, List<int> primek)
        {
            string[] sorok = File.ReadAllLines("../../primek.txt");
            foreach (string sor in sorok)
            {
                string[] adatok = sor.Split(' '); // { "Anna", "7" }
                nevek.Add(adatok[0]);
                primek.Add(int.Parse(adatok[1]));
            }
        }
    }
}
