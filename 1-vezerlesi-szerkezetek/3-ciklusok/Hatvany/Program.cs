using System;

namespace Hatvany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double a = 2; // alap
            const int n = 5; // kitevo
            // 1*2*2*2*2*2

            double eredmeny = 1;
            for (int i = 0; i < n; i++)
            {
                // eredmeny = eredmeny * a;
                eredmeny *= a;
            }

            Console.WriteLine($"{a}^{n} = {eredmeny}");

            Console.ReadKey();
        }
    }
}
