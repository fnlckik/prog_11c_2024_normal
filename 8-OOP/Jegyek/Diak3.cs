using System;

namespace Jegyek
{
    class Diak3
    {
        // 1. Adattagok
        private string nev;
        private int kor;
        private double hangulat; // Pl.: 0.83

        // 2. Konstruktor
        public Diak3(string nev, int kor, double hangulat)
        {
            this.Nev = nev;
            this.Kor = kor;
            this.Hangulat = hangulat;
        }

        public string Nev
        {
            get => nev;
            set
            {
                if (value == "" || value.Length > 20) return;
                this.nev = value;
            }
        }
        public int Kor { get => kor; private set => kor = value; }
        public double Hangulat
        {
            get => hangulat * 100;
            private set => hangulat = value;
        }

        // 4. Metódusok
        public void Pihen(int nap)
        {
            if (nap < 0) return;
            this.Hangulat = this.Hangulat + nap * 0.05; // 83.15
            if (this.Hangulat > 1)
            {
                Console.WriteLine(this.Hangulat);
                this.Hangulat = 1; // 8315 > 1?
            }
        }
    }
}
