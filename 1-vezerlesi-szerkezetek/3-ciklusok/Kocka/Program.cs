using System;

namespace Kocka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // a) Dobjunk egy kockával n-szer!
            Console.WriteLine("Dobások:");
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                int dobas = r.Next(1, 7); // 1..6
                Console.Write(dobas + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Dobások 6-ig:");
            // b) Dobáljunk, amíg 6-ost nem kapunk!
            int dobott;
            do
            {
                dobott = r.Next(1, 7);
                Console.Write(dobott + " ");
            } while (dobott != 6);

            Console.ReadKey();
        }
    }
}
