using System.Collections.Generic;
using System.IO;

namespace konyvek
{
    internal class Kiadas
    {
        private List<Konyv> konyvek;

        public Kiadas(string fajl)
        {
            konyvek = new List<Konyv>();
            StreamReader sr = new StreamReader(fajl);
            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(';');
                bool magyarE = sor[2] == "ma";
                Konyv konyv = new Konyv(int.Parse(sor[0]), int.Parse(sor[1]), magyarE, sor[3], int.Parse(sor[4]));
                konyvek.Add(konyv);
            }
            sr.Close();
        }

        public List<Konyv> Konyvek { get => new List<Konyv>(konyvek); }
    }
}
