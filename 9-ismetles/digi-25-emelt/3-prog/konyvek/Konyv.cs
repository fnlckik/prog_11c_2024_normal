namespace konyvek
{
    internal class Konyv
    {
        private int ev;
        private int negyedev;
        private bool magyarE;
        private string leiras;
        private int peldany;

        public Konyv(int ev, int negyedev, bool magyarE, string leiras, int peldany)
        {
            this.ev = ev;
            this.negyedev = negyedev;
            this.magyarE = magyarE;
            this.leiras = leiras;
            this.peldany = peldany;
        }

        // Döntsük el, hogy egy adott név a leírásban van-e?
        public bool SzerzoE(string nev)
        {
            // ???
        }
    }
}
