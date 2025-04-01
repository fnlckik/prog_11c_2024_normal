using System;
using System.Collections.Generic;
using System.IO;

namespace Nyelvek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nyelvek = new List<string>();
            List<int> beszelok = new List<int>();
            int nepesseg = Beolvas(nyelvek, beszelok);
            Rendez(nyelvek, beszelok);
            Kiir(nyelvek, beszelok, nepesseg);
        }

        static void Kiir(List<string> nyelvek, List<int> beszelok, int nepesseg)
        {
            StreamWriter sw = new StreamWriter("nepszeruseg.txt");
            for (int i = 0; i < nyelvek.Count; i++)
            {
                double sz = beszelok[i] / nepesseg * 100;
                sw.WriteLine($"{nyelvek[i]}: {Math.Round(sz, 2)}%");
            }
            sw.Close();
        }

        static void Rendez(List<string> nyelvek, List<int> beszelok)
        {
            for (int i = 0; i < nyelvek.Count; i++)
            {
                int k = i; // Maximumos rendezés
                for (int j = i; j < nyelvek.Count; j++)
                {
                    if (beszelok[j] > beszelok[k])
                    {
                        k = j;
                    }
                }
                (nyelvek[i], nyelvek[k]) = (nyelvek[k], nyelvek[i]);
                (beszelok[i], beszelok[k]) = (beszelok[k], beszelok[i]);
            }
        }

        static int Beolvas(List<string> nyelvek, List<int> beszelok)
        {
            //StreamReader sr = new StreamReader("../../../data.txt");
            StreamReader sr = new StreamReader("data.txt");
            int nepesseg = int.Parse(sr.ReadLine());
            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split('#');
                nyelvek.Add(sor[0]);
                beszelok.Add(int.Parse(sor[1]));
            }
            sr.Close();
            return nepesseg;
        }
    }
}
