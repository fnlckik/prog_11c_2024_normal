using System;
using System.Collections.Generic;

namespace Villamost_35
{
    public class Allomas
    {
        public int tavolsag;
        public int erkezes;
        public int indulas;

        public Allomas(int tavolsag, int erkezes, int indulas)
        {
            this.tavolsag = tavolsag;
            this.erkezes = erkezes;
            this.indulas = indulas;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            // Beolvasas
            List<Allomas> allomasok = new List<Allomas>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] sor = Console.ReadLine().Split(' ');
                int tavolsag = int.Parse(sor[0]);
                int erkezes = int.Parse(sor[1]);
                int indulas = int.Parse(sor[2]);
                Allomas allomas = new Allomas(tavolsag, erkezes, indulas);
                allomasok.Add(allomas);
            }
            //Console.WriteLine(allomasok.Count);

            // Feldolgozas!
            List<int> indexek = new List<int>(); // 0-tól
            indexek.Add(0); // "beleértve az elsőt is"
            int elozo = allomasok[0].erkezes; // Mennyi idő volt az előzőre érkezni?
            for (int i = 1; i < n; i++)
            {
                int aktualis = allomasok[i].erkezes - allomasok[i - 1].indulas;
                //Console.WriteLine($"{elozo} {aktualis}");
                if (aktualis > elozo)
                {
                    indexek.Add(i);
                }
                elozo = aktualis;
            }

            // Kiiras
            Console.Write(indexek.Count + " ");
            for (int i = 0; i < indexek.Count; i++)
            {
                Console.Write(indexek[i] + 1 + " ");
            }
        }
    }
}
