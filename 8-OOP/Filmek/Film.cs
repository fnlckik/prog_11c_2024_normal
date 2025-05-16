namespace Filmek
{
    class Film
    {
        private string cim;
        private int ev;
        private string mufaj;
        private double imdb;
        private int nezok; // Hányan értékelték imdb-n?

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

        public string Cim { get => cim; }

        // Kiir() => ToString()
        public override string ToString()
        {
            return $"{this.cim} ({this.ev}) - {this.imdb}";
        }
    }
}
