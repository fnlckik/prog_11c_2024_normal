using System;
using System.Collections.Generic;
using System.IO;

namespace Jegyek
{
    class Csoport
    {
        private Random r = new Random();
        private int letszam;
        private List<Diak> diakok = new List<Diak>();

        // Diák életkora: 14-19
        // r.NextDouble();
        public Csoport(int n)
        {
            List<string> nevek = Beolvas();
            this.letszam = n;
            for (int i = 0; i < n; i++)
            {
                int kor = this.r.Next(14, 20);
                double hangulat = this.r.Next(0, 101) * 0.01;
                int index = this.r.Next(nevek.Count);
                string nev = nevek[index];
                Diak d = new Diak(nev, kor, hangulat);
                this.diakok.Add(d);
            }
        }

        public int Letszam { get => this.letszam; }

        // Tivadar vagyok, 87 éves. Hangulatom: 11%
        // Tivadar vagyok, 87 éves. Hangulatom: 11%
        // Tivadar vagyok, 87 éves. Hangulatom: 11%
        public override string ToString()
        {
            string s = "";
            foreach (Diak diak in this.diakok)
            {
                s += diak + $" Hangulatom: {diak.Hangulat}%\n";
            }
            return s;
        }

        // 20% valószínűséggel hiányzik valaki
        public void DolgozatIras()
        {
            foreach (Diak diak in this.diakok)
            {
                double sz = this.r.NextDouble(); // [0.00 - 1.00)
                if (sz < 0.8) // 80% valószínűséggel megírja
                {
                    // Elégtelen valószínűsége: 50% (egyébként 2-5)
                    double elegtelen = this.r.NextDouble();
                    if (elegtelen <= 0.5)
                    {
                        diak.JegyetKap(1);
                    }
                    else
                    {
                        int jegy = this.r.Next(2, 6);
                        diak.JegyetKap(jegy);
                    }
                }
            }
        }

        private List<string> Beolvas()
        {
            List<string> nevek = new List<string>();
            StreamReader sr = new StreamReader("nevek.txt");
            while (!sr.EndOfStream)
            {
                string nev = sr.ReadLine();
                nevek.Add(nev);
            }
            sr.Close();
            return nevek;
        }

        public void Naplo()
        {
            foreach (Diak diak in this.diakok)
            {
                diak.KiirJegyek();
            }
        }

        // Egy diák lezárható ha legalább 3 jegye van!
        // Osztályzat: alapvetően matematikai kerekítés
        // Kivéve: 1.8 alatt fixen elégtelen
        public void Lezaras(string fajl)
        {
            StreamWriter sw = new StreamWriter(fajl);
            foreach (Diak diak in this.diakok)
            {
                // "1,75" "1,8"
                // diak.Atlag() >= "1,8"
                // Átment:
                // a) Van legalább 3 jegye
                // b) Az átlaga 1.8-hoz viszonyítva nagyobb vagy egyenlő annál.
                // diak.Atlag().CompareTo("1,8") >= 0
                if (diak.Jegyek.Count >= 3 && double.Parse(diak.Atlag()) >= 1.8)
                {
                    sw.WriteLine($"{diak.Nev}: {Math.Round(double.Parse(diak.Atlag()))}");
                }
                else
                {
                    sw.WriteLine($"{diak.Nev}: PÓTVIZSGA");
                }
            }
            sw.Close();
        }
    }
}
