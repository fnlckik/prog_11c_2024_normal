using System.Collections.Generic;

namespace Jegyek
{
    class Csoport
    {
        private int letszam;
        private List<Diak> diakok = new List<Diak>();

        public Csoport(int n)
        {
            this.letszam = n;
            for (int i = 0; i < n; i++)
            {
                Diak d = new Diak("Tivadar", 87, 0.11);
                this.diakok.Add(d);
            }
        }

        public int Letszam { get => this.letszam; }

        // Tivadar vagyok, 87 éves.
        // Tivadar vagyok, 87 éves.
        // Tivadar vagyok, 87 éves.
        public override string ToString()
        {
            string s = "";
            foreach (Diak diak in this.diakok)
            {
                s += diak.Bemutatkozas() + "\n";
            }
            return s;
        }
    }
}
