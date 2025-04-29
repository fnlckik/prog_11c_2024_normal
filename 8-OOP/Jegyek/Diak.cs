using System;

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

        // function overloading (függvény túlterhelés)
        // Ugyanazon névvel, más paraméterezéssel többféle függvény is készíthető
        public Diak() { }

        // this: az aktuális objektum példány
        public Diak(string nev, int kor, double hangulat)
        {
            this.nev = nev;
            this.kor = kor;
            this.hangulat = hangulat;
            Console.WriteLine("Létrejött az objektum egy példánya!");
        }

        public string Bemutatkozas()
        {
            return $"{this.nev} vagyok, {this.kor} éves.";
        }

        public string ToString()
        {
            return $"{this.nev} vagyok, {this.kor} éves.";
        }
    }
}
