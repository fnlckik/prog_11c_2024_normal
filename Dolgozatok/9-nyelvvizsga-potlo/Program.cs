using System;

namespace Nyelvvizsga
{
    public class Program
    {
        static void Main(string[] args)
        {
            Statisztika stat = new Statisztika("adatok.txt");
            Vizsga legjobb = stat.LegjobbKomplex();
            Console.WriteLine(legjobb);
            stat.Kiir("eredmenyek.txt");
        }
    }
}
