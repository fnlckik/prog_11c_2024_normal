using System;

namespace Fuggvenyek_n
{
    internal class Program
    {
        static double Terulet(double a)
        {
            return Math.Sqrt(3) * a * a / 4;
        }

        static void Kiir(int[] t, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(t[i] + " ");
            }
            Console.WriteLine();
        }

        static int[] Kivalogat(int[] x, out int db)
        {
            int[] y = new int[100];
            db = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 4 == 0)
                {
                    y[db] = x[i];
                    db++;
                }
            }
            return y;
        }

        static bool VanOtos(int n)
        {
            string szam = Convert.ToString(n);
            int i = 0;
            while (i < szam.Length && !(szam[i] == '5'))
            {
                i++;
            }
            return i < szam.Length;
        }

        static int OtosSzamokSzama(int n)
        {
            int db = 0;
            for (int i = 1; i <= n; i++)
            {
                if (VanOtos(i))
                {
                    db++;
                }
            }
            return db;
        }

        static void Main(string[] args)
        {
            // F1
            Console.WriteLine("F1:");
            Console.WriteLine($"{Terulet(5):0.00}");
            Console.WriteLine($"{Terulet(2.6321):0.00}");

            // F2
            Console.WriteLine("\nF2:");
            Kiir(new int[] {5, 13, -2, 3}, 4);

            // F3
            Console.WriteLine("\nF3:");
            int[] x = { 1996, -48, 11614, 452, -818, 2024 };
            int[] y = Kivalogat(x, out int db);
            Kiir(y, db);

            // F4
            Console.WriteLine("\nF4:");
            Console.WriteLine(VanOtos(9132546));
            Console.WriteLine(VanOtos(3052551));
            Console.WriteLine(VanOtos(138861));

            // F5
            Console.WriteLine("\nF5:");
            Console.WriteLine(OtosSzamokSzama(80));
            Console.WriteLine(OtosSzamokSzama(820));
        }
    }
}
