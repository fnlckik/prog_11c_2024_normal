using System;

namespace Osztok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            // While előfeltétel tesztelés
            /*
            Console.Write("n: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n <= 0)
            {
                Console.WriteLine("Nem jó! Pozitív egész számot adj!");
                Console.Write("n: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            */

            do
            {
                Console.WriteLine("Adj meg egy pozitív egész számot, amelynek az osztóit szeretnéd tudni!");
                Console.Write("n: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
