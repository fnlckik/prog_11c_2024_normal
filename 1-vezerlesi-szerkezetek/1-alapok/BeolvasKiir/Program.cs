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
            /*
            string vnev, knev;
            Console.Write("Vezetéknév: ");
            vnev = Console.ReadLine();
            Console.Write("Keresztnév: ");
            knev = Console.ReadLine();
            Console.WriteLine("Szia " + vnev + " " + knev + "!");
            Console.WriteLine("Szia {0} {1}!", vnev, knev);
            Console.WriteLine($"Szia {vnev} {knev}!");
            */

            // 2. Adjuk meg egy téglalap területét!
            double a, b;
            Console.Write("a: ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Write("b: ");
            b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"Terület: {a*b}");

            // Mj: float megadása programban
            // float x = 1.4f;

            Console.ReadKey();
        }
    }
}
