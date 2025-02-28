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
            Rendezes(nevek, kezdev, idosav);
            Kiir(nevek, kezdev, idosav);
        }

        static void Kiir(List<string> nevek, List<int> kezdev, List<int> idosav)
        {
            StreamWriter writer = new StreamWriter("uralkodok.txt");
            for (int i = 0; i < nevek.Count; i++)
            {
                int vegev = kezdev[i] + idosav[i];
                writer.WriteLine($"{nevek[i]} ({kezdev[i]}-{vegev})");
            }
            writer.Close();
            Console.WriteLine("Sikeres fájlba írás! (uralkodok.txt)");
        }

        static void Rendezes(List<string> nevek, List<int> kezdev, List<int> idosav)
        {
            for (int i = 0; i < idosav.Count; i++)
            {
                // Ki kerül az "i"-dik helyre? (Ezt jelöli a "k".)
                int k = i; // maxi = i
                for (int j = k; j < idosav.Count; j++)
                {
                    // Mikor akarjuk, hogy "k"-adik helyre kerüljön a "j"?
                    // 1. Tovább uralkodott a "j"-edik, mint a "k"-adik.
                    // 2. Ugyanaddig uralkodtak ÉS a "j"-edik királyt korábban koronázták.
                    if (idosav[j] > idosav[k] || 
                        idosav[j] == idosav[k] && kezdev[j] < kezdev[k])
                    {
                        k = j;
                    }
                }
                Csere(idosav, i, k);
                Csere(kezdev, i, k);
                Csere(nevek, i, k);
            }
        }

        static void Csere<T>(List<T> lista, int i, int j)
        {
            (lista[i], lista[j]) = (lista[j], lista[i]);
            //T seged = lista[i];
            //lista[i] = lista[j];
            //lista[j] = seged;
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
