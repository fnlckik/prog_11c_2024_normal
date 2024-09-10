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
            //double a, b;
            //Console.Write("a: ");
            //a = Convert.ToDouble(Console.ReadLine());
            //Console.Write("b: ");
            //b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"Terület: {a*b}");

            // Mj: float megadása programban
            // float x = 1.4f;

            // Implicit konverzió
            //float x = 5;

            // 3. Hányados
            int a, b;
            Console.Write("a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Hányados: {Convert.ToDouble(a) / Convert.ToDouble(b)}");
            Console.WriteLine($"Hányados: {Convert.ToDouble(a) / b}");
            Console.WriteLine($"Hányados: {(double)a / b}");
            Console.WriteLine($"Hányados: {1.0 * a / b:0.00}");
            Console.WriteLine($"Hányados: {1d * a / b:0 000.000}");
            
            Console.ReadKey();
        }
    }
}
