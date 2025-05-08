namespace Filmek
{
    class Film
    {
        public string cim;
        public int ev;
        public string mufaj;
        public double imdb;
        public int nezok;

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

        // public ToString
    }
}
