using System;

namespace Erme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 50;
            Random r = new Random();

            // a) Dobjunk fel egy érmét 50-szer!
            Console.WriteLine("Érme dobás 50-szer:");
            int dbF = 0, dbI = 0;
            for (int i = 0; i < n; i++)
            {
                int dobas = r.Next(1, 3); //1..2
                if (dobas == 1)
                {
                    Console.Write("F ");
                    dbF++;
                }
                else
                {
                    Console.Write("I ");
                    dbI++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Fejek száma: {dbF}");
            Console.WriteLine($"Írások száma: {dbI}");

            Console.ReadKey();
        }
    }
}
