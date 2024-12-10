using System;

namespace Fuggvenyek
{
    internal class Program
    {
        static double Kerulet(double a, double b)
        {
            return 2*(a+b);
        }

        /*
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            } 
        */
        static bool ParosE(int a)
        {
            return a % 2 == 0;
        }

        // maxe: lokális változó
        static int Max(int[] t)
        {
            int maxe = t[0];
            for (int i = 1; i < t.Length; i++)
            {
                if (maxe < t[i])
                {
                    maxe = t[i];
                }
            }
            return maxe;
        }

        static void Main(string[] args)
        {
            // F1 - Kerület
            // C# - PascalCase (WriteLine)
            // JS - camalCase (addEventListener)
            // CSS - kebab-case (background-color)
            Console.WriteLine(Kerulet(3, 5));
            Console.WriteLine(Kerulet(1.25, 4));
            Console.WriteLine();

            // F2 - Páros-e?
            Console.WriteLine(ParosE(5)); // false
            Console.WriteLine(ParosE(162)); // true
            Console.WriteLine();

            // F3 - Maximum
            Console.WriteLine(Max(new int[] { 4, 7, -3, 12, 7, 14, -1 }));
            Console.WriteLine(Max(new int[] { -1 }));
        }
    }
}
