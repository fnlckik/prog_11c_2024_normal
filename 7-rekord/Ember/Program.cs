using System;

namespace Ember
{
    internal class Program
    {
        // Rekord: adatok egységbe zárása (struct)
        // OOP: Objektum Orientált Programozás
        // Készítsünk egy saját típust!
        // Adattag: tulajdonság (attribútum)
        struct Ember
        {
            public string nev;
            public int kor;
            public double magassag; // méterben
        }

        static void Main(string[] args)
        {
            //Random r = new Random();
            //Stopwatch ora = new Stopwatch();
            //List<int> lista = new List<int> { 2, 5, 1 };
            //Int32 szam;
            //String szoveg;

            Ember bela; // objektum
            bela.nev = "Béla";
            bela.kor = 52;
            bela.magassag = 1.4;

            // példányosítás
            Ember lajos = new Ember { nev = "Lajos", kor = 12, magassag = 1.23 };

            Console.WriteLine($"Embereink nevei: {bela.nev}, {lajos.nev}");
            //Console.WriteLine($"{bela.nev} vagyok, {bela.kor} éves.");
            //Console.WriteLine($"{lajos.nev} vagyok, {lajos.kor} éves.");
            Bemutatkozas(bela);
            Bemutatkozas(lajos);
        }

        // Ember: struktúra
        // ember: objektum
        static void Bemutatkozas(Ember ember)
        {
            Console.WriteLine($"{ember.nev} vagyok, {ember.kor} éves.");
        }
    }
}
