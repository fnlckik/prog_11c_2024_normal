using System;

namespace Idokonverzio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int ora = r.Next(24); // 9
            int perc = r.Next(60); // 52
            int mperc = r.Next(60); // 46
            Console.WriteLine($"Idő: {ora:00}:{perc:00}:{mperc:00}");

            int masodperc = ora * 3600 + perc * 60 + mperc; // 35566
            Console.WriteLine($"A nap eleje óta {masodperc} másodperc telt el.");

            int hour = masodperc / 3600; // 9
            int maradek = masodperc % 3600; // 3166
            int minute = maradek / 60; // 52
            int second = maradek % 60; // 46

            Console.WriteLine($"Visszaváltva: {hour} óra {minute} perc {second} másodperc.");

            Console.ReadKey();
        }
    }
}
