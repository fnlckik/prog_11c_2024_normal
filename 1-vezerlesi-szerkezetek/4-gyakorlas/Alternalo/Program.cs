using System;

namespace Alternalo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("n: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (!(10 <= n && n <= 5000));

            double s = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    s += (double) 1 / i;
                }
                else
                {
                    s -= (double) 1 / i;
                }
            }

            Console.WriteLine($"{s:0.000}");

            Console.ReadKey();
        }
    }
}
