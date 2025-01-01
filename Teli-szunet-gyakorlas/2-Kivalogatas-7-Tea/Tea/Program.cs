using System;

namespace Tea
{
    internal class Program
    {
        static void Beolvas(out int n, string[] tipusok, int[] mennyisegek)
        {
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                tipusok[i] = Console.ReadLine();
                mennyisegek[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        static string[] Kivalogat(int n, string[] tipusok, int[] mennyisegek, out int db)
        {
            string[] x = new string[100];
            db = 0;
            for (int i = 0; i < n; i++)
            {
                if (mennyisegek[i] > 500)
                {
                    x[db] = tipusok[i];
                    db++;
                }
            }
            return x;
        }

        static void Kiir(string[] cegek, int db)
        {
            Console.Write(db + " ");
            for (int i = 0; i < db; i++)
            {
                Console.Write(cegek[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            string[] tipusok = new string[100];
            int[] mennyisegek = new int[100];
            Beolvas(out int n, tipusok, mennyisegek);

            string[] cegek = Kivalogat(n, tipusok, mennyisegek, out int db);

            Kiir(cegek, db);
        }
    }
}
