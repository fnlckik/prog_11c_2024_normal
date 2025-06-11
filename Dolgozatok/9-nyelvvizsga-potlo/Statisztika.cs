using System.Collections.Generic;
using System.IO;

namespace Nyelvvizsga
{
    public class Statisztika
    {
        private List<Vizsga> vizsgak = new List<Vizsga>();

        public Statisztika(string fajl)
        {
            StreamReader sr = new StreamReader(fajl);
            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(';');
                int pont = int.Parse(sor[2]);
                if (sor.Length > 3) // komplex
                {
                    pont += int.Parse(sor[3]);
                }
                Vizsga vizsga = new Vizsga(sor[0], char.Parse(sor[1]), pont);
                vizsgak.Add(vizsga);
            }
            sr.Close();
        }

        public Vizsga LegjobbKomplex()
        {
            int i = 0;
            while (!(vizsgak[i].Tipus == "komplex")) // i < vizsgak.Count && 
            {
                i++;
            }
            Vizsga legjobb = vizsgak[i];
            foreach (Vizsga vizsga in vizsgak)
            {
                if (vizsga.Tipus == "komplex" && vizsga.Pont > legjobb.Pont)
                {
                    legjobb = vizsga;
                }
            }
            return legjobb;
        }

        // Nyelv szerint növekvőbe
        private void Rendez()
        {
            for (int i = 0; i < vizsgak.Count; i++)
            {
                for (int j = 0; j < vizsgak.Count - i - 1; j++)
                {
                    if (vizsgak[j].Nyelv.CompareTo(vizsgak[j+1].Nyelv) > 0)
                    {
                        (vizsgak[j], vizsgak[j + 1]) = (vizsgak[j + 1], vizsgak[j]);
                    }
                }
            }
        }

        public void Kiir(string fajl)
        {
            Rendez();
            StreamWriter sw = new StreamWriter(fajl);
            foreach (Vizsga vizsga in vizsgak)
            {
                sw.WriteLine(vizsga);
            }
            sw.Close();
        }
    }
}
