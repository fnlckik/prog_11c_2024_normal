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
            //Beolvas1(nevek, primek);
            //Beolvas2(nevek, primek);
            Beolvas(nevek, primek);
            Kiir(nevek, primek);
            //Hozzafuz(nevek, primek);
        }

        static void Hozzafuz(List<string> nevek, List<int> primek)
        {
            //StreamWriter writer = new StreamWriter("valtozo.txt", true);
            StreamWriter writer = new StreamWriter("valtozo.txt", append: true);
            for (int i = 0; i < nevek.Count; i++)
            {
                writer.WriteLine(nevek[i] + ": " + primek[i]);
            }
            writer.WriteLine("--------------------");
            Console.WriteLine("Az adatok fájl végére írása megtörtént!");
            writer.Close();
        }

        // Na ez már szép!
        static void Beolvas(List<string> nevek, List<int> primek)
        {
            StreamReader reader = new StreamReader("primek.txt");
            while (!reader.EndOfStream)
            {
                string sor = reader.ReadLine();
                string[] adatok = sor.Split();
                nevek.Add(adatok[0]);
                primek.Add(int.Parse(adatok[1]));
            }
            reader.Close();
        }

        // Majdnem...
        static void Beolvas2(List<string> nevek, List<int> primek)
        {
            StreamReader reader = new StreamReader("primek.txt");
            string sor = reader.ReadLine();
            while (sor != null)
            {
                string[] adatok = sor.Split();
                nevek.Add(adatok[0]);
                primek.Add(int.Parse(adatok[1]));
                sor = reader.ReadLine();
            }
            reader.Close();
        }

        static void Kiir(List<string> nevek, List<int> primek)
        {
            StreamWriter writer = new StreamWriter("kimenet.txt");
            for (int i = 0; i < nevek.Count; i++)
            {
                writer.WriteLine(nevek[i] + ": " + primek[i]);
            }
            Console.WriteLine("Az adatok fájlba írása megtörtént!");
            writer.Close();
        }

        // Mj.: Én nem szeretem
        static void Beolvas1(List<string> nevek, List<int> primek)
        {
            string[] sorok = File.ReadAllLines("primek.txt");
            foreach (string sor in sorok)
            {
                string[] adatok = sor.Split(' '); // { "Anna", "7" }
                nevek.Add(adatok[0]);
                primek.Add(int.Parse(adatok[1]));
            }
        }
    }
}
