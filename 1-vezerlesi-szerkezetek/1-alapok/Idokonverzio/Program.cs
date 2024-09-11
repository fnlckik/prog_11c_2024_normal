using System;

namespace Idokonverzio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int ora = r.Next(24);
            int perc = r.Next(60);
            int mperc = r.Next(60);
            Console.WriteLine($"Idő: {ora:00}:{perc:00}:{mperc:00}");

            int masodperc = ora * 3600 + perc * 60 + mperc;
            Console.WriteLine($"A nap eleje óta {masodperc} másodperc telt el.");

            Console.ReadKey();
        }
    }
}
