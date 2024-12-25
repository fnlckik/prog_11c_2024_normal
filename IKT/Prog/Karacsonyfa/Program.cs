using System;

namespace Karacsonyfa
{
    internal class Program
    {
        // Az i. sor első szóközei
        static void Szokozok(int n)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(" ");
            }
        }

        // Az i. sor csillagai
        static void Csillagok(int n, Random r)
        {
            for (int j = 1; j <= n; j++)
            {
                int p = r.Next(1, 101); // p: valószínűség
                if (p <= 20)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (p <= 40)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\u25CF");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.Write("*");
                }
            }
            
        }

        // Konzol szélessége legyen 41 egység!
        // a: trapéz "felső" szélessége
        // b: trapéz "alsó" szélessége
        static void TrapezRajz(int a, int b)
        {
            Random r = new Random();
            int db = a;
            int szokoz = (41-a) / 2; // első sorban ennyi szóköz kell balra és jobbra
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 1; i <= 1 + (b-a) / 2; i++)
            {
                Szokozok(szokoz);
                Csillagok(db, r);
                Console.WriteLine();
                db += 2;
                szokoz--;
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void TorzsRajz(int n, int m)
        {
            int szokoz = (41 - (2 * m - 1)) / 2;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            for (int i = 0; i < n; i++)
            {
                Szokozok(szokoz);
                for (int j = 0; j < m; j++)
                {
                    Console.Write("| ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Clear();
            TrapezRajz(1, 13);
            TrapezRajz(9, 27);
            TrapezRajz(17, 41);
            TorzsRajz(5, 7); // 5 sorba 7 darab vonal a torzs
        }
    }
}
