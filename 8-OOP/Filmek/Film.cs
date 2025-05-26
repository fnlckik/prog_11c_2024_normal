using System;
using System.Collections.Generic;

namespace Filmek
{
    public class Film
    {
        private string cim;
        private int ev;
        private string mufaj;
        private double imdb;
        private int nezok; // Hányan értékelték imdb-n?
        // Lista is lehetne.
        private HashSet<string> ervenyesek = new HashSet<string> { "akcio", "fantasy", "kaland", "horror" };

        public Film(string cim, int ev, string mufaj, double imdb, int nezok)
        {
            this.cim = cim;
            this.ev = ev;
            this.mufaj = mufaj;
            this.imdb = imdb;
            this.nezok = nezok;
        }

        // "Vérapó;2022;horror;7,5;15"
        public Film(string szoveg)
        {
            string[] sor = szoveg.Split(';');
            this.cim = sor[0];
            this.ev = int.Parse(sor[1]);
            this.mufaj = sor[2];
            this.imdb = double.Parse(sor[3]);
            this.nezok = int.Parse(sor[4]);
        }

        public string Cim { get => this.cim; }

        public string Ev
        {
            get
            {
                if (this.ev < 2019) return $"{this.ev} BC";
                return $"{this.ev} AC";
            }
        }

        //if (value == "akcio" || value == "kaland" || value == "fantasy" || value == "horror")
        //{
        //    this.mufaj = value;
        //}
        public string Mufaj
        {
            set
            {
                if (!ervenyesek.Contains(value)) return;
                this.mufaj = value;
            }
            get => this.mufaj;
        }

        public double Imdb
        {
            get => Math.Round(this.imdb, 2);
            //get
            //{
            //    return Math.Round(this.imdb, 2);
            //}
        }

        // Kiir() => ToString()
        public override string ToString()
        {
            return $"{this.cim} ({this.ev}) - {this.Imdb}";
        }

        public void Ertekel(int pont)
        {
            if (pont > 10 || pont < 0) return; // ha nem jó a pont, nem csinálunk semmit
            double osszeg = this.imdb * this.nezok; // 146.0
            osszeg += pont; // 152.0
            this.nezok++; // 21
            this.imdb = osszeg / this.nezok; // 7.24 // Kerekítéshez külön getter!
        }

        // Összehasonlít 2 filmet: igaz ha az első korábban készült
        public bool KorabbiE(Film film)
        {
            return this.ev < film.ev;
        }
    }
}
