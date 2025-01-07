using System;

namespace Feleves_n
{
    internal class Program
    {
        static void Beolvas(string[] varosok, int[] dalok, out int n)
        {
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] sor = Console.ReadLine().Split(' ');
                varosok[i] = sor[0];
                dalok[i] = Convert.ToInt32(sor[1]);
            }
        }

        static string Keres(string[] varosok, int[] dalok, int n)
        {
            int i = 0;
            while (i < n && !(dalok[i] % 2 == 1))
            {
                i++;
            }
            if (i < n)
            {
                return varosok[i];
            }
            else
            {
                return "Nincs ilyen!";
            }
        }

        static bool TartalmazE(string varos)
        {
            int i = 0;
            while (i < varos.Length && !(varos[i] == 'E' || varos[i] == 'e'))
            {
                i++;
            }
            return i < varos.Length;
        }

        static int Megszamol(string[] varosok, int n)
        {
            int db = 0;
            for (int i = 0; i < n; i++)
            {
                if (TartalmazE(varosok[i]))
                {
                    db++;
                }
            }
            return db;
        }

        static void Main(string[] args)
        {
            // F1
            string[] varosok = new string[50];
            int[] dalok = new int[50];
            Beolvas(varosok, dalok, out int n);

            // F2
            Random r = new Random();
            Console.WriteLine($"2. {varosok[0]} {r.Next(10, 21)}");

            // F3
            int maxi = 0;
            for (int i = 0; i < n; i++)
            {
                if (dalok[i] > dalok[maxi])
                {
                    maxi = i;
                }
            }
            double sz = (double)dalok[maxi] / 43 * 100;
            Console.WriteLine($"3. {varosok[maxi]} {sz:0.00}%");

            // F4
            string varos = Keres(varosok, dalok, n);
            Console.WriteLine($"4. {varos}");

            // F5
            int db = Megszamol(varosok, n);
            Console.WriteLine($"5. {db} darab");
        }
    }
}
