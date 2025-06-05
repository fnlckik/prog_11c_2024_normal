using System;

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

        public int Peldany { get => peldany; }

        // Igaz-e, hogy az i. karaktertől indulva ott szerepel a név?
        private bool jo(int i, string nev)
        {
            int db = 0;
            int j = i;
            while (j < leiras.Length && db < nev.Length && nev[db] == leiras[j])
            {
                j++;
                db++;
            }
            return db >= nev.Length;
        }

        // Döntsük el, hogy egy adott név a leírásban van-e?
        //public bool SzerzoE(string nev)
        //{
        //    int i = 0;
        //    while (i < leiras.Length - nev.Length && !(leiras.Substring(i, nev.Length) == nev)) // !jo(i, nev)
        //    {
        //        i++;
        //    }
        //    return leiras.Substring(i, nev.Length) == nev; // jo(i, nev);
        //}

        public bool SzerzoE(string nev)
        {
            return this.leiras.Contains(nev);
        }
    }
}
