using System;

namespace Filmek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // cim, ev, mufaj, imdb, nezok
            Film film1 = new Film("Az", 2017, "horror", 7.3, 20);
            Film film2 = new Film("Bosszúállók", 2012, "fantasy", 8.4, 50);
            Film film3 = new Film("Vérapó;2022;horror;7,5;15");
            Console.WriteLine($"{film1.cim} {film2.cim} {film3.cim}");

            // Kiir(film1) ===> film1.Kiir() ===> film1.ToString()
            Console.WriteLine(film1); // Az (2017) - 7,3
            Console.WriteLine(film2); // Bosszúállók (2012) - 8,4
            Console.WriteLine(film3); // Vérapó (2022) - 7,5
        }
    }
}
