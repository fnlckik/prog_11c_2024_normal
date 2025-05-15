using System;
using System.Collections.Generic;

namespace Jegyek
{
    class Csoport
    {
        private int letszam;
        private List<Diak> diakok = new List<Diak>();

        // Diák életkora: 14-19
        // r.NextDouble();
        public Csoport(int n)
        {
            this.letszam = n;
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                int kor = r.Next(14, 20);
                double hangulat = r.Next(0, 101) * 0.01;
                Diak d = new Diak("Tivadar", kor, hangulat);
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
    }
}
