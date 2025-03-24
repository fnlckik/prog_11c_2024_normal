using System;
using System.Collections.Generic;

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

        struct Savszorzo
        {
            public int a;
            public int b;
            public int c;
        }

        // int a, b, c
        // List<int> (3 elemű)
        // struct Savszorzo (adattagok: a, b, c)
        // Dictionary<char, int>
        static void Main(string[] args)
        {
            List<Lakas> lakasok = new List<Lakas>();
            Beolvas(lakasok);

            Lakas x = new Lakas { sav = 'A', terulet = 180 };

            int ado;
            // 1. verzio
            //int a = 800;
            //int b = 600;
            //int c = 100;
            //if (x.sav == 'A')
            //{
            //    ado = a * x.terulet;
            //}
            //else if (x.sav == 'B')
            //{
            //    ado = b * x.terulet;
            //}
            //else
            //{
            //    ado = c * x.terulet;
            //}

            // 2. verzio
            //List<int> adok = new List<int> { 800, 600, 100 };
            //if (x.sav == 'A')
            //{
            //    ado = adok[0] * x.terulet;
            //}
            //else if (x.sav == 'B')
            //{
            //    ado = adok[1] * x.terulet;
            //}
            //else
            //{
            //    ado = adok[2] * x.terulet;
            //}

            // 3. verzio
            //Savszorzo savszorzo = new Savszorzo { a = 800, b = 600, c = 100 };
            //if (x.sav == 'A')
            //{
            //    ado = savszorzo.a * x.terulet;
            //}
            //else if (x.sav == 'B')
            //{
            //    ado = savszorzo.b * x.terulet;
            //}
            //else
            //{
            //    ado = savszorzo.c * x.terulet;
            //}

            // 4. verzió
            Dictionary<char, int> adok = new Dictionary<char, int>
            {
                { 'A', 800 },
                { 'B', 600 },
                { 'C', 100 }
            };
            ado = adok[x.sav] * x.terulet;
            Console.WriteLine(ado);
        }

        static void Beolvas(List<Lakas> lakasok)
        {
            
        }
    }
}
