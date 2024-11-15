using System;

namespace Jogositvany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            // Statikus tömbök: fordítási időben tudnunk kell a méretét!
            // EZ ÍGY NEM JÓ!!!
            // string[] nevek = new string[n];
            string[] nevek = new string[100];
            int[] korok = new int[100];
            bool[] jogsik = new bool[100]; // jogsik[i]: az i. adatnak van-e jogsija?

            // F1 - Beolvasás
            int i;
            for (i = 0; i < n; i++)
            {
                string sor = Console.ReadLine();
                Console.WriteLine(sor);
            }

            //Console.ReadKey();
        }
    }
}
