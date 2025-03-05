using System;
using System.IO;

namespace Karsor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Beolvas();
            Tavolsagok(s);
        }

        static void Tavolsagok(string s)
        {
            // Írd ki az aktuális pozíciókat!
            // a = észak, b = kelet, c = dél, d = nyugat
            // P(0;0) -> P(0;1) -> P(-1;1) -> P(-1;0) -> ...
            int x = 0, y = 0; // Kezdő pozíció (origo)
            StreamWriter writer = new StreamWriter("poziciok.txt");
            writer.WriteLine($"P({x}; {y})"); // P(0; 0)
            foreach (char c in s)
            {
                if (c == 'a')
                {
                    y++; // Észak
                }
                else if (c == 'b')
                {
                    x++; // Kelet
                }
                else if (c == 'c')
                {
                    y--; // Dél
                }
                else
                {
                    x--; // Nyugat
                }
                writer.WriteLine($"P({x}; {y})");
            }
            writer.Close();
            // P(29; 23)

            double d = Tavolsag(0, 0, 29, 23);
            Console.WriteLine("Távolság: " + Math.Round(d, 0));
        }

        static double Tavolsag(double a1, double a2, double b1, double b2)
        {
            double negyzet = (b1 - a1) * (b1 - a1) + (b2 - a2) * (b2 - a2);
            return Math.Sqrt(negyzet);
        }

        static string Beolvas()
        {
            StreamReader reader = new StreamReader("../../../karsor.txt");
            string s = reader.ReadLine();
            reader.Close();
            return s;
        }
    }
}
