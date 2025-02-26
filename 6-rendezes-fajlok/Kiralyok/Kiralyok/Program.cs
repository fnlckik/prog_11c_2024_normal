using System;
using System.Collections.Generic;
using System.IO;

namespace Kiralyok
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> nevek = new List<string>();
            List<int> kezdev = new List<int>();
            List<int> idosav = new List<int>();
            Beolvas(nevek, kezdev, idosav);
        }

        static void Beolvas(List<string> nevek, List<int> kezdev, List<int> idosav)
        {
            StreamReader reader = new StreamReader("adatok.txt");
            while (!reader.EndOfStream)
            {
                string sor = reader.ReadLine();
                string[] adatok = sor.Split(',');
                nevek.Add(adatok[0]);
                kezdev.Add(int.Parse(adatok[1]));
                idosav.Add(int.Parse(adatok[2]));
            }
            reader.Close();
        }
    }
}
