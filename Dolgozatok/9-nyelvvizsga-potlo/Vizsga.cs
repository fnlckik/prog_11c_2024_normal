using System;
using System.Collections.Generic;

namespace Nyelvvizsga
{
    public class Vizsga
    {
        private string nyelv;
        private int pont;
        private char tipus;

        public Vizsga(string nyelv, char tipus, int pont)
        {
            this.nyelv = nyelv;
            this.tipus = tipus;
            this.pont = pont;
        }

        public string Nyelv { get => nyelv; }
        public int Pont { get => pont; }

        public string Tipus
        {
            set
            {
                HashSet<string> tipusok = new HashSet<string> { "A", "B", "C" };
                if (!tipusok.Contains(value)) return;
                this.tipus = char.Parse(value);
            }

            get
            {
                if (this.tipus == 'A') return "írásbeli";
                else if (this.tipus == 'B') return "szóbeli";
                else return "komplex";
            }
        }

        private double Eredmeny(int tizedes)
        {
            int maxpont;
            if (this.tipus == 'A') maxpont = 90;
            else if (this.tipus == 'B') maxpont = 30;
            else maxpont = 120;
            double szazalek = (double)this.pont / maxpont * 100;
            return Math.Round(szazalek, tizedes);
        }

        public override string ToString()
        {
            return $"{this.nyelv} ({this.Tipus}): {this.Eredmeny(1)}%";
        }
    }
}
