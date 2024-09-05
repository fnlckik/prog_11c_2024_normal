using System;

namespace BeolvasKiir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 0. Írjuk ki, hogy "Hello Világ!"
            // Console.WriteLine("Hello Világ!");

            // 1. Köszöntsünk valakit a nevén!
            string nev;
            nev = Console.ReadLine();
            Console.WriteLine("Szia " + nev + "!");

            Console.ReadKey();
        }
    }
}
