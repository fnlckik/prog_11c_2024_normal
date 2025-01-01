using System;

namespace Vegyes
{
    internal class Program
    {
        static double Terulet(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double t = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return t;
        }

        static string[] Kivalogat(string[] szavak, out int db)
        {
            // Tegyük fel, hogy legfeljebb 1000 szavas az eredeti tömb.
            string[] eredmeny = new string[1000];
            db = 0;
            for (int i = 0; i < szavak.Length; i++)
            {
                int hossz = szavak[i].Length;
                if (szavak[i][0] == szavak[i][hossz - 1])
                {
                    eredmeny[db] = szavak[i];
                    db++;
                }
            }
            return eredmeny;
        }

        static void Kiir(string[] x, int db)
        {
            Console.Write("2. ");
            for (int i = 0; i < db; i++)
            {
                Console.Write(x[i] + " ");
            }
            Console.WriteLine();
        }

        static bool VanSZ(string s)
        {
            int i = 0;
            while (i < s.Length-1 && !(s[i] == 's' && s[i+1] == 'z'))
            {
                i++;
            }
            return i < s.Length - 1;
        }

        static void General()
        {
            Console.Write("4. ");
            Random r = new Random();
            int n;
            do
            {
                n = r.Next(10, 100); // min: 10, max: 99
                Console.Write(n + " ");
            } while (n % 7 != 0);
            Console.WriteLine();
        }

        static double AtlagAr(int[,] m)
        {
            double s = 0;
            int sorok = m.GetLength(0);
            int oszlopok = m.GetLength(1);
            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    s += m[i, j];
                }
            }
            int n = m.Length; // elemek száma
            return s / n;
        }

        static void HolOlcsok(int[,] m)
        {
            Console.Write("b) ");
            int sorok = m.GetLength(0);
            int oszlopok = m.GetLength(1);
            // Soronként járjuk be a mátrixot!
            for (int i = 0; i < sorok; i++)
            {
                int minhely = 0;
                for (int j = 0; j < oszlopok; j++)
                {
                    if (m[i, j] < m[i, minhely])
                    {
                        minhely = j;
                    }
                }
                Console.Write(minhely+1+" ");
            }
            Console.WriteLine();
        }

        static void MelyikOlcsok(int[,] m)
        {
            Console.Write("c) ");
            int sorok = m.GetLength(0);
            int oszlopok = m.GetLength(1);
            // Oszloponként járjuk be a mátrixot!
            for (int i = 0; i < oszlopok; i++)
            {
                int mincukor = 0;
                for (int j = 0; j < sorok; j++)
                {
                    if (m[j, i] < m[mincukor, i])
                    {
                        mincukor = j;
                    }
                }
                Console.Write(mincukor + 1 + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // F1
            Console.WriteLine($"1. T = {Terulet(8.25, 10.63, 9):0.}"); // 36

            // F2
            string[] szavak = { "alma", "korte", "citrom", "sas", "radír", "egér" };
            string[] x = Kivalogat(szavak, out int db);
            Kiir(x, db);

            // F3
            Console.WriteLine("3. ");
            Console.WriteLine(VanSZ("ablak")); //false
            Console.WriteLine(VanSZ("szaloncukor")); //true
            Console.WriteLine(VanSZ("Reszkessetek betörők!")); //true
            Console.WriteLine(VanSZ("darázs")); //false
            Console.WriteLine(VanSZ("halász")); //true

            // F4
            General();

            // F5
            Console.WriteLine("5.");
            int[,] m = {
                {1870, 2300, 3155}, // 1. típus
                {3252, 2720, 3800}, // 2. típus
                {4500, 3879, 3999}, // 3. típus
                {3100, 2999, 2890}, // 4. típus
                {2250, 2100, 3450}  // 5. típus
            };
            Console.WriteLine($"a) {AtlagAr(m):0.00}");
            HolOlcsok(m); // Adott típus hol a legolcsóbb?
            MelyikOlcsok(m); // Adott helyen melyik a legolcsóbb?
        }
    }
}
