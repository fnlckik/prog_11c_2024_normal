using System;

namespace LegidosebbDolgozo
{
    internal class Program
    {
        static void Beolvas(out int n, int[] korok, int[] fizetesek)
        {
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] sor = Console.ReadLine().Split(' ');
                korok[i] = Convert.ToInt32(sor[0]);
                fizetesek[i] = Convert.ToInt32(sor[1]);
            }
        }

        static int MaxkorFizetes(int n, int[] korok, int[] fizetesek)
        {
            int maxi = 0;
            for (int i = 0; i < n; i++)
            {
                if (korok[i] > korok[maxi])
                {
                    maxi = i;
                }
            }
            return fizetesek[maxi];
        }

        static void Main(string[] args)
        {
            int[] korok = new int[100];
            int[] fizetesek = new int[100];
            Beolvas(out int n, korok, fizetesek);
            int legidosebbFizetese = MaxkorFizetes(n, korok, fizetesek);
            Console.WriteLine(legidosebbFizetese);
        }
    }
}
