using System;

namespace Repter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nevek = { "Kovács Anna", "Nagy Péter", "Szabó Éva", "Tóth Márk",
                               "Kiss Júlia", "Molnár Tamás", "Farkas Dóra", "Horváth István",
                               "Varga Krisztina", "Simon Balázs", "Lukács Zoltán", "Takács Emese" };
            double[] tomegek = { 22.3, 12, 7.5, 18.44, 35, 28, 14.12, 8, 16.9, 5.8, 30, 24 };
            // 12 elemünk van!
            int n = tomegek.Length;

            // Deklarálom a ciklusváltozót, amit használunk
            // Ez így nagyon csúnya!
            int i;

            // F1 - Minimum kiválasztás
            // mini: a legkisebb elem indexe
            int mini = 0;
            for (i = 1; i < n; i++)
            {
                if (tomegek[i] < tomegek[mini])
                {
                    mini = i;
                }
            }
            Console.WriteLine("1. " + nevek[mini]);

            // F2 - Keresés = Eldöntés + Kiválasztás
            i = 0;
            while (i < n && !(tomegek[i] > 30))
            {
                i++;
            }
            if (i < n)
            {
                Console.WriteLine("2. " + nevek[i]);
            }
            else
            {
                Console.WriteLine("2. Nincs ilyen!");
            }

            // 3. Feltételes átlag = Összegzés + Megszámolás


            Console.ReadKey();
        }
    }
}
