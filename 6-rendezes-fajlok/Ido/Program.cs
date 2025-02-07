using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Ido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch ora = new Stopwatch(); // Példányosítás
            Console.WriteLine("Gyakoriság: " + Stopwatch.Frequency + " Hz");
            // 10 000 000 Hz = 10 MHz
            // Konklúzió: ez piszok pontos!

            const int n = 10000000;

            // Feltolt(10) => { 1, 2, 3, 4, ..., 10 }
            ora.Start();
            List<int> lista = Feltolt(n);
            ora.Stop();
            Console.WriteLine("Eltelt idő (lista): " + ora.ElapsedTicks);

            //ora.Reset();
            //ora.Start();
            ora.Restart();
            int[] tomb = Feltolt2(n);
            ora.Stop();
            Console.WriteLine("Eltelt idő (tömb): " + ora.ElapsedTicks);

            //Kiir(lista);
        }

        static int[] Feltolt2(int n)
        {
            int[] tomb = new int[n];
            for (int i = 0; i < n; i++)
            {
                tomb[i] = i + 1;
            }
            return tomb;
        }

        static void Kiir(List<int> lista)
        {
            foreach (int elem in lista)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }

        static List<int> Feltolt(int n)
        {
            List<int> eredmeny = new List<int>();
            for (int i = 0; i < n; i++)
            {
                eredmeny.Add(i+1);
            }
            return eredmeny;
        }
    }
}
