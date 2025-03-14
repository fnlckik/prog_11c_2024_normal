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

            Ember frigyes = new Ember
            {
                nev = "Frigyes",
                kor = 73,
                magassag = 2.2
            };
            Bemutatkozas(frigyes);

            // Igaz-e, hogy Béla alacsonyabb Lajosnál?
            //Console.WriteLine("Béla alacsonyabb Lajosnál? " + (bela.magassag < lajos.magassag));
            Console.WriteLine($"Béla alacsonyabb Lajosnál? {bela.magassag < lajos.magassag}");

            Ember legmagasabb = Legmagasabb(bela, lajos, frigyes);
            Console.WriteLine($"Legmagasabb ember: {legmagasabb.nev}");

            Console.WriteLine($"Átlagos életkor: {Atlag(bela, lajos, frigyes)}");

            Szulinap(ref bela);
            Bemutatkozas(bela);
        }

        // Vigyázat! Érték szerinti paraméter átadásnál másolás történik!
        // Új Ember objektum a memóriában!
        // NODE! Referencia szerinti paraméter átadásnál már tudjuk módosítani!
        static void Szulinap(ref Ember ember)
        {
            //ember.nev = "Robi";
            ember.kor++;
        }

        static double Atlag(Ember e1, Ember e2, Ember e3)
        {
            double atlag = (double)(e1.kor + e2.kor + e3.kor) / 3;
            return Math.Round(atlag, 2);
        }

        static Ember Legmagasabb(Ember e1, Ember e2, Ember e3)
        {
            Ember e = e1;
            if (e2.magassag > e.magassag) e = e2;
            if (e3.magassag > e.magassag) e = e3;
            return e;
            //if (e1.magassag >= e2.magassag && e1.magassag >= e3.magassag)
            //{
            //    return e1;
            //}
            //else if (e2.magassag >= e3.magassag)
            //{
            //    return e2;
            //}
            //else
            //{
            //    return e3;
            //}
        }

        // Ember: struktúra
        // ember: objektum
        static void Bemutatkozas(Ember ember)
        {
            Console.WriteLine($"{ember.nev} vagyok, {ember.kor} éves.");
        }
    }
}
