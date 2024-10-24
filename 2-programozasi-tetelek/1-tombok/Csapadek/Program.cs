using System;

namespace Csapadek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] csapadekok = new double[18];
            Random r = new Random();
            for (int i = 0; i < csapadekok.Length; i++)
            {
                double cs = (double) r.Next(180, 221) / 100;
                Console.Write(cs + " ");
                csapadekok[i] = cs;
            }
            Console.WriteLine();

            for (int i = 0; i < csapadekok.Length; i++)
            {
                Console.Write($"{i+1:00} - {i+2:00}. változás:");
                double elteres;
                if (csapadekok[i] < csapadekok[i+1])
                {
                    elteres = csapadekok[i + 1] - csapadekok[i];
                    Console.Write($"növekszik {elteres}");
                }
                else if (csapadekok[i] > csapadekok[i + 1])
                {
                    elteres = csapadekok[i] - csapadekok[i+1];
                    Console.Write($"csökken {elteres}");
                }
                else
                {
                    Console.Write("változatlan");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
