using System;

namespace Negyzetszam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // a) Első n darab négyzetszám!
            // 12 => 0 1 4 9 ... 121
            Console.WriteLine("a) feladat:");
            for (int i = 0; i < n; i++)
            {
                //Console.Write($"{i*i} ");
                Console.Write(i*i + " ");
            }

            // b) N-ig írjuk ki a négyzetszámokat!
            // 12 => 0 1 4 9
            Console.WriteLine();
            Console.WriteLine("b) feladat:");
            int j = 0;
            while (j*j < n)
            {
                Console.Write(j * j + " ");
                j++;
            }
            // Processzornak plusz munka! => Memóriában kevesebb!

            // c) N-ig írjuk ki a négyzetszámokat!
            // 12 => 0 1 4 9
            Console.WriteLine();
            Console.WriteLine("c) feladat:");
            int k = 0;
            int negyzet = k*k;
            while (negyzet < n)
            {
                Console.Write(negyzet + " ");
                k++;
                negyzet = k * k;
            }
            // Memóriában több! => Processzornak kevesebb a dolga!

            Console.ReadKey();
        }
    }
}
