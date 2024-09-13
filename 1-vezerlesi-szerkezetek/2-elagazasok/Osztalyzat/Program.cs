using System;

namespace Osztalyzat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int osztalyzat = r.Next(1, 6);
            Console.WriteLine($"Generált osztályzat: {osztalyzat}");

            /*
            if (osztalyzat == 1)
            {
                Console.WriteLine("Elégtelen");
            }
            else if (osztalyzat == 2)
            {
                Console.WriteLine("Elégséges");
            }
            else if (osztalyzat == 3)
            {
                Console.WriteLine("Közepes");
            }
            else if (osztalyzat == 4)
            {
                Console.WriteLine("Jó");
            }
            else
            {
                Console.WriteLine("Jeles");
            }
            */

            switch (osztalyzat)
            {
                case 1:
                    Console.WriteLine("Elégtelen");
                    break;
                case 2:
                    Console.WriteLine("Elégséges");
                    break;
                case 3:
                    Console.WriteLine("Közepes");
                    break;
                case 4:
                    Console.WriteLine("Jó");
                    break;
                default:
                    Console.WriteLine("Jeles");
                    break;
            }

            Console.ReadKey();
        }
    }
}
