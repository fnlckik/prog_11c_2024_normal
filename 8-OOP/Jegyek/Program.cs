using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;

namespace Jegyek
{
    // Osztály: egységbe zárja az objektumok
    // 1. Adattagjait (field) - mező
    // 2. Műveleteit (method) - metódus
    class Diak
    {
        public string nev;
        public int kor;
        public double hangulat; // 0.00-1.00 százalékos érték

        public Diak() { }

        public Diak(string nev, int kor, double hangulat)
        {

        }
    }

    internal class Program
    {
        struct Tanulo
        {
            public string nev;
            public int kor;
            public double hangulat; // 0.00-1.00
        }

        // OOP: objektum orientált programozás
        static void Main(string[] args)
        {
            //Korabban();

            // Példányosítás: létrejön az osztályból egy konkrét objektum példány
            // Konstruktor: az a függvény, ami példányosítás során lefut
            Diak adel = new Diak();
            adel.nev = "Adél";
            adel.kor = 17;
            adel.hangulat = 0.83;

            Diak bela = new Diak("Béla", 15, 0.42);
        }

        static string Bemutatkozas(Tanulo t)
        {
            return $"{t.nev} vagyok, {t.kor} éves.";
        }

        // Procedurális programozás
        static void Korabban()
        {
            Tanulo adel;
            adel.nev = "Adél";
            adel.kor = 17;
            adel.hangulat = 0.83;

            Tanulo bela = new Tanulo
            {
                nev = "Béla",
                kor = 15,
                hangulat = 0.42
            };

            Tanulo csaba = new Tanulo
            {
                nev = "Csaba",
                kor = 18,
                hangulat = 0.13
            };

            Console.WriteLine(Bemutatkozas(adel));
            Console.WriteLine(Bemutatkozas(bela));
            Console.WriteLine(Bemutatkozas(csaba));
        }
    }
}
