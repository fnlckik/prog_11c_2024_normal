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
            //double[] tomegek = { 22.3, 120, 70.5, 180.44, 35, 28, 140.12, 80, 160.9, 50.8, 30, 24 };
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

            // F3 - Feltételes átlag = Összegzés + Megszámolás
            double osszeg = 0;
            int db = 0;
            for (i = 0; i < n; i++)
            {
                if (tomegek[i] < 20)
                {
                    osszeg += tomegek[i];
                    db++;
                }
            }
            if (db == 0)
            {
                Console.WriteLine("3. Nincs 20 kg alatti csomag!");
            }
            else
            {
                double atlag = osszeg / db;
                Console.WriteLine($"3. {atlag:0.00} kg");
            }
            // NaN: Not a Number, jellemzően 0/0 esetén fordul elő.

            // F4 - Eldöntés (optimista eldöntés)
            // Van-e 5-nél kisebb vagy egyenlő szám?
            // Van => Nem igaz!
            // Nincs => Igaz!
            i = 0;
            while (i < n && !(tomegek[i] <= 5))
            {
                i++;
            }
            if (i < n) // Megtaláltam a keresett elemet: van 5-nél kisebb vagy egyenlő
            {
                Console.WriteLine("4. Nem igaz, hogy mindegyik 5-nél nagyobb tömegű!");
            }
            else
            {
                Console.WriteLine("4. Igaz, hogy mindegyik 5-nél nagyobb tömegű!");
            }

            Console.ReadKey();
        }
    }
}
