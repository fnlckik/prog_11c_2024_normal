using System;
using System.Collections.Generic;
using System.IO;

namespace Termekek
{
    internal class Program
    {
        struct Termek // Product
        {
            public string nev; // name
            public int ar; // prince
            public bool elelmiszerE; // isFood
        }

        static void Main(string[] args)
        {
            List<Termek> termekek = new List<Termek>(); // products
            Beolvas(termekek);
            Kiir(termekek);
        }

        static void Kiir(List<Termek> termekek)
        {
            for (int i = 0; i < termekek.Count; i++)
            {
                //string tipus;
                //if (termekek[i].elelmiszerE)
                //{
                //    tipus = "élelmiszer";
                //}
                //else
                //{
                //    tipus = "tárgy";
                //}
                string tipus = termekek[i].elelmiszerE ? "élelmiszer" : "tárgy"; 
                Console.WriteLine($"{termekek[i].nev}: {termekek[i].ar} Ft ({tipus})");
            }
        }

        static void Beolvas(List<Termek> termekek)
        {
            StreamReader sr = new StreamReader("termekek.txt");
            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(';');
                Termek termek = new Termek
                {
                    nev = sor[0],
                    ar = int.Parse(sor[1]),
                    elelmiszerE = int.Parse(sor[2]) == 1
                };
                termekek.Add(termek);
            }
            sr.Close();
        }
    }
}
