namespace Jegyek
{
    class Diak2
    {
        // 1. Adattagok
        private string nev;
        private int kor;
        private double hangulat;

        // 2. Konstruktorok
        public Diak2(string nev, int kor, double hangulat)
        {
            this.nev = nev;
            this.kor = kor;
            this.hangulat = hangulat;
        }

        // 3. Getter, Setter
        public string Nev
        { 
            get => nev;
            set
            {
                if (value == "" || value.Length > 20) return;
                this.nev = value;
            }
        }
        public int Kor { get => kor; }
        public double Hangulat { get => hangulat * 100; }

        // 4. Metódusok
        public void Pihen(int nap)
        {
            if (nap < 0) return;
            this.hangulat += nap * 0.05;
            if (this.hangulat > 1) this.hangulat = 1;
        }
    }
}
