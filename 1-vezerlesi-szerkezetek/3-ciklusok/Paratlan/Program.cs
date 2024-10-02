using System;

namespace Paratlan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            // r.Next(5) => 0, 1, 2, 3, 4
            // r.Next(5) * 2 => 0, 2, 4, 6, 8
            // r.Next(5) * 2 + 1 => 1, 3, 5, 7, 9

            // "alma" + "fa" == "almafa"
            string szam = ""; // "3191137"
            for (int i = 0; i < 7; i++)
            {
                int szamjegy = r.Next(5) * 2 + 1;
                szam = szam + szamjegy;
            }

            Console.WriteLine($"Generált 7 jegyű páratlan szám: {szam}");

            Console.ReadKey();
        }
    }
}
