using System;

namespace Benzin
{
    internal class Program
    {
        static void Beolvas(out int k, out int n, out int b, out int l, int[] tavok, int[] mennyisegek)
        {
            string[] sor = Console.ReadLine().Split(' ');
            k = Convert.ToInt32(sor[0]);
            n = Convert.ToInt32(sor[1]);
            b = Convert.ToInt32(sor[2]);
            l = Convert.ToInt32(sor[3]);
            for (int i = 0; i < n; i++)
            {
                sor = Console.ReadLine().Split(' ');
                tavok[i] = Convert.ToInt32(sor[0]);
                mennyisegek[i] = Convert.ToInt32(sor[1]);
            }
        }

        static int Osszegzes(int km, int n, int benzin, int liter, int[] tavok, int[] mennyisegek)
        {
            int aktualisBenzin = benzin;
            int elozoHely = 0;
            for (int i = 0; i < n; i++)
            {
                int tav = tavok[i] - elozoHely; // utolsó megtett távolság (kilometerben)
                aktualisBenzin = aktualisBenzin - tav / 100 * liter + mennyisegek[i];
                elozoHely = tavok[i];
            }
            aktualisBenzin = aktualisBenzin - (km - elozoHely) / 100 * liter;
            return aktualisBenzin;
        }

        static void Main(string[] args)
        {
            int[] tavok = new int[1000];
            int[] mennyisegek = new int[1000];
            Beolvas(out int km, out int n, out int benzin, out int liter, tavok, mennyisegek);
            int s = Osszegzes(km, n, benzin, liter, tavok, mennyisegek);
            Console.WriteLine(s);
        }
    }
}
