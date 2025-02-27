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
