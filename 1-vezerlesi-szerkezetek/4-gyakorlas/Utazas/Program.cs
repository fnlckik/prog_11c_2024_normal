using System;

namespace Utazas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ora1, perc1, ora2, perc2;
            Console.Write("Indulás óra: ");
            ora1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indulás perc: ");
            perc1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Érkezés óra: ");
            ora2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Érkezés perc: ");
            perc2 = Convert.ToInt32(Console.ReadLine());

            int ido1 = ora1 * 60 + perc1;
            int ido2 = ora2 * 60 + perc2;
            int t = ido2 - ido1;
            int ora = t / 60;
            int perc = t % 60;

            Console.WriteLine($"Utazási idő: {ora} óra {perc} perc.");

            const int bicikli = 4 * 60 + 3;
            if (bicikli < t)
            {
                Console.WriteLine("Biciklivel gyorsabb az út!");
            }
            else if (bicikli > t)
            {
                Console.WriteLine("Vonattal gyorsabb az út!");
            }
            else
            {
                Console.WriteLine("Egyforma mindkét jármű használatával!");
            }

            Console.ReadKey();
        }
    }
}
